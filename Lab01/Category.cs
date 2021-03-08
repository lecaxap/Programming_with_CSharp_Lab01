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

        public Category(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; }
    }
}
