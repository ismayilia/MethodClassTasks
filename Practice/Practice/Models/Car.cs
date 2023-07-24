using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models
{
    internal class Car
    {
        public string Name { get;private set; }

        protected string color;

        private int _speed;

        public int Speed { 
            get
            {
                if (_speed>300)
                {
                    return _speed;
                }

                return -1;
            } set 
            {
                _speed= value;
            }
        }
    }
}
