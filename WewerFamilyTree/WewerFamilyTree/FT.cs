using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WewerFamilyTree
{
    class FT<Person>
    {
        private List<Person> _people;
        private Dictionary<Person, List<Person>> _children;
        private int _size;
        
        public FT()
        {
            _people = new List<Person>();
            _children = new Dictionary<Person, List<Person>>();
            _size = 0;
        }

        public int Count
        {
            get
            {
                return _people.Count;
            }
        }

        public List<Person> People
        {
            get
            {
                return _people;
            }
        }

        public List<Person> GetOutgoing(Person n)
        {
            return _children[n];
        }

        public bool ContainsPerson(Person person)
        {
            return _people.Contains(person);
        }

        public void AddPerson(Person a)
        {
            if (ContainsPerson(a))
            {
                MessageBox.Show(a.ToString() + " is already in the database.");
                return;
            }

            _people.Add(a);
            _children.Add(a, new List<Person>());
            _size++;
        }

        public void AddChild(Person cur, Person child, double val)
        {
            //only adds in one direction
            AddPerson(cur);
            AddPerson(child);

            _children[cur].Add(child);
        }
    }
}
