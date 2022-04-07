using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTask
{
    class ProgLanguage
    {
        public string Language;
        public DateTime Date;
        public ProgLanguage(string language, DateTime date)
        {
            Language = language;
            Date = date;
        }

        internal object CompareTo(object length)
        {
            throw new NotImplementedException();
        }
    }
}
