using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versie1
{
    class Business
    {
        //instantie van persistence
        private Persistence _persistence;

        private List<Aankoop> _aankoop;
        public List<Aankoop> aankoop
        {
            get { return _aankoop; }
            set { _aankoop = value; }
        }

        //constructor
        public Business()
        {
            _persistence = new Persistence();
            //lijst opvullen met data
            _aankoop = _persistence.getAankoopFromDB();
        }

        public List<string> getAankopen()
        {
            List<string> result = new List<string>();
            foreach (Aankoop item in _aankoop)
            {
                result.Add(item.ToString());
            }
            return result;
        }


    }
}
