namespace FinanceApplication
{
    partial class AddPlannedPurchaseForm
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PPurchaseNameTextBox = new System.Windows.Forms.TextBox();
            this.PPUserTextBox = new System.Windows.Forms.TextBox();
            this.PPurchaseCostTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(27, 190);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(110, 32);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(166, 190);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(83, 32);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите данные:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кто оплачивает";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название покупки";
            // 
            // PPurchaseNameTextBox
            // 
            this.PPurchaseNameTextBox.Location = new System.Drawing.Point(149, 69);
            this.PPurchaseNameTextBox.Name = "PPurchaseNameTextBox";
            this.PPurchaseNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.PPurchaseNameTextBox.TabIndex = 6;
            // 
            // PPUserTextBox
            // 
            this.PPUserTextBox.Location = new System.Drawing.Point(149, 139);
            this.PPUserTextBox.Name = "PPUserTextBox";
            this.PPUserTextBox.Size = new System.Drawing.Size(100, 20);
            this.PPUserTextBox.TabIndex = 7;
            // 
            // PPurchaseCostTextBox
            // 
            this.PPurchaseCostTextBox.Location = new System.Drawing.Point(149, 104);
            this.PPurchaseCostTextBox.Name = "PPurchaseCostTextBox";
            this.PPurchaseCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.PPurchaseCostTextBox.TabIndex = 9;
            this.PPurchaseCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PPurchaseCostTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(65, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Стоимость";
            // 
            // AddPlannedPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 239);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PPurchaseCostTextBox);
            this.Controls.Add(this.PPUserTextBox);
            this.Controls.Add(this.PPurchaseNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Name = "AddPlannedPurchaseForm";
            this.Text = "Запланированные покупки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PPurchaseNameTextBox;
        private System.Windows.Forms.TextBox PPUserTextBox;
        private System.Windows.Forms.TextBox PPurchaseCostTextBox;
        private System.Windows.Forms.Label label5;
    }
}