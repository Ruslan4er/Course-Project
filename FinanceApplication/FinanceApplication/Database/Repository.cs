using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApplication.Database
{
    public class Repository
    {

        public static IQueryable<TEntity> Select<TEntity>(DbContext context)
            where TEntity : class
        {
            //var context = new FinanceApplicationDBEntities3();

            // Здесь мы можем указывать различные настройки контекста,
            // например выводить в отладчик сгенерированный SQL-код
            context.Database.Log =
                (s => System.Diagnostics.Debug.WriteLine(s));

            // Загрузка данных с помощью универсального метода Set
            return context.Set<TEntity>();
        }


        // ВСТАВКА ОДНОГО ОБЪЕКТА
        public static void Insert<TEntity>(TEntity entity) where TEntity : class
        {
            var context = new FinanceApplicationDBEntities3();

            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }


        /// ЗАПИСЬ НЕСКОЛЬКИХ ПОЛЕЙ В БД

        public static void Inserts<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            // Настройки контекста

            var context = new FinanceApplicationDBEntities3();
            // Отключаем отслеживание и проверку изменений для оптимизации вставки множества полей
            context.Configuration.AutoDetectChangesEnabled = false;
            context.Configuration.ValidateOnSaveEnabled = false;

            context.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));


            foreach (TEntity entity in entities)
                context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();

            context.Configuration.AutoDetectChangesEnabled = true;
            context.Configuration.ValidateOnSaveEnabled = true;

        }

        public static void Update<TEntity>(TEntity entity, FinanceApplicationDBEntities3 context)
            where TEntity : class
        {
            // Настройки контекста
           // context.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));


            context.Entry<TEntity>(entity).State = EntityState.Modified;
            context.SaveChanges();
        }



        //УДАЛЕНИЕ
        public static void Delete<TEntity>(TEntity entity)
            where TEntity : class
        {
            // Настройки контекста 
            var context = new FinanceApplicationDBEntities3();

            context.Entry<TEntity>(entity).State = EntityState.Deleted;

            context.SaveChanges();
        }

        public static void Update<TEntity>(TEntity entity, DbContext context)
            where TEntity : class
        {
            //var context = new FinanceApplicationDBEntities3();
            context.Entry<TEntity>(entity).State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}


