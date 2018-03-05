namespace WillowCreekNotes
{
    partial class StackWindow
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
            this.pnlDocumentFrame = new System.Windows.Forms.Panel();
            this.ctlToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ctlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDocumentFrame
            // 
            this.pnlDocumentFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDocumentFrame.Location = new System.Drawing.Point(0, 28);
            this.pnlDocumentFrame.Name = "pnlDocumentFrame";
            this.pnlDocumentFrame.Size = new System.Drawing.Size(413, 249);
            this.pnlDocumentFrame.TabIndex = 0;
            // 
            // ctlToolbar
            // 
            this.ctlToolbar.GripMargin = new System.Windows.Forms.Padding(0);
            this.ctlToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.ctlToolbar.Location = new System.Drawing.Point(0, 0);
            this.ctlToolbar.Name = "ctlToolbar";
            this.ctlToolbar.Size = new System.Drawing.Size(413, 25);
            this.ctlToolbar.TabIndex = 1;
            this.ctlToolbar.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WillowCreekNotes.Properties.Resources.PopNoteOut;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // StackWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 276);
            this.Controls.Add(this.ctlToolbar);
            this.Controls.Add(this.pnlDocumentFrame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StackWindow";
            this.ShowInTaskbar = false;
            this.Text = "StackWindow";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoteWindow_FormClosing);
            this.ctlToolbar.ResumeLayout(false);
            this.ctlToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlDocumentFrame;
        private System.Windows.Forms.ToolStrip ctlToolbar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}