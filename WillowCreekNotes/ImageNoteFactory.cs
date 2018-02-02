using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowCreekNotes
{
    public class ImageNoteFactory : NoteFactory
    {
        public override bool CreateNote(NoteSystem system, NoteSource source)
        {
            if (source.MatchesFileType(".jpg"))
            {
                NotePanel panel = new ImageNotePanel();
                system.AddNotePanel(panel);
                return true;
            }
            if (source.MatchesFileType(".png"))
            {
                NotePanel panel = new ImageNotePanel();
                system.AddNotePanel(panel);
                return true;
            }
            if (source.MatchesFileType(".gif"))
            {
                NotePanel panel = new ImageNotePanel();
                system.AddNotePanel(panel);
                return true;
            }
            return false;
        }
    }
}
