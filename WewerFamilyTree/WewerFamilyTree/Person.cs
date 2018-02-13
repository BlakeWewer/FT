using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WewerFamilyTree
{
    class Person
    {
        private string _firstName, _middleName, _lastName, _maidenName, _prefix, _suffix;
        private string _birthTown, _birthState, _birthCountry, _sBirthMonth, _sBirthDay, _sBirthYear;
        private string _sDeathMonth, _sDeathDay, _sDeathYear;
        private string _sSex;
        private char _cSex;
        private int _birthMonth, _birthDay, _birthYear;
        private int _deathMonth, _deathDay, _deathYear;
        private bool _isAlive;
        private bool _isMarried;
        private string _relationship, _sMarriageDateMonth, _sMarriageDateDay, _sMarriageDateYear, _marriagePlace;
        private int _marriageDateMonth, _marriageDateDay, _marriageDateYear;
        private Person[] _parents = new Person[2];
        private List<Person> _spouses = new List<Person>();
        private List<Person> _children = new List<Person>();

        public Person(string firstName, string middleName, string lastName, string maidenName, string prefix,
                        string suffix, string birthTown, string birthState, string birthCountry, 
                        string birthMonth, string birthDay, string birthYear, string deathMonth, string deathDay,
                        string deathYear, string sex, bool isAlive, bool isMarried, string relationship, 
                        string marriageDateMonth, string marriageDateDay, string marriageDateYear, 
                        string marriagePlace, Person[] parents, List<Person> spouses, 
                        List<Person> children)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _maidenName = maidenName;
            _prefix = prefix;
            _suffix = suffix;
            _birthTown = birthTown;
            _birthState = birthState;
            _birthCountry = birthCountry;
            _sBirthMonth = birthMonth;
            _sBirthDay = birthDay;
            _sBirthYear = birthYear;
            _birthMonth = 0;                            //To implement later
            _birthDay = Convert.ToInt32(_sBirthDay);
            _birthYear = Convert.ToInt32(_sBirthYear);
            _sDeathMonth = deathMonth;
            _sDeathDay = deathDay;
            _sDeathYear = deathYear;
            _deathMonth = 0;                            //To implement later
            _deathDay = Convert.ToInt32(_sDeathDay);
            _deathYear = Convert.ToInt32(_sDeathYear);
            _sSex = sex;
            _cSex = sex[0];
            _isAlive = isAlive;
            _isMarried = isMarried;
            _relationship = relationship;
            _sMarriageDateMonth = marriageDateMonth;
            _sMarriageDateDay = marriageDateDay;
            _sMarriageDateYear = marriageDateYear;
            _marriagePlace = marriagePlace;
            _marriageDateMonth = 0;                     //To implement later
            _marriageDateDay = Convert.ToInt32(_sMarriageDateDay);
            _marriageDateYear = Convert.ToInt32(_sMarriageDateYear);
            _parents = parents;
            _spouses = spouses;
            _children = children;
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                _middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string MaidenName
        {
            get
            {
                return _maidenName;
            }
            set
            {
                _maidenName = value;
            }
        }

        public string Prefix
        {
            get
            {
                return _prefix;
            }
            set
            {
                _prefix = value;
            }
        }

        public string Suffix
        {
            get
            {
                return _suffix;
            }
            set
            {
                _suffix = value;
            }
        }

        public string BirthTown
        {
            get
            {
                return _birthTown;
            }
            set
            {
                _birthTown = value;
            }
        }

        public string BirthState
        {
            get
            {
                return _birthState;
            }
            set
            {
                _birthState = value;
            }
        }

        public string BirthCountry
        {
            get
            {
                return _birthCountry;
            }
            set
            {
                _birthCountry = value;
            }
        }

        public string BirthMonth
        {
            get
            {
                return _sBirthMonth;
            }
            set
            {
                _sBirthMonth = value;
                _birthMonth = 0;                //To implement later
            }
        }

        public string BirthDay
        {
            get
            {
                return _sBirthDay;
            }
            set
            {
                _sBirthDay = value;
                _birthDay = Convert.ToInt32(value);
            }
        }

        public string BirthYear
        {
            get
            {
                return _sBirthYear;
            }
            set
            {
                _sBirthYear = value;
                _birthYear = Convert.ToInt32(value);
            }
        }

        public string DeathMonth
        {
            get
            {
                return _sDeathMonth;
            }
            set
            {
                _sDeathMonth = value;
                _deathMonth = 0;                //To implement later
            }
        }

        public string DeathDay
        {
            get
            {
                return _sDeathDay;
            }
            set
            {
                _sDeathDay = value;
                _deathDay = Convert.ToInt32(value);
            }
        }

        public string DeathYear
        {
            get
            {
                return _sDeathYear;
            }
            set
            {
                _sDeathYear = value;
                _deathYear = Convert.ToInt32(value);
            }
        }

        public string Sex
        {
            get
            {
                return _sSex;
            }
            set
            {
                _sSex = value;
                _cSex = value[0];
            }
        }

        public bool IsAlive
        {
            get
            {
                return _isAlive;
            }
            set
            {
                _isAlive = value;
            }
        }

        public bool IsMarried
        {
            get
            {
                return _isMarried;
            }
            set
            {
                _isMarried = value;
            }
        }

        public string Relationship
        {
            get
            {
                return _relationship;
            }
            set
            {
                _relationship = value;
            }
        }

        public string MarriageDateDay
        {
            get
            {
                return _sMarriageDateDay;
            }
            set
            {
                 _sMarriageDateDay= value;
                _marriageDateDay = Convert.ToInt32(value);
            }
        }

        public string MarriageDateMonth
        {
            get
            {
                return _sMarriageDateMonth;
            }
            set
            {
                _sMarriageDateMonth = value;
            }
        }

        public string MarriageDateYear
        {
            get
            {
                return _sMarriageDateYear;
            }
            set
            {
                _sMarriageDateYear = value;
                _marriageDateYear = Convert.ToInt32(value);
            }
        }

        public string MarriagePlace
        {
            get
            {
                return _marriagePlace;
            }
            set
            {
                _marriagePlace = value;
            }
        }

        public int IntBirthMonth
        {
            get
            {
                return _birthMonth;
            }
            set
            {
                _birthMonth = value;
                _sBirthMonth = "";              //To implement later
            }
        }

        public int IntBirthDay
        {
            get
            {
                return _birthDay;
            }
            set
            {
                _birthDay = value;
                _sBirthDay = value.ToString();
            }
        }

        public int IntBirthYear
        {
            get
            {
                return _birthYear;
            }
            set
            {
                _birthYear = value;
                _sBirthYear = value.ToString();
            }
        }

        public int IntMarriageDateMonth
        {
            get
            {
                return _marriageDateMonth;
            }
            set
            {
                _marriageDateMonth = value;
                _sMarriageDateMonth = "";               //To implement later
            }
        }

        public int IntMarriageDateDay
        {
            get
            {
                return _marriageDateDay;
            }
            set
            {
                _marriageDateDay = value;
                _sMarriageDateDay = value.ToString();
            }
        }

        public int IntMarriageDateYear
        {
            get
            {
                return _marriageDateYear;
            }
            set
            {
                _marriageDateYear = value;
                _sMarriageDateYear = value.ToString();
            }
        }

        public Person[] Parents
        {
            get
            {
                return _parents;
            }
            set
            {
                _parents = value;
            }
        }

        public List<Person> Spouses
        {
            get
            {
                return _spouses;
            }
            set
            {
                _spouses = value;
            }
        }

        public List<Person> Children
        {
            get
            {
                return _children;
            }
            set
            {
                _children = value;
            }
        }
    }
}
