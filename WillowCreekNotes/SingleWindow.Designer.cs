namespace WillowCreekNotes
{
    partial class SingleWindow
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
            this.ctlToolbar = new System.Windows.Forms.ToolStrip();
            this.pnlDocumentFrame = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ctlToolbar
            // 
            this.ctlToolbar.Location = new System.Drawing.Point(0, 0);
            this.ctlToolbar.Name = "ctlToolbar";
            this.ctlToolbar.Size = new System.Drawing.Size(323, 25);
            this.ctlToolbar.TabIndex = 0;
            this.ctlToolbar.Text = "toolStrip1";
            // 
            // pnlDocumentFrame
            // 
            this.pnlDocumentFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDocumentFrame.Location = new System.Drawing.Point(0, 28);
            this.pnlDocumentFrame.Name = "pnlDocumentFrame";
            this.pnlDocumentFrame.Size = new System.Drawing.Size(323, 327);
            this.pnlDocumentFrame.TabIndex = 1;
            // 
            // SingleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 354);
            this.Controls.Add(this.pnlDocumentFrame);
            this.Controls.Add(this.ctlToolbar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SingleWindow";
            this.ShowInTaskbar = false;
            this.Text = "SingleWindow";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ctlToolbar;
        public System.Windows.Forms.Panel pnlDocumentFrame;
    }
}