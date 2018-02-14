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
        private int _size;
        protected string _curFile;
        
        // Methods Needed:
        // Load Tree - Way for FT to read information from a chosen txt file (return bool - true if read, false if it doesn't exist) //Ticker501->Account.cs->readTransactionHistory is a good example
        // Save Tree - Way for FT to write information to the current txt file
        // New Tree - Write existing tree to a different file and clear main file
        // Add people to list 
        // Search for and return people
        // Draw Tree
        // Update Person already in graph


        public FT()
        {
            _people = new List<Person>();
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
       
        public bool ContainsPerson(Person person)
        {
            return _people.Contains(person);
        }

        public bool LoadTree(string path)
        {
            
        }

        public void SaveTree()
        {

        }

    }
}
