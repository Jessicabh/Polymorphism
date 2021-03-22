using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // Nedeed for MessageBox

namespace Polymorphism
{
    class Cat : Animal
    {
        // Field
        private String _name;

        // Constructor
        public Cat (string name)
            : base("Cat")
        {
            _name = name;
        }

        //Name property
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //MakeSound Method
        public override void MakeSound()
        {
            MessageBox.Show("Meow");
        }
    }
}
