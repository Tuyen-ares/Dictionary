using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Model
{
    internal class Mean
    {
        public string partOfSpeech { get; set; }
        public List<Define> definitions { get; set; }

        public List<string> synonyms { get; set; }    

        public List<string> antonyms { get; set; }    
    }
}
