using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShinyHuntHelper
{
    class clsPokemon
    {
        private int _key;
        private int _number;
        private string _name;
        private string _local;
        private string _gameVersion;
        private int _ReSr; //Random Encounter / Soft Resets
        private int _phase;
        private DateTime _data;
        private string _link;
        private int _nextPhase;

        #region GetSet
        public int Number
        {
            get
            {
                return _number;
            }

            set
            {
                _number = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Local
        {
            get
            {
                return _local;
            }

            set
            {
                _local = value;
            }
        }

        public string GameVersion
        {
            get
            {
                return _gameVersion;
            }

            set
            {
                _gameVersion = value;
            }
        }

        public int ReSr
        {
            get
            {
                return _ReSr;
            }

            set
            {
                _ReSr = value;
            }
        }

        public int Phase
        {
            get
            {
                return _phase;
            }

            set
            {
                _phase = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }

        public string Link
        {
            get
            {
                return _link;
            }

            set
            {
                _link = value;
            }
        }

        internal int NextPhase
        {
            get
            {
                return _nextPhase;
            }

            set
            {
                _nextPhase = value;
            }
        } 
        #endregion

        internal clsPokemon(int key)
        {
            _key = key;
        }
        internal clsPokemon(int key, int number, string name)
        {
            _key = key;
            _number = number;
            _name = name;
            _data = DateTime.Now;
        }
        internal clsPokemon(int key, int number, string name, string local, int ReSr, int Phase)
        {
            _key = key;
            _number = number;
            _name = name;
            _data = DateTime.Now;
            _local = local;
            _ReSr = ReSr;
            _phase = Phase;
        }
        internal clsPokemon(int key, int number, string name, string local, int ReSr, int Phase, int nextPhase)
        {
            _key = key;
            _number = number;
            _name = name;
            _data = DateTime.Now;
            _local = local;
            _ReSr = ReSr;
            _phase = Phase;
            _nextPhase = nextPhase;
        }
    }
}
