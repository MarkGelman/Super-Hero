using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsInterface_02._08._20
{
    class Flash:Human,IFlash
    {
        int _voltage;
        public Flash(string name, int age,int voltage) : base(age)
        {
            SetName(name);
            SetVoltage(voltage);
        }

        public int GetVoltage ()
        {
            return _voltage;
        }

        private void SetVoltage(int voltage)
        {
            _voltage = voltage;
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


        public void ActivateSuperPowers()
        {
            FireLightnings();
        }

        public void FireLightnings()
        {

            Console.WriteLine($"Flash is fire lightnings by voltage {GetVoltage()}");
        }
    }
}
