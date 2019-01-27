namespace AsyncInLegacyUI
{
    partial class FromUiBlocked
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
            this.btnGet = new System.Windows.Forms.Button();
            this.txtboxResponse = new System.Windows.Forms.TextBox();
            this.btnCleanResponse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(28, 29);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "HTTP GET Google";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtboxResponse
            // 
            this.txtboxResponse.Location = new System.Drawing.Point(28, 76);
            this.txtboxResponse.Multiline = true;
            this.txtboxResponse.Name = "txtboxResponse";
            this.txtboxResponse.Size = new System.Drawing.Size(742, 336);
            this.txtboxResponse.TabIndex = 1;
            // 
            // btnCleanResponse
            // 
            this.btnCleanResponse.Location = new System.Drawing.Point(143, 29);
            this.btnCleanResponse.Name = "btnCleanResponse";
            this.btnCleanResponse.Size = new System.Drawing.Size(106, 23);
            this.btnCleanResponse.TabIndex = 0;
            this.btnCleanResponse.Text = "Clear Response";
            this.btnCleanResponse.UseVisualStyleBackColor = true;
            this.btnCleanResponse.Click += new System.EventHandler(this.btnClearResponse_Click);
            // 
            // FromUIBlocked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxResponse);
            this.Controls.Add(this.btnCleanResponse);
            this.Controls.Add(this.btnGet);
            this.Name = "FromUiBlocked";
            this.Text = "FromUIBlocked";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtboxResponse;
        private System.Windows.Forms.Button btnCleanResponse;
    }
}

