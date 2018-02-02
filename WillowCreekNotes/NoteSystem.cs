using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowCreekNotes
{
    public class NoteSystem
    {
        public readonly List<NoteFactory> NoteFactories;

        public NoteSystem()
        {
            NoteFactories = new List<NoteFactory>();
        }

        public void Startup()
        {
            LoadFactories();
            CreateNotes();
        }

        public void CreateNotes()
        {
            foreach (NoteSource source in GetLocalFiles())
            {
                CreateNote(source);
            }
        }

        public void CreateNote(NoteSource source)
        {
            foreach (NoteFactory factory in NoteFactories)
            {
                if (factory.CreateNote(this, source))
                    break;
            }
        }

        private void LoadFactories()
        {
            NoteFactories.Add(new TextNoteFactory());
            NoteFactories.Add(new ImageNoteFactory());
        }

        private IEnumerable<NoteSource> GetLocalFiles()
        {
            List<NoteSource> sources = new List<NoteSource>();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(NoteDataFolder);
            foreach(System.IO.FileInfo file in dir.EnumerateFiles())
            {
                NoteSource source = new FileNoteSource(this);
                source.SetName(file.Name);
                source.FileType = file.Extension;
                sources.Add(source);
            }
            return sources;
        }

        public void AddNotePanel(NotePanel panel)
        {
            NoteWindow win = new NoteWindow();
            win.SuspendLayout();
            //panel.Location = new System.Drawing.Point(10, 10);
            //panel.Size = new System.Drawing.Size(300, 300);
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Name = "ContentPanel";
            panel.TabIndex = 0;
            //panel.Visible = true;
            win.Controls.Add(panel);
            win.ResumeLayout(false);
            win.Show();
            win.Refresh();
        }

        public string NoteDataFolder
        {
            get
            {
                return "c:\\dropbox\\WillowNotes";
            }
        }
    }
}
