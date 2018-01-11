namespace FinanceApplication.AddEditForms
{
    partial class CloseAccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AcceptCloseAccountButton = new System.Windows.Forms.Button();
            this.CancelCloseAccontButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы действительно хотите \r\nудалить этот счет ?\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AcceptCloseAccountButton
            // 
            this.AcceptCloseAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptCloseAccountButton.Location = new System.Drawing.Point(41, 86);
            this.AcceptCloseAccountButton.Name = "AcceptCloseAccountButton";
            this.AcceptCloseAccountButton.Size = new System.Drawing.Size(113, 32);
            this.AcceptCloseAccountButton.TabIndex = 4;
            this.AcceptCloseAccountButton.Text = "Принять";
            this.AcceptCloseAccountButton.UseVisualStyleBackColor = true;
            this.AcceptCloseAccountButton.Click += new System.EventHandler(this.AcceptCloseAccountButton_Click);
            // 
            // CancelCloseAccontButton
            // 
            this.CancelCloseAccontButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelCloseAccontButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCloseAccontButton.Location = new System.Drawing.Point(176, 86);
            this.CancelCloseAccontButton.Name = "CancelCloseAccontButton";
            this.CancelCloseAccontButton.Size = new System.Drawing.Size(107, 32);
            this.CancelCloseAccontButton.TabIndex = 3;
            this.CancelCloseAccontButton.Text = "Отмена";
            this.CancelCloseAccontButton.UseVisualStyleBackColor = true;
            // 
            // CloseAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 139);
            this.Controls.Add(this.AcceptCloseAccountButton);
            this.Controls.Add(this.CancelCloseAccontButton);
            this.Controls.Add(this.label1);
            this.Name = "CloseAccountForm";
            this.Text = "Закрыть счет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AcceptCloseAccountButton;
        private System.Windows.Forms.Button CancelCloseAccontButton;
    }
}