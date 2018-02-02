using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowCreekNotes
{
    public class HTTPNoteSource : NoteSource
    {
        public HTTPNoteSource(NoteSystem system)
            : base(system)
        {
        }

        public override Stream GetStream()
        {
            throw new NotImplementedException();
        }

        public override void SetName(string name)
        {
            SetFileTypeFromMIMEType();
            throw new NotImplementedException();
        }

        private void SetFileTypeFromMIMEType()
        {

        }
    }
}
