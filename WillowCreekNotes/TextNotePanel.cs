using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowCreekNotes
{
    public class TextNotePanel : NotePanel
    {
        public System.Windows.Forms.TextBox txtContent;

        public TextNotePanel()
            : base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(0, 0);
            this.txtContent.MaxLength = 10000000;
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(200, 100);
            this.txtContent.TabIndex = 0;
            // 
            // TextNotePanel
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(300, 400);
            this.ResumeLayout(false);

        }
    }
}
