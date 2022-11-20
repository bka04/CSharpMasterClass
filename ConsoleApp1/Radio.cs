using System;
namespace CSharpMasterClass
{
    public class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand):base(isOn, brand)
        {
        }

        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the radio!");
            } else
            {
                Console.WriteLine("Radio is turned off. Switch it on first.");
            }
        }
    }
}

