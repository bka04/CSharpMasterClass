using System;
namespace CSharpMasterClass
{
    public interface IDestroyable //interfaces implement what an object can do! Behavior.
    {
        string DestructionSound { get; set; }

        void Destroy();
    }
}

