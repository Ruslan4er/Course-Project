namespace FinanceApplication
{
    partial class AmortisationManagementForm
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
            this.EditAmortisationPurchaseButton = new System.Windows.Forms.Button();
            this.AddAmortisationPurchaseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AmortisationDataGridView = new System.Windows.Forms.DataGridView();
            this.AmortisationUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.amortisationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeApplicationDBDataSet1 = new FinanceApplication.FinanceApplicationDBDataSet1();
            this.amortisationTableAdapter = new FinanceApplication.FinanceApplicationDBDataSet1TableAdapters.AmortisationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AmortisationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortisationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выберите действие:";
            // 
            // ToMainMenuButton
            // 
            this.ToMainMenuButton.Location = new System.Drawing.Point(9, 292);
            this.ToMainMenuButton.Name = "ToMainMenuButton";
            this.ToMainMenuButton.Size = new System.Drawing.Size(143, 29);
            this.ToMainMenuButton.TabIndex = 10;
            this.ToMainMenuButton.Text = "В главное меню";
            this.ToMainMenuButton.UseVisualStyleBackColor = true;
            this.ToMainMenuButton.Click += new System.EventHandler(this.ToMainMenuButton_Click);
            // 
            // EditAmortisationPurchaseButton
            // 
            this.EditAmortisationPurchaseButton.Location = new System.Drawing.Point(26, 194);
            this.EditAmortisationPurchaseButton.Name = "EditAmortisationPurchaseButton";
            this.EditAmortisationPurchaseButton.Size = new System.Drawing.Size(95, 51);
            this.EditAmortisationPurchaseButton.TabIndex = 9;
            this.EditAmortisationPurchaseButton.Text = "Пометить как выполненное";
            this.EditAmortisationPurchaseButton.UseVisualStyleBackColor = true;
            this.EditAmortisationPurchaseButton.Click += new System.EventHandler(this.EditAmortisationPurchaseButton_Click);
            // 
            // AddAmortisationPurchaseButton
            // 
            this.AddAmortisationPurchaseButton.Location = new System.Drawing.Point(26, 124);
            this.AddAmortisationPurchaseButton.Name = "AddAmortisationPurchaseButton";
            this.AddAmortisationPurchaseButton.Size = new System.Drawing.Size(95, 47);
            this.AddAmortisationPurchaseButton.TabIndex = 8;
            this.AddAmortisationPurchaseButton.Text = "Добавить\r\nпокупку";
            this.AddAmortisationPurchaseButton.UseVisualStyleBackColor = true;
            this.AddAmortisationPurchaseButton.Click += new System.EventHandler(this.AddAmortisationPurchaseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Управление амортизируемыми покупками";
            // 
            // AmortisationDataGridView
            // 
            this.AmortisationDataGridView.AllowUserToAddRows = false;
            this.AmortisationDataGridView.AllowUserToDeleteRows = false;
            this.AmortisationDataGridView.AutoGenerateColumns = false;
            this.AmortisationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AmortisationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AmortisationUID,
            this.nameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.AmortisationDataGridView.DataSource = this.amortisationBindingSource;
            this.AmortisationDataGridView.Location = new System.Drawing.Point(171, 66);
            this.AmortisationDataGridView.Name = "AmortisationDataGridView";
            this.AmortisationDataGridView.ReadOnly = true;
            this.AmortisationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AmortisationDataGridView.Size = new System.Drawing.Size(435, 255);
            this.AmortisationDataGridView.TabIndex = 6;
            // 
            // AmortisationUID
            // 
            this.AmortisationUID.DataPropertyName = "AmortisationUID";
            this.AmortisationUID.HeaderText = "AmortisationUID";
            this.AmortisationUID.Name = "AmortisationUID";
            this.AmortisationUID.ReadOnly = true;
            this.AmortisationUID.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // amortisationBindingSource
            // 
            this.amortisationBindingSource.DataMember = "Amortisation";
            this.amortisationBindingSource.DataSource = this.financeApplicationDBDataSet1;
            // 
            // financeApplicationDBDataSet1
            // 
            this.financeApplicationDBDataSet1.DataSetName = "FinanceApplicationDBDataSet1";
            this.financeApplicationDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // amortisationTableAdapter
            // 
            this.amortisationTableAdapter.ClearBeforeFill = true;
            // 
            // AmortisationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToMainMenuButton);
            this.Controls.Add(this.EditAmortisationPurchaseButton);
            this.Controls.Add(this.AddAmortisationPurchaseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmortisationDataGridView);
            this.Name = "AmortisationManagementForm";
            this.Text = "Управление амортизируемыми покупками";
            this.Load += new System.EventHandler(this.AmortisationManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AmortisationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortisationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ToMainMenuButton;
        private System.Windows.Forms.Button EditAmortisationPurchaseButton;
        private System.Windows.Forms.Button AddAmortisationPurchaseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AmortisationDataGridView;
        private FinanceApplicationDBDataSet1 financeApplicationDBDataSet1;
        private System.Windows.Forms.BindingSource amortisationBindingSource;
        private FinanceApplicationDBDataSet1TableAdapters.AmortisationTableAdapter amortisationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmortisationUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}