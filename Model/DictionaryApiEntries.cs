using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Model
{
    internal class DictionaryApiEntries
    {
        public string phonetic { get; set; }

        public List<Phonetic> phonetics { get; set; }

        public List<Mean> meanings { get; set; }


    }
}
