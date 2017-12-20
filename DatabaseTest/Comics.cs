using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest
{
    class Comics
    {
        private int _idComic;
        private string _urlComic;
        private string _title;
        private string _description;

        public int IdComic
        {
            get { return _idComic; }
            set { _idComic = value; }
        }

        public string UrlComic
        {
            get { return _urlComic; }
            set { _urlComic = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Comics()
        {
        }

        public Comics(int idComic, string urlComic, string name, string description)
        {
            IdComic = idComic;
            UrlComic = urlComic;
            Title = name;
            Description = description;

        }

        public override string ToString()
        {
            return $"{IdComic}, {UrlComic}, {Title}, {Description}";
        }
    }
}
