
/// Homework No. 8 Project No. 2
/// File Name : Program.cs
/// @author : Joshua Um
/// Date : Oct 25 2021
/// 
/// Problem Statement : Write a Temperature class that has two instance variables: a temperature value (a floating-point number) and a character for the scale, either C for Celsius of F for Fahrenheit.
/// 
/// Plan:
/// 1. Test default constructor.
/// 2. Test temperature value constructor.
/// 3. Test temperature scale constructor.
/// 4. Test full constructor.
/// 5. Test getTemperature().
/// 6. Test getTemperature(C).
/// 7. Test setTemperature(tempatureValue).
/// 8. Test setTemperature(temperatureScale, tempatureValue)
/// 7. Test equals().



using System;

namespace HW8Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature();

            Console.WriteLine("Temperature Object test : " + t);

           

            t = new Temperature(50);

            Console.WriteLine("Temperature value Object test : " + t);


            t = new Temperature('F');

            Console.WriteLine("Temperature scale Object test : " + t);

            Temperature t2 = new Temperature('F', 100);

            Console.WriteLine("Temperature full constructor Object test : " + t2);

            Console.WriteLine("Temperature getTemperature() test : " + t2.getTemperature());

            Console.WriteLine("Temperature getTemperature(C) test : " + t2.getTemperature('C'));


            t.setTemperature(60);

            Console.WriteLine("Temperature setTemperature(60) test : " + t);

            t.setTemperature('C',3);

            Console.WriteLine("Temperature setTemperature(C,3) test : " + t);

            Console.WriteLine("Temperature equals() test : " + t2.Equals(t));

            Console.WriteLine("Temperature equals() test 2: " + t2.Equals(t2));


          






        }



        
    }

    class Temperature
    {
        public const char FAHRENHEIT_CHAR = 'F';
        public const char CELSIUS_CHAR = 'C';

        private double temperatureValue;
        private char temperatureScale;



        public Temperature()
        {
            this.temperatureValue = 0;
            this.temperatureScale = CELSIUS_CHAR;
        }

        public Temperature(char temperatureScale)
        {
            this.temperatureValue = 0;
            this.temperatureScale = temperatureScale;
        }

        public Temperature(double temperatureValue)
        {
            this.temperatureValue = temperatureValue;
            this.temperatureScale = CELSIUS_CHAR;
        }

        public Temperature(char temperatureScale, double temperatureValue)
        {
            this.temperatureValue = temperatureValue;
            this.temperatureScale = temperatureScale;
        }

        public char getScale()
        {
            return temperatureScale;
        }


        public double getTemperature()
        {
            return temperatureValue;
        }


        public double getTemperature(char temperatureScale)
        {
            if (this.temperatureScale == temperatureScale)
                return this.temperatureValue;

            switch (temperatureScale)
            {
                case FAHRENHEIT_CHAR:  return Math.Round((this.temperatureValue * (9.0 / 5)) + 32,1);
                case CELSIUS_CHAR:     return Math.Round((this.temperatureValue - 32)*(5.0/9),1);
                default:               return 0;
            }
        }


        public void setTemperature(double temperatureValue)
        {
            this.temperatureValue = temperatureValue;
        }

        public void setTemperature(char temperatureScale, double temperatureValue)
        {
            if (this.temperatureScale == temperatureScale)
            {
                this.temperatureValue = temperatureValue;
                return;
            }

            this.temperatureScale = temperatureScale;

            switch (temperatureScale)
            {
                case FAHRENHEIT_CHAR:
                    this.temperatureValue = (this.temperatureValue * (9.0 / 5)) + 32;
                    break;
                case CELSIUS_CHAR:
                    this.temperatureValue = (this.temperatureValue - 32) * (5.0 / 9);
                    break;
            }
        }

        public override string ToString()
        {
            return temperatureValue + "°" + temperatureScale;
        }



        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Temperature))
            {
                return false;
            }

            Temperature other = (Temperature)obj;

            return this.temperatureValue == other.getTemperature() &&
                   this.temperatureScale == other.getScale();
        }








    }


}
