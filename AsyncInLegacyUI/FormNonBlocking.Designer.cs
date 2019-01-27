namespace AsyncInLegacyUI
{
    partial class FormNonBlockingWithTaskCompletionSourceUsingAsync
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
            this.btnGetResponse = new System.Windows.Forms.Button();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetResponse
            // 
            this.btnGetResponse.Location = new System.Drawing.Point(32, 28);
            this.btnGetResponse.Name = "btnGetResponse";
            this.btnGetResponse.Size = new System.Drawing.Size(75, 23);
            this.btnGetResponse.TabIndex = 0;
            this.btnGetResponse.Text = "button1";
            this.btnGetResponse.UseVisualStyleBackColor = true;
            this.btnGetResponse.Click += new System.EventHandler(this.btnGetResponse_Click);
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(32, 71);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(737, 352);
            this.textBoxResponse.TabIndex = 1;
            // 
            // FormNonBlockingWithTaskCompletionSourceUsingAsync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.btnGetResponse);
            this.Name = "FormNonBlockingWithTaskCompletionSourceUsingAsync";
            this.Text = "FormNonBlockingWithTaskCompletionSourceUsingAsync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetResponse;
        private System.Windows.Forms.TextBox textBoxResponse;
    }
}