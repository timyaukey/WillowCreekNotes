using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WillowCreekNotes
{
    public abstract class NoteSource
    {
        protected NoteSystem _System;
        public string FileType;

        public NoteSource(NoteSystem system)
        {
            _System = system;
        }

        public abstract void SetName(string name);

        public abstract Stream GetStream();

        public bool MatchesFileType(string fileType)
        {
            return fileType.Equals(FileType, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
