using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsInterface_02._08._20
{
    class SuperMan : Human,IFly
    {
        int __speed;

        public SuperMan(string name, int age,int speed) : base( age)
        {
            SetName(name);
            SetSpeed(speed);

        }

        private string _name;
        
        public override string GetName()
        {
            return _name;
        }

       protected override void SetName (string name)
        {
            _name = name;
        }

        public int GetSpeed()
        {
            return __speed;
        }

        protected void SetSpeed(int speed)
        {
           __speed = speed;
        }
        public void Fly()
        {
            Console.WriteLine($"Superman is fly by webleft {GetSpeed()}");
        }

        public void ActivateSuperPowers()
        {
            Fly();
        }
    }
}
