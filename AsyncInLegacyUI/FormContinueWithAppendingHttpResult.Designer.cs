namespace AsyncInLegacyUI
{
    partial class FormContinueWithAppendingHttpResult
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
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHttpGet
            // 
            this.btnHttpGet.Location = new System.Drawing.Point(27, 13);
            this.btnHttpGet.Name = "btnHttpGet";
            this.btnHttpGet.Size = new System.Drawing.Size(75, 23);
            this.btnHttpGet.TabIndex = 0;
            this.btnHttpGet.Text = "HTTP GET";
            this.btnHttpGet.UseVisualStyleBackColor = true;
            this.btnHttpGet.Click += new System.EventHandler(this.btnHttpGet_Click);
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(27, 52);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(732, 371);
            this.textBoxResponse.TabIndex = 1;
            // 
            // FormContinueWithAppendingHttpResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.btnHttpGet);
            this.Name = "FormContinueWithAppendingHttpResult";
            this.Text = "FormContinueWithAppendingHttpResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHttpGet;
        private System.Windows.Forms.TextBox textBoxResponse;
    }
}