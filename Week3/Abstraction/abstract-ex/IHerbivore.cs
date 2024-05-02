using System.ComponentModel;
using System.Runtime.CompilerServices;

interface IHerbivore
{
    //"Concrete" Methods in Interfaces - "Default" Methods
    public virtual void EatPlant()
    {
        System.Console.WriteLine("Eats Plants");
    }
}