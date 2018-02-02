using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowCreekNotes
{
    public class FileLinkNoteFactory : NoteFactory
    {
        public override bool CreateNote(NoteSystem system, NoteSource source)
        {
            if (source.MatchesFileType(".wflnk"))
            {
                string name = "get name from .wflnk file;";
                FileNoteSource linkedSource = new FileNoteSource(system);
                linkedSource.SetName(name);
                List<NoteSource> linkedSources = new List<NoteSource>() { linkedSource };
                system.CreateNotes();
                return true;
            }
            return false;
        }
    }
}
