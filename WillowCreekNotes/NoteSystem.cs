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
        public readonly List<StackWindow> StackWindows;

        public NoteSystem()
        {
            NoteFactories = new List<NoteFactory>();
            StackWindows = new List<StackWindow>();
        }

        public void Startup()
        {
            LoadFactories();
            CreateNotes();
            ShowStacks();
        }

        public void CreateNotes()
        {
            foreach (NoteSource source in GetLocalFiles())
            {
                CreateNote(source);
            }
        }

        public void ShowStacks()
        { 
            foreach(StackWindow win in StackWindows)
            {
                win.ShowPanel(win.NotePanels[0]);
                win.ShowWindow();
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
            StackWindow win = GetStackWindow(panel);
            win.AddPanel(panel);
        }

        private StackWindow GetStackWindow(NotePanel panel)
        {
            if (StackWindows.Count == 0)
                StackWindows.Add(new StackWindow());
            return StackWindows[0];
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
