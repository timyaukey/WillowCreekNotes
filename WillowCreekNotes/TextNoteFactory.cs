using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowCreekNotes
{
    public class TextNoteFactory : NoteFactory
    {
        public override bool CreateNote(NoteSystem system, NoteSource source)
        {
            if (source.MatchesFileType(".txt"))
            {
                TextNotePanel panel = new TextNotePanel();
                panel.SuspendLayout();
                //panel.txtContent.Location = new System.Drawing.Point(20, 20);
                //panel.txtContent.Visible = true;
                panel.Controls.Add(panel.txtContent);
                panel.ResumeLayout(false);
                using (System.IO.TextReader reader = new System.IO.StreamReader(source.GetStream()))
                {
                    panel.txtContent.Text = reader.ReadToEnd();
                    system.AddNotePanel(panel);
                }
                return true;
            }
            return false;
        }
    }
}
