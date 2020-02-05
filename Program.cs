using System;

namespace OOP_Homework_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GasCooktop gasC = new GasCooktop();
            ElectricCooktop electricC = new ElectricCooktop();
            GasOven gasO = new GasOven();
            ElectricOven electricO = new ElectricOven();
            GasStove gasS = new GasStove();
            ElectricStove electricS = new ElectricStove();
            gasC.Cook();
            electricC.Cook();
            gasO.Bake();
            electricO.Bake();
            gasS.Cook();
            gasS.Bake();
            electricS.Cook();
            electricS.Bake();

            //Console.WriteLine("Hello World!");
        }
    }
    interface ICooked 
    {
        void Cook();
    }
    interface IBaked
    {
        void Bake();
    }
    public abstract class Cooktop: ICooked
    {
        public void Cook()
        {
            Console.WriteLine("Cooking");
        }
    }
    public class GasCooktop : Cooktop
    { 
        
    }
    public class ElectricCooktop : Cooktop
    {

    }
    public abstract class Oven : IBaked
    {
        public void Bake()
        {
            Console.WriteLine("Baking");
        }
    }
    public class GasOven : Oven
    {

    }
    public class ElectricOven  : Oven
    {

    }
    public abstract class Stove : IBaked, ICooked
    {
        public void Bake()
        {
            Console.WriteLine("Baking");
        }
        public void Cook()
        {
            Console.WriteLine("Cooking");
        }

    }
    public class GasStove : Stove
    {

    }
    public class ElectricStove : Stove
    {

    }
}
