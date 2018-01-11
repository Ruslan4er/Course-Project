namespace FinanceApplication
{
    partial class AddEditUserForm
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
            this.AcceptAddUserButton = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserSurnameTextBox = new System.Windows.Forms.TextBox();
            this.UserAgeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelAddUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AcceptAddUserButton
            // 
            this.AcceptAddUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptAddUserButton.Location = new System.Drawing.Point(12, 185);
            this.AcceptAddUserButton.Name = "AcceptAddUserButton";
            this.AcceptAddUserButton.Size = new System.Drawing.Size(115, 33);
            this.AcceptAddUserButton.TabIndex = 1;
            this.AcceptAddUserButton.Text = "Принять";
            this.AcceptAddUserButton.UseVisualStyleBackColor = true;
            this.AcceptAddUserButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(72, 55);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(132, 20);
            this.UserNameTextBox.TabIndex = 2;
            // 
            // UserSurnameTextBox
            // 
            this.UserSurnameTextBox.Location = new System.Drawing.Point(72, 92);
            this.UserSurnameTextBox.Name = "UserSurnameTextBox";
            this.UserSurnameTextBox.Size = new System.Drawing.Size(132, 20);
            this.UserSurnameTextBox.TabIndex = 3;
            // 
            // UserAgeTextBox
            // 
            this.UserAgeTextBox.Location = new System.Drawing.Point(72, 129);
            this.UserAgeTextBox.Name = "UserAgeTextBox";
            this.UserAgeTextBox.Size = new System.Drawing.Size(132, 20);
            this.UserAgeTextBox.TabIndex = 4;
            this.UserAgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserAgeTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите данные:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Возраст";
            // 
            // CancelAddUserButton
            // 
            this.CancelAddUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelAddUserButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddUserButton.Location = new System.Drawing.Point(143, 185);
            this.CancelAddUserButton.Name = "CancelAddUserButton";
            this.CancelAddUserButton.Size = new System.Drawing.Size(94, 33);
            this.CancelAddUserButton.TabIndex = 9;
            this.CancelAddUserButton.Text = "Отмена";
            this.CancelAddUserButton.UseVisualStyleBackColor = true;
            this.CancelAddUserButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddEditUserForm
            // 
            this.AcceptButton = this.AcceptAddUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelAddUserButton;
            this.ClientSize = new System.Drawing.Size(252, 232);
            this.Controls.Add(this.CancelAddUserButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserAgeTextBox);
            this.Controls.Add(this.UserSurnameTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.AcceptAddUserButton);
            this.Name = "AddEditUserForm";
            this.Text = "Добавить пользователя";
            this.Load += new System.EventHandler(this.AddEditUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptAddUserButton;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox UserSurnameTextBox;
        private System.Windows.Forms.TextBox UserAgeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelAddUserButton;
    }
}