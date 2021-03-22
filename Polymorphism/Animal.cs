using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // Needed for MessageBox

namespace Polymorphism
{
    class Animal
    {
        //Field
        private string _species;
        //Contructor 
        public Animal(string species)
        {
            _species = species;
        }

        //Species porperty
        public String Species
        {
            get { return _species; }
            set { _species = value; }
        }

        //MakeSound Method
        public virtual void MakeSound()
        {
            MessageBox.Show("Grrrrrrrr");
        }
    }
}
