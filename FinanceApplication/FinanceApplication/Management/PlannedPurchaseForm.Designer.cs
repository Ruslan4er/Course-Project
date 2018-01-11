namespace FinanceApplication
{
    partial class PlannedPurchaseForm
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
            this.EditPurchaseButton = new System.Windows.Forms.Button();
            this.AddPurchaseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PPDataGridView = new System.Windows.Forms.DataGridView();
            this.PPUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.planedPurchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeApplicationDBDataSet2 = new FinanceApplication.FinanceApplicationDBDataSet2();
            this.planedPurchasesTableAdapter = new FinanceApplication.FinanceApplicationDBDataSet2TableAdapters.PlanedPurchasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planedPurchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Выберите действие:";
            // 
            // ToMainMenuButton
            // 
            this.ToMainMenuButton.Location = new System.Drawing.Point(17, 299);
            this.ToMainMenuButton.Name = "ToMainMenuButton";
            this.ToMainMenuButton.Size = new System.Drawing.Size(143, 29);
            this.ToMainMenuButton.TabIndex = 16;
            this.ToMainMenuButton.Text = "В главное меню";
            this.ToMainMenuButton.UseVisualStyleBackColor = true;
            this.ToMainMenuButton.Click += new System.EventHandler(this.ToMainMenuButton_Click);
            // 
            // EditPurchaseButton
            // 
            this.EditPurchaseButton.Location = new System.Drawing.Point(34, 201);
            this.EditPurchaseButton.Name = "EditPurchaseButton";
            this.EditPurchaseButton.Size = new System.Drawing.Size(95, 51);
            this.EditPurchaseButton.TabIndex = 15;
            this.EditPurchaseButton.Text = "Пометить как выполенное";
            this.EditPurchaseButton.UseVisualStyleBackColor = true;
            this.EditPurchaseButton.Click += new System.EventHandler(this.EditPurchaseButton_Click);
            // 
            // AddPurchaseButton
            // 
            this.AddPurchaseButton.Location = new System.Drawing.Point(34, 131);
            this.AddPurchaseButton.Name = "AddPurchaseButton";
            this.AddPurchaseButton.Size = new System.Drawing.Size(95, 47);
            this.AddPurchaseButton.TabIndex = 14;
            this.AddPurchaseButton.Text = "Добавить\r\nпокупку";
            this.AddPurchaseButton.UseVisualStyleBackColor = true;
            this.AddPurchaseButton.Click += new System.EventHandler(this.AddPurchaseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(124, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Управление планируемыми покупками";
            // 
            // PPDataGridView
            // 
            this.PPDataGridView.AllowUserToAddRows = false;
            this.PPDataGridView.AllowUserToDeleteRows = false;
            this.PPDataGridView.AutoGenerateColumns = false;
            this.PPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PPUID,
            this.nameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.PPDataGridView.DataSource = this.planedPurchasesBindingSource;
            this.PPDataGridView.Location = new System.Drawing.Point(179, 73);
            this.PPDataGridView.Name = "PPDataGridView";
            this.PPDataGridView.ReadOnly = true;
            this.PPDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PPDataGridView.Size = new System.Drawing.Size(435, 255);
            this.PPDataGridView.TabIndex = 12;
            // 
            // PPUID
            // 
            this.PPUID.DataPropertyName = "PPUID";
            this.PPUID.HeaderText = "PPUID";
            this.PPUID.Name = "PPUID";
            this.PPUID.ReadOnly = true;
            this.PPUID.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Покупка";
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
            // planedPurchasesBindingSource
            // 
            this.planedPurchasesBindingSource.DataMember = "PlanedPurchases";
            this.planedPurchasesBindingSource.DataSource = this.financeApplicationDBDataSet2;
            // 
            // financeApplicationDBDataSet2
            // 
            this.financeApplicationDBDataSet2.DataSetName = "FinanceApplicationDBDataSet2";
            this.financeApplicationDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planedPurchasesTableAdapter
            // 
            this.planedPurchasesTableAdapter.ClearBeforeFill = true;
            // 
            // PlannedPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToMainMenuButton);
            this.Controls.Add(this.EditPurchaseButton);
            this.Controls.Add(this.AddPurchaseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PPDataGridView);
            this.Name = "PlannedPurchaseForm";
            this.Text = "Управление планируемыми покупками";
            this.Load += new System.EventHandler(this.PlannedPurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planedPurchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ToMainMenuButton;
        private System.Windows.Forms.Button EditPurchaseButton;
        private System.Windows.Forms.Button AddPurchaseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PPDataGridView;
        private FinanceApplicationDBDataSet2 financeApplicationDBDataSet2;
        private System.Windows.Forms.BindingSource planedPurchasesBindingSource;
        private FinanceApplicationDBDataSet2TableAdapters.PlanedPurchasesTableAdapter planedPurchasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}