using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WewerFamilyTree
{

    class Relations<PERSON, INTEGER>
    {
        PERSON _person;                 //Destination of relation, person b
        int _value;                     //Type of relation:     0 = b is the child of a,    1 = b is the parent of a,   2 = b is the partner of a

        public Relations(PERSON p, int v)
        {
            _person = p;
            _value = v;
        }

        /// <summary>
        /// Getter and setter method for PERSON object (key)
        /// </summary>
        public PERSON Person
        {
            get
            {
                return _person;
            }

            set
            {
                _person = value;
            }
        }

        /// <summary>
        /// Getter and setter method for INTEGER object (value)
        /// </summary>
        public int Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }
    }
}
