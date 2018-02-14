using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WewerFamilyTree
{
    class Person
    {
        protected PInfo _info;
        protected List<Relations<Person, int>> _relations;

        public Person(PInfo info, List<Relations<Person, int>> relations)
        {
            _info = info;
            _relations = relations;
        }

        /// <summary>
        /// Getter and setter method for the PInfo object of Person
        /// </summary>
        protected PInfo Info
        {
            get
            {
                return _info;
            }

            set
            {
                _info = value;
            }
        }

        /// <summary>
        /// Getter and setter method for the Relations list of Person
        /// </summary>
        protected List<Relations<Person, int>> Relations
        {
            get
            {
                return _relations;
            }

            set
            {
                _relations = value;
            }
        }

        /// <summary>
        /// The Equals method for the Person class is defined to be equal if the PInfo objects are equal.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Equals(Person b)
        {
            return this.Info.Equals(b.Info);
        }
    }
}
