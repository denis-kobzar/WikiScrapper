using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikiScrapper.Model.Base;

namespace WikiScrapper.Model
{
    internal class DocumentModel : BaseModel
    {
        public string FirstHeading { get; set; }
        /*public InfoBox Info { get; set; }*/
        public List<string> Paragraphs { get; set; } 

        /*public List<Link> CatLinks { get; set; }*/
    }
}
