using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Category
    {
        private int id;
        private string name;
        private string description;
        private string colour;
        private string icon;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Colour { get => colour; set => colour = value; }
        public string Icon { get => icon; set => icon = value; }
        public int Id { get => id; set => id = value; }

    }
}
