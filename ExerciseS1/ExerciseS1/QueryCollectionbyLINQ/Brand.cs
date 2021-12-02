using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseS1.QueryCollectionbyLINQ
{
    class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Brand(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
