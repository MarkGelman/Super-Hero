using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsInterface_02._08._20
{
    abstract class Human
    {
      
        private int _age;

        public Human (int age)
        {
           
            _age = age;
        }

        public abstract string GetName();


        protected abstract void SetName(string name);
      


        public int Age
        {
            get
            {
                return _age;
            }
        }
    }
}
