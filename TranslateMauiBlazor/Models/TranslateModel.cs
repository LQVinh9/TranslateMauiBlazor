using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateMauiBlazor.Models
{
    public class TranslateModel
    {
        public DetectedLanguage DetectedLanguage { get; set; }
        public List<Item> Translations { get; set; }
    }

    public class DetectedLanguage
    {
        public string Language { get; set; }
        public double Score { get; set; }
    }

    public class Item
    {
        public string Text { get; set; }
        public string To { get; set; }
    }
}
