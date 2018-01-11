namespace FinanceApplication.AddEditForms
{
    partial class AddTransactionForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.TransactionCostTextBox = new System.Windows.Forms.TextBox();
            this.TransactionNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TransactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionUserNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TransactionPlaceTextBox = new System.Windows.Forms.TextBox();
            this.financeApplicationDBDataSet4 = new FinanceApplication.FinanceApplicationDBDataSet4();
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(83, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Стоимость";
            // 
            // TransactionCostTextBox
            // 
            this.TransactionCostTextBox.Location = new System.Drawing.Point(167, 95);
            this.TransactionCostTextBox.Name = "TransactionCostTextBox";
            this.TransactionCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.TransactionCostTextBox.TabIndex = 18;
            this.TransactionCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransactionCostTextBox_KeyPress);
            // 
            // TransactionNameTextBox
            // 
            this.TransactionNameTextBox.Location = new System.Drawing.Point(167, 60);
            this.TransactionNameTextBox.Name = "TransactionNameTextBox";
            this.TransactionNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.TransactionNameTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Название покупки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(55, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Место покупки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(70, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите данные:";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(184, 254);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(83, 32);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(45, 254);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(110, 32);
            this.AcceptButton.TabIndex = 11;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(42, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Дата покупки";
            // 
            // TransactionDateTimePicker
            // 
            this.TransactionDateTimePicker.Location = new System.Drawing.Point(150, 198);
            this.TransactionDateTimePicker.Name = "TransactionDateTimePicker";
            this.TransactionDateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.TransactionDateTimePicker.TabIndex = 22;
            // 
            // TransactionUserNameTextBox
            // 
            this.TransactionUserNameTextBox.Location = new System.Drawing.Point(167, 163);
            this.TransactionUserNameTextBox.Name = "TransactionUserNameTextBox";
            this.TransactionUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.TransactionUserNameTextBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(92, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ваше имя";
            // 
            // TransactionPlaceTextBox
            // 
            this.TransactionPlaceTextBox.Location = new System.Drawing.Point(167, 130);
            this.TransactionPlaceTextBox.Name = "TransactionPlaceTextBox";
            this.TransactionPlaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.TransactionPlaceTextBox.TabIndex = 17;
            // 
            // financeApplicationDBDataSet4
            // 
            this.financeApplicationDBDataSet4.DataSetName = "FinanceApplicationDBDataSet4";
            this.financeApplicationDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 311);
            this.Controls.Add(this.TransactionUserNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TransactionDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TransactionCostTextBox);
            this.Controls.Add(this.TransactionPlaceTextBox);
            this.Controls.Add(this.TransactionNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Name = "AddTransactionForm";
            this.Text = "Транзакции";
            ((System.ComponentModel.ISupportInitialize)(this.financeApplicationDBDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TransactionCostTextBox;
        private System.Windows.Forms.TextBox TransactionNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TransactionDateTimePicker;
        private System.Windows.Forms.TextBox TransactionUserNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TransactionPlaceTextBox;
        private FinanceApplicationDBDataSet4 financeApplicationDBDataSet4;
    }
}