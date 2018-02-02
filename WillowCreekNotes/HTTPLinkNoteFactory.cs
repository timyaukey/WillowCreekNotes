using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowCreekNotes
{
    public class HTTPLinkNoteFactory : NoteFactory
    {
        public override bool CreateNote(NoteSystem system, NoteSource source)
        {
            if (source.MatchesFileType(".whlnk"))
            {
                string name = "get name from .whlnk file;";
                HTTPNoteSource linkedSource = new HTTPNoteSource(system);
                linkedSource.SetName(name);
                SetFileTypeFromMIMEType(linkedSource);
                system.CreateNote(linkedSource);
                return true;
            }
            return false;
        }

        private void SetFileTypeFromMIMEType(HTTPNoteSource link)
        {

        }
    }
}
