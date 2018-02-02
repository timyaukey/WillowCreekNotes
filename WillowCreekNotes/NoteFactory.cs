using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowCreekNotes
{
    public abstract class NoteFactory
    {
        public abstract bool CreateNote(NoteSystem system, NoteSource source);
    }
}
