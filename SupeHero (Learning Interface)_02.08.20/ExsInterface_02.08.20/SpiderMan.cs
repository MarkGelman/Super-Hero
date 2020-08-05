using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsInterface_02._08._20
{
    class SpiderMan:Human,IClimb
    {
        int _webleft;
        public SpiderMan(string name, int age,int Webleft) : base(age)
        {
            SetName(name);
            SetWebleft(Webleft);
        }

        private string _name;

        public override string GetName()
        {
            return _name;
        }

        protected override void SetName(string name)
        {
            _name = name;
        }
        public int GetWebleft()
        {
            return _webleft;
        }

        protected void SetWebleft(int webleft)
        {
            _webleft = webleft;
        }

        public void Climb()
        {
            Console.WriteLine($"Spiderman is climb by {GetWebleft()}");
        }

        public void ActivateSuperPowers()
        {
            Climb();
        }
    }
}
