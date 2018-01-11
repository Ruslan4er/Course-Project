namespace FinanceApplication.AddEditForms
{
    partial class DeleteUserForm
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
            this.CancelAddUserButton = new System.Windows.Forms.Button();
            this.AcceptAddUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelAddUserButton
            // 
            this.CancelAddUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelAddUserButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddUserButton.Location = new System.Drawing.Point(161, 106);
            this.CancelAddUserButton.Name = "CancelAddUserButton";
            this.CancelAddUserButton.Size = new System.Drawing.Size(94, 33);
            this.CancelAddUserButton.TabIndex = 23;
            this.CancelAddUserButton.Text = "Отмена";
            this.CancelAddUserButton.UseVisualStyleBackColor = true;
            this.CancelAddUserButton.Click += new System.EventHandler(this.CancelAddUserButton_Click);
            // 
            // AcceptAddUserButton
            // 
            this.AcceptAddUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptAddUserButton.Location = new System.Drawing.Point(30, 106);
            this.AcceptAddUserButton.Name = "AcceptAddUserButton";
            this.AcceptAddUserButton.Size = new System.Drawing.Size(115, 33);
            this.AcceptAddUserButton.TabIndex = 22;
            this.AcceptAddUserButton.Text = "Принять";
            this.AcceptAddUserButton.UseVisualStyleBackColor = true;
            this.AcceptAddUserButton.Click += new System.EventHandler(this.AcceptAddUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 44);
            this.label1.TabIndex = 24;
            this.label1.Text = "Вы действительно хотите \r\nудалить этого пользователя?\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 160);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelAddUserButton);
            this.Controls.Add(this.AcceptAddUserButton);
            this.Name = "DeleteUserForm";
            this.Text = "Редактировать пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelAddUserButton;
        private System.Windows.Forms.Button AcceptAddUserButton;
        private System.Windows.Forms.Label label1;
    }
}