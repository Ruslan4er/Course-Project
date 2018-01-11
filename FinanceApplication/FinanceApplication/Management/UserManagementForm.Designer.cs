namespace FinanceApplication
{
    partial class UserManagementForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.ToMainMenuButton = new System.Windows.Forms.Button();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserManagementGridView = new System.Windows.Forms.DataGridView();
            this.UserUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeApplicationDBDataSet3 = new FinanceApplication.FinanceApplicationDBDataSet3();
            this.userTableAdapter = new FinanceApplication.FinanceApplicationDBDataSet3TableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UserManagementGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выберите действие:";
            // 
            // ToMainMenuButton
            // 
            this.ToMainMenuButton.Location = new System.Drawing.Point(15, 289);
            this.ToMainMenuButton.Name = "ToMainMenuButton";
            this.ToMainMenuButton.Size = new System.Drawing.Size(143, 29);
            this.ToMainMenuButton.TabIndex = 10;
            this.ToMainMenuButton.Text = "В главное меню";
            this.ToMainMenuButton.UseVisualStyleBackColor = true;
            this.ToMainMenuButton.Click += new System.EventHandler(this.ToMainMenuButton_Click);
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(32, 191);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(95, 51);
            this.EditUserButton.TabIndex = 9;
            this.EditUserButton.Text = "Удалить\r\nпользователя";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(32, 121);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(95, 47);
            this.AddUserButton.TabIndex = 8;
            this.AddUserButton.Text = "Добавить\r\nпользователя\r\n";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(122, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Управление пользователями";
            // 
            // UserManagementGridView
            // 
            this.UserManagementGridView.AllowUserToAddRows = false;
            this.UserManagementGridView.AllowUserToDeleteRows = false;
            this.UserManagementGridView.AutoGenerateColumns = false;
            this.UserManagementGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserManagementGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserUID,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.UserManagementGridView.DataSource = this.userBindingSource;
            this.UserManagementGridView.Location = new System.Drawing.Point(177, 63);
            this.UserManagementGridView.Name = "UserManagementGridView";
            this.UserManagementGridView.ReadOnly = true;
            this.UserManagementGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserManagementGridView.Size = new System.Drawing.Size(373, 255);
            this.UserManagementGridView.TabIndex = 6;
            // 
            // UserUID
            // 
            this.UserUID.DataPropertyName = "UserUID";
            this.UserUID.HeaderText = "UserUID";
            this.UserUID.Name = "UserUID";
            this.UserUID.ReadOnly = true;
            this.UserUID.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.financeApplicationDBDataSet3;
            // 
            // financeApplicationDBDataSet3
            // 
            this.financeApplicationDBDataSet3.DataSetName = "FinanceApplicationDBDataSet3";
            this.financeApplicationDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToMainMenuButton);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserManagementGridView);
            this.Name = "UserManagementForm";
            this.Text = "UserManagementForm";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserManagementGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ToMainMenuButton;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UserManagementGridView;
        private FinanceApplicationDBDataSet3 financeApplicationDBDataSet3;
        private System.Windows.Forms.BindingSource userBindingSource;
        private FinanceApplicationDBDataSet3TableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}