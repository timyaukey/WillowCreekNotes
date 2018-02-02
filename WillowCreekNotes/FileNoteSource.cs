using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowCreekNotes
{
    public class FileNoteSource : NoteSource
    {
        private string _FileName;
        private Stream _FileStream;

        public FileNoteSource(NoteSystem system)
            : base(system)
        {
        }

        public override Stream GetStream()
        {
            if (_FileStream == null)
            {
                string fullPath = Path.Combine(_System.NoteDataFolder, _FileName);
                _FileStream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
            }
            return _FileStream;
        }

        public override void SetName(string name)
        {
            _FileName = name;
        }
    }
}
