using System;
namespace CSharpMasterClass
{
    public class M3 : BMW
    {

        public M3(int hp, string color, string model) : base(hp, color, model)
        {
            Model = model;
        }

        /*
        public override void Repair()
        {
            base.Repair();
        }
        */

    }
}

