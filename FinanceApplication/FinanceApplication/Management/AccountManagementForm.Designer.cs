namespace FinanceApplication
{
    partial class AccountManagementForm
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
            this.AccountDataGridView = new System.Windows.Forms.DataGridView();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeApplicationDBDataSet = new FinanceApplication.FinanceApplicationDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.CloseAccountButton = new System.Windows.Forms.Button();
            this.ToMainMenuButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accountTableAdapter = new FinanceApplication.FinanceApplicationDBDataSetTableAdapters.AccountTableAdapter();
            this.AccountUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountDataGridView
            // 
            this.AccountDataGridView.AllowUserToAddRows = false;
            this.AccountDataGridView.AllowUserToDeleteRows = false;
            this.AccountDataGridView.AutoGenerateColumns = false;
            this.AccountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountUID,
            this.nameDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.AccountDataGridView.DataSource = this.accountBindingSource;
            this.AccountDataGridView.Location = new System.Drawing.Point(178, 69);
            this.AccountDataGridView.Name = "AccountDataGridView";
            this.AccountDataGridView.ReadOnly = true;
            this.AccountDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountDataGridView.Size = new System.Drawing.Size(373, 255);
            this.AccountDataGridView.TabIndex = 0;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.financeApplicationDBDataSet;
            // 
            // financeApplicationDBDataSet
            // 
            this.financeApplicationDBDataSet.DataSetName = "FinanceApplicationDBDataSet";
            this.financeApplicationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Управление счетами";
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(33, 127);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(95, 47);
            this.AddAccountButton.TabIndex = 2;
            this.AddAccountButton.Text = "Добавить\r\nсчет";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // CloseAccountButton
            // 
            this.CloseAccountButton.Location = new System.Drawing.Point(33, 197);
            this.CloseAccountButton.Name = "CloseAccountButton";
            this.CloseAccountButton.Size = new System.Drawing.Size(95, 51);
            this.CloseAccountButton.TabIndex = 3;
            this.CloseAccountButton.Text = "Закрыть\r\nсчет";
            this.CloseAccountButton.UseVisualStyleBackColor = true;
            this.CloseAccountButton.Click += new System.EventHandler(this.CloseAccountButton_Click);
            // 
            // ToMainMenuButton
            // 
            this.ToMainMenuButton.Location = new System.Drawing.Point(16, 295);
            this.ToMainMenuButton.Name = "ToMainMenuButton";
            this.ToMainMenuButton.Size = new System.Drawing.Size(143, 29);
            this.ToMainMenuButton.TabIndex = 4;
            this.ToMainMenuButton.Text = "В главное меню";
            this.ToMainMenuButton.UseVisualStyleBackColor = true;
            this.ToMainMenuButton.Click += new System.EventHandler(this.ToMainMenuButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите действие:";
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // AccountUID
            // 
            this.AccountUID.DataPropertyName = "AccountUID";
            this.AccountUID.HeaderText = "AccountUID";
            this.AccountUID.Name = "AccountUID";
            this.AccountUID.ReadOnly = true;
            this.AccountUID.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя держателя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Баланс";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // AccountManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToMainMenuButton);
            this.Controls.Add(this.CloseAccountButton);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountDataGridView);
            this.Name = "AccountManagementForm";
            this.Text = "Управление счетами";
            this.Load += new System.EventHandler(this.AccountManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button CloseAccountButton;
        private System.Windows.Forms.Button ToMainMenuButton;
        private System.Windows.Forms.Label label2;
        private FinanceApplicationDBDataSet financeApplicationDBDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private FinanceApplicationDBDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}