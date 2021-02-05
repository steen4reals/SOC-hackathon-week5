using System;

namespace BackEnd
{
    public class Journal
    {

        public long? Id { get; set; }
        public DateTime DateOfEntry { get; set; }

        public string JournalEntry { get; set; }

    }
}
