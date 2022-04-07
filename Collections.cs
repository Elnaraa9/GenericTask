using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTask
{
    class Collections<T> where T : ProgLanguage
    {
        public T[] language;
        public Collections()
        {
            language = new T[0];
        }
        public void Add(T languages)
        {
            Array.Resize(ref language, language.Length + 1);
            language[language.Length - 1] = languages;
        }
        public void SortDate()
        {
            DateTime temp = new DateTime();
            for (int i = 0; i < language.Length; i++)
            {
                for (int j = i + 1; j < language.Length; j++)
                {
                    if (language[i].Date > language[j].Date)
                    {
                        temp = language[i].Date;
                        language[i].Date = language[j].Date;
                        language[j].Date = temp;

                    }
                }
            }
        }
        public void SortLang()
        {
            for (int i = 0; i < language.Length; i++)
            {
                for (int j = 0; j < language.Length; j++)
                {
                    Array.Sort(language, (i, j) => i.Language.CompareTo(j.Language));
                }
            }
        }

        private object CompareTo(object length)
        {
            throw new NotImplementedException();
        }
        //public int Compare(DateTime x, DateTime y)
        //{
        //    int compareDate = x.Date.CompareTo(y.Date);
        //    if (compareDate == 0)
        //    {
        //        return x.Date.CompareTo(y.Date);
        //    }
        //    return compareDate;
        //}
    }
}
