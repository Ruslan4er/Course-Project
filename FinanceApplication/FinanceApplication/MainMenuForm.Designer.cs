namespace FinanceApplication
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountWhereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeApplicationDBDataSet4 = new FinanceApplication.FinanceApplicationDBDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.UserFormButton = new System.Windows.Forms.Button();
            this.AccountFormButton = new System.Windows.Forms.Button();
            this.PPurchaseButton = new System.Windows.Forms.Button();
            this.AmortisationFormButton = new System.Windows.Forms.Button();
            this.AddTransactionFormButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.YearReportButton = new System.Windows.Forms.Button();
            this.financeApplicationDBDataSet2 = new FinanceApplication.FinanceApplicationDBDataSet2();
            this.financeApplicationDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new FinanceApplication.FinanceApplicationDBDataSet4TableAdapters.PostTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.accountWhereDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(466, 290);
            this.dataGridView1.TabIndex = 1;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountWhereDataGridViewTextBoxColumn
            // 
            this.accountWhereDataGridViewTextBoxColumn.DataPropertyName = "AccountWhere";
            this.accountWhereDataGridViewTextBoxColumn.HeaderText = "Магазин";
            this.accountWhereDataGridViewTextBoxColumn.Name = "accountWhereDataGridViewTextBoxColumn";
            this.accountWhereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Итог";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.financeApplicationDBDataSet4;
            // 
            // financeApplicationDBDataSet4
            // 
            this.financeApplicationDBDataSet4.DataSetName = "FinanceApplicationDBDataSet4";
            this.financeApplicationDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // UserFormButton
            // 
            this.UserFormButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UserFormButton.Location = new System.Drawing.Point(12, 13);
            this.UserFormButton.Name = "UserFormButton";
            this.UserFormButton.Size = new System.Drawing.Size(145, 64);
            this.UserFormButton.TabIndex = 10;
            this.UserFormButton.Text = "Пользователи";
            this.UserFormButton.UseVisualStyleBackColor = true;
            this.UserFormButton.Click += new System.EventHandler(this.UserFormButton_Click);
            // 
            // AccountFormButton
            // 
            this.AccountFormButton.Location = new System.Drawing.Point(153, 13);
            this.AccountFormButton.Name = "AccountFormButton";
            this.AccountFormButton.Size = new System.Drawing.Size(155, 64);
            this.AccountFormButton.TabIndex = 11;
            this.AccountFormButton.Text = "Счета";
            this.AccountFormButton.UseVisualStyleBackColor = true;
            this.AccountFormButton.Click += new System.EventHandler(this.AccountFormButton_Click);
            // 
            // PPurchaseButton
            // 
            this.PPurchaseButton.Location = new System.Drawing.Point(304, 13);
            this.PPurchaseButton.Name = "PPurchaseButton";
            this.PPurchaseButton.Size = new System.Drawing.Size(153, 64);
            this.PPurchaseButton.TabIndex = 12;
            this.PPurchaseButton.Text = "Планирование\r\nпокупок\r\n";
            this.PPurchaseButton.UseVisualStyleBackColor = true;
            this.PPurchaseButton.Click += new System.EventHandler(this.PPurchaseButton_Click);
            // 
            // AmortisationFormButton
            // 
            this.AmortisationFormButton.Location = new System.Drawing.Point(453, 13);
            this.AmortisationFormButton.Name = "AmortisationFormButton";
            this.AmortisationFormButton.Size = new System.Drawing.Size(162, 64);
            this.AmortisationFormButton.TabIndex = 13;
            this.AmortisationFormButton.Text = "Амортизация";
            this.AmortisationFormButton.UseVisualStyleBackColor = true;
            this.AmortisationFormButton.Click += new System.EventHandler(this.AmortisationFormButton_Click);
            // 
            // AddTransactionFormButton
            // 
            this.AddTransactionFormButton.Location = new System.Drawing.Point(484, 97);
            this.AddTransactionFormButton.Name = "AddTransactionFormButton";
            this.AddTransactionFormButton.Size = new System.Drawing.Size(121, 64);
            this.AddTransactionFormButton.TabIndex = 14;
            this.AddTransactionFormButton.Text = "Добавить транзакцию";
            this.AddTransactionFormButton.UseVisualStyleBackColor = true;
            this.AddTransactionFormButton.Click += new System.EventHandler(this.AddTransactionFormButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(484, 338);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(121, 35);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // YearReportButton
            // 
            this.YearReportButton.Location = new System.Drawing.Point(484, 231);
            this.YearReportButton.Name = "YearReportButton";
            this.YearReportButton.Size = new System.Drawing.Size(121, 37);
            this.YearReportButton.TabIndex = 17;
            this.YearReportButton.Text = "Отчет";
            this.YearReportButton.UseVisualStyleBackColor = true;
            this.YearReportButton.Click += new System.EventHandler(this.YearReportButton_Click);
            // 
            // financeApplicationDBDataSet2
            // 
            this.financeApplicationDBDataSet2.DataSetName = "FinanceApplicationDBDataSet2";
            this.financeApplicationDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financeApplicationDBDataSet2BindingSource
            // 
            this.financeApplicationDBDataSet2BindingSource.DataSource = this.financeApplicationDBDataSet2;
            this.financeApplicationDBDataSet2BindingSource.Position = 0;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(617, 385);
            this.Controls.Add(this.YearReportButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddTransactionFormButton);
            this.Controls.Add(this.AmortisationFormButton);
            this.Controls.Add(this.PPurchaseButton);
            this.Controls.Add(this.AccountFormButton);
            this.Controls.Add(this.UserFormButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainMenuForm";
            this.Text = "Домашняя бухгалтерия";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserFormButton;
        private System.Windows.Forms.Button AccountFormButton;
        private System.Windows.Forms.Button PPurchaseButton;
        private System.Windows.Forms.Button AmortisationFormButton;
        private System.Windows.Forms.Button AddTransactionFormButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button YearReportButton;
        private System.Windows.Forms.BindingSource financeApplicationDBDataSet2BindingSource;
        private FinanceApplicationDBDataSet2 financeApplicationDBDataSet2;
        private FinanceApplicationDBDataSet4 financeApplicationDBDataSet4;
        private System.Windows.Forms.BindingSource postBindingSource;
        private FinanceApplicationDBDataSet4TableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountWhereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}