namespace ConsoleApp1.Classes
{
    public class car
    {
        public string brand;
        public string model;
        public int year;

        public void startEngine()
        {
            Console.WriteLine(
                brand + " is started" +
                "\nBrand of car:  " + brand +
                "\nModel of car: " + model +
                "\nYear of car: " + year
            );
        }
    }
}