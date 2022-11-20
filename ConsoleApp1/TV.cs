using System;
namespace CSharpMasterClass
{
    public class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand):base(isOn, brand)
        {
        }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching the TV!");
            }
            else
            {
                Console.WriteLine("TV is turned off. Switch it on first.");
            }
        }
    }
}

