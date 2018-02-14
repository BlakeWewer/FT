using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WewerFamilyTree
{
    public partial class Form1 : Form
    {
        FT<Person> tree = new FT<Person>();
        string path = System.IO.Directory.GetCurrentDirectory().ToString();

        public Form1()
        {
            InitializeComponent();
        }

        private void newFamilyTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Write current tree to a different file name (Save to different filename)
            // Let user determine new file name
            // Set tree to a new instance of FT<Person>
            tree = new FT<Person>();
        }

        private void sAVETREEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Write current tree to current file - LT<Person>
        }

        private void uxLoadTreeMenuStripButton_Click(object sender, EventArgs e)
        {
            // Allow the user to select the location of the tree to load and the specific file to load.
            // Call LT<Person> to read in and load the given file
        }

        private void uxAddButton_Click(object sender, EventArgs e)
        {
            // Read all the information given in the Form and create new PInfo and Relation objects.
                // Store all personal info in PInfo object
                // If any Person objects have been selected in the dropdown menus of 
        }
    }
}
