using System;
using System.Collections.Generic;
using System.Text;

namespace NoteAppConsole
{
    public class note
    {
        public note(int id0 , string text0,string title0,string tag0,DateTime dateCreated0)
        {
            id = id0;
            text = text0;
            title = title0;
            tag = tag0;
            dateCreated = dateCreated0;
        }

       
        private int id { get; }
        private string text { get; set; }
        private string title { get; set; }
        private string tag { get; set; }
        private DateTime dateCreated { get; }



    }
}
