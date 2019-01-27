namespace AsyncInLegacyUI
{
    partial class FormNonBlockingWithTaskCompletionSourceWithinLegacy
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
            this.btnHttpGet = new System.Windows.Forms.Button();
            this.textboxResponse = new System.Windows.Forms.TextBox();
            this.btnClearText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHttpGet
            // 
            this.btnHttpGet.Location = new System.Drawing.Point(40, 13);
            this.btnHttpGet.Name = "btnHttpGet";
            this.btnHttpGet.Size = new System.Drawing.Size(75, 23);
            this.btnHttpGet.TabIndex = 0;
            this.btnHttpGet.Text = "HTTP GET";
            this.btnHttpGet.UseVisualStyleBackColor = true;
            this.btnHttpGet.Click += new System.EventHandler(this.btnHttpGet_Click);
            // 
            // textboxResponse
            // 
            this.textboxResponse.Location = new System.Drawing.Point(40, 55);
            this.textboxResponse.Multiline = true;
            this.textboxResponse.Name = "textboxResponse";
            this.textboxResponse.Size = new System.Drawing.Size(714, 367);
            this.textboxResponse.TabIndex = 1;
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(140, 13);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(75, 23);
            this.btnClearText.TabIndex = 0;
            this.btnClearText.Text = "Clear Response";
            this.btnClearText.UseVisualStyleBackColor = true;
            // 
            // FormNonBlockingWithTaskCompletionSourceWithinLegacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxResponse);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.btnHttpGet);
            this.Name = "FormNonBlockingWithTaskCompletionSourceWithinLegacy";
            this.Text = "FormNonBlockingWithTaskCompletionSourceWithinLegacy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHttpGet;
        private System.Windows.Forms.TextBox textboxResponse;
        private System.Windows.Forms.Button btnClearText;
    }
}