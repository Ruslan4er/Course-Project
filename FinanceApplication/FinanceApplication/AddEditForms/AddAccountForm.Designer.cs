namespace FinanceApplication
{
    partial class AddAccountForm
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
            this.CancelAddAccontButton = new System.Windows.Forms.Button();
            this.AcceptAddAccountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountNameTextBox = new System.Windows.Forms.TextBox();
            this.AccountBalanceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelAddAccontButton
            // 
            this.CancelAddAccontButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelAddAccontButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddAccontButton.Location = new System.Drawing.Point(165, 152);
            this.CancelAddAccontButton.Name = "CancelAddAccontButton";
            this.CancelAddAccontButton.Size = new System.Drawing.Size(107, 32);
            this.CancelAddAccontButton.TabIndex = 0;
            this.CancelAddAccontButton.Text = "Отмена";
            this.CancelAddAccontButton.UseVisualStyleBackColor = true;
            this.CancelAddAccontButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AcceptAddAccountButton
            // 
            this.AcceptAddAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptAddAccountButton.Location = new System.Drawing.Point(30, 152);
            this.AcceptAddAccountButton.Name = "AcceptAddAccountButton";
            this.AcceptAddAccountButton.Size = new System.Drawing.Size(113, 32);
            this.AcceptAddAccountButton.TabIndex = 1;
            this.AcceptAddAccountButton.Text = "Принять";
            this.AcceptAddAccountButton.UseVisualStyleBackColor = true;
            this.AcceptAddAccountButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите данные:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя держателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Начальный баланс";
            // 
            // AccountNameTextBox
            // 
            this.AccountNameTextBox.Location = new System.Drawing.Point(145, 64);
            this.AccountNameTextBox.Name = "AccountNameTextBox";
            this.AccountNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.AccountNameTextBox.TabIndex = 5;
            // 
            // AccountBalanceTextBox
            // 
            this.AccountBalanceTextBox.Location = new System.Drawing.Point(145, 97);
            this.AccountBalanceTextBox.Name = "AccountBalanceTextBox";
            this.AccountBalanceTextBox.Size = new System.Drawing.Size(127, 20);
            this.AccountBalanceTextBox.TabIndex = 6;
            this.AccountBalanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountBalanceTextBox_KeyPress);
            // 
            // AddAccountForm
            // 
            this.AcceptButton = this.AcceptAddAccountButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelAddAccontButton;
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.Controls.Add(this.AccountBalanceTextBox);
            this.Controls.Add(this.AccountNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcceptAddAccountButton);
            this.Controls.Add(this.CancelAddAccontButton);
            this.Name = "AddAccountForm";
            this.Text = "Добавление счета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelAddAccontButton;
        private System.Windows.Forms.Button AcceptAddAccountButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AccountNameTextBox;
        private System.Windows.Forms.TextBox AccountBalanceTextBox;
    }
}