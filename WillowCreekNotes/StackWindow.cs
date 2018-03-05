using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WillowCreekNotes
{
    public partial class StackWindow : Form
    {
        public readonly List<NotePanel> NotePanels;

        public StackWindow()
        {
            NotePanels = new List<NotePanel>();
            InitializeComponent();
            ctlToolbar.SuspendLayout();
            this.SuspendLayout();
            AddToolbarButton(GetResourceImage("PopNoteOut"), "PopNoteOut", btnPopNoteOut_Click);
            ctlToolbar.ResumeLayout(false);
            ctlToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public void AddToolbarButton(System.Drawing.Image image, string name, EventHandler handler)
        {
            ToolStripButton button = new ToolStripButton();
            button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button.Image = image;
            button.ImageTransparentColor = System.Drawing.Color.Magenta;
            button.Name = name;
            button.Size = new System.Drawing.Size(23, 22);
            button.Text = name;
            button.Click += new System.EventHandler(handler);
            ctlToolbar.Items.Add(button);
        }

        private void btnPopNoteOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pop note out.");
        }

        public System.Drawing.Image GetResourceImage(string imageName)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StackWindow));
            return ((System.Drawing.Image)(resources.GetObject(imageName)));
        }

        public void AddPanel(NotePanel panel)
        {
            NotePanels.Add(panel);
        }

        public void ShowPanel(NotePanel panel)
        {
            this.SuspendLayout();
            pnlDocumentFrame.Controls.Clear();
            //panel.Location = new System.Drawing.Point(10, 10);
            //panel.Size = new System.Drawing.Size(300, 300);
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Name = "ContentPanel";
            panel.TabIndex = 0;
            //panel.Visible = true;
            this.pnlDocumentFrame.Controls.Add(panel);
            this.ResumeLayout(false);
        }

        public void ShowWindow()
        {
            this.Show();
            this.Refresh();
        }

        private void NoteWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void toolUpArrow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click up arrow");
        }
    }
}
