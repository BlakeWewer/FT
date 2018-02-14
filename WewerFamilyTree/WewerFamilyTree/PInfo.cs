using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WewerFamilyTree
{
    class PInfo
    {
        private string _firstName, _middleName, _lastName, _maidenName, _prefix, _suffix;
        private string _birthTown, _birthState, _birthCountry, _sBirthMonth;
        private string _sDeathMonth;
        private string _sSex;   //Male or Female
        private char _cSex;     // M or F
        private int _birthMonth, _birthDay, _birthYear;
        private int _deathMonth, _deathDay, _deathYear;
        private bool _isAlive;
        private bool _isMarried;
        private string _relationship, _sMarriageDateMonth, _marriagePlace;      //Relationship is the Person they are with
        private int _marriageDateMonth, _marriageDateDay, _marriageDateYear;

        /// <summary>
        /// Constructor for the object that will hold the vital information of a Person
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="maidenName"></param>
        /// <param name="prefix"></param>
        /// <param name="suffix"></param>
        /// <param name="birthTown"></param>
        /// <param name="birthState"></param>
        /// <param name="birthCountry"></param>
        /// <param name="birthMonth"></param>
        /// <param name="birthDay"></param>
        /// <param name="birthYear"></param>
        /// <param name="deathMonth"></param>
        /// <param name="deathDay"></param>
        /// <param name="deathYear"></param>
        /// <param name="sex"></param>
        /// <param name="isAlive"></param>
        /// <param name="isMarried"></param>
        /// <param name="relationship"></param>
        /// <param name="marriageDateMonth"></param>
        /// <param name="marriageDateDay"></param>
        /// <param name="marriageDateYear"></param>
        /// <param name="marriagePlace"></param>
        public PInfo(string firstName, string middleName, string lastName, string maidenName, string prefix,
                        string suffix, string birthTown, string birthState, string birthCountry,
                        string birthMonth, string birthDay, string birthYear, string deathMonth, string deathDay,
                        string deathYear, string sex, bool isAlive, bool isMarried, string relationship,
                        string marriageDateMonth, string marriageDateDay, string marriageDateYear,
                        string marriagePlace)
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
            _sBirthMonth = birthMonth;                                              //To implement later
            _birthMonth = Convert.ToInt32(birthMonth);                              //To implement later
            _birthDay = Convert.ToInt32(birthDay);
            _birthYear = Convert.ToInt32(birthYear);
            _sDeathMonth = deathMonth;
            _deathMonth = Convert.ToInt32(deathMonth);                              //To implement later
            _deathDay = Convert.ToInt32(deathDay);
            _deathYear = Convert.ToInt32(deathYear);
            _sSex = sex;
            _cSex = sex[0];
            _isAlive = isAlive;
            _isMarried = isMarried;
            _relationship = relationship;
            _sMarriageDateMonth = marriageDateMonth;
            _marriagePlace = marriagePlace;
            _marriageDateMonth = Convert.ToInt32(marriageDateMonth);                //To implement later
            _marriageDateDay = Convert.ToInt32(marriageDateDay);
            _marriageDateYear = Convert.ToInt32(marriageDateYear);
        }


        /// <summary>
        /// Getter and Setter method for the first name as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the middle name as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the last name as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the maiden name as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the prefix as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the suffix as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the town of birth as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the state of birth as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the country of birth as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the month of birth as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the month of death as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the character representation of sex of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the isAlive boolean value of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the isMarried boolean of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the name of the person they are in a relationship with of the PInfo object                          
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the month of marriage date as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the marriage place as a string of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the month of birthday as an integer of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the day of birthday as an integer of the PInfo object
        /// </summary>
        public int IntBirthDay
        {
            get
            {
                return _birthDay;
            }
            set
            {
                _birthDay = value;
            }
        }

        /// <summary>
        /// Getter and Setter method for the year of birthday as an integer of the PInfo object
        /// </summary>
        public int IntBirthYear
        {
            get
            {
                return _birthYear;
            }
            set
            {
                _birthYear = value;
            }
        }

        /// <summary>
        /// Getter and Setter method for the month of marriage date as an integer of the PInfo object
        /// </summary>
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

        /// <summary>
        /// Getter and Setter method for the day of marriage date as an integer of the PInfo object
        /// </summary>
        public int IntMarriageDateDay
        {
            get
            {
                return _marriageDateDay;
            }
            set
            {
                _marriageDateDay = value;
            }
        }

        /// <summary>
        /// Getter and Setter method for the year of marriage date as an integer of the PInfo object
        /// </summary>
        public int IntMarriageDateYear
        {
            get
            {
                return _marriageDateYear;
            }
            set
            {
                _marriageDateYear = value;
            }
        }

        /// <summary>
        /// The PInfo class is defined to be equal if, for all sections where both names are defined (minimum two), none are not equal
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Equals(PInfo b)
        {
            int i = 0;
            if(Prefix != null && b.Prefix != null)
            {
                if (!Prefix.Equals(b.Prefix)) return false;
                i++;
            }
            if (FirstName != null && b.FirstName != null)
            {
                if (!FirstName.Equals(b.FirstName)) return false;
                i++;
            }
            if (MiddleName != null && b.MiddleName != null)
            {
                if (!MiddleName.Equals(b.MiddleName)) return false;
                i++;
            }
            if (LastName != null && b.LastName != null)
            {
                if (!LastName.Equals(b.LastName)) return false;
                i++;
            }
            if (Suffix != null && b.Suffix != null)
            {
                if (!Suffix.Equals(b.Suffix)) return false;
                i++;
            }
            if (i < 2) return false;

            return true;
        }
    }
}
