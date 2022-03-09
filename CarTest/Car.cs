using System;

namespace CarTest
{
    public class Car
    {
        private int id;
        private string model;
        private double price;
        private string licenseplatee;

        public int Id { get; set; }

        public string Model
        {
            get => model;
            set
            {
                if (value == null) throw new ArgumentNullException("Model", "Null");
                if (value.Length < 4) throw new ArgumentOutOfRangeException("Model length must be at least have 3 charaters");
                model = value;
            }
        }

        public double Price
        {
            get => price;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("price", "Price must be higher than 0");
                price = value;

            }
        }
        public string LicensePlate
        {
            get => licenseplatee;
            set
            {
                if (value.Length >= 2 && value.Length <= 7) licenseplatee = value;
                else throw new ArgumentOutOfRangeException("licenseplate", value, "Wrong licenseplate");
            }
        }

        public Car()
        {
            
        }

        public Car(int id, string model,double price,string licenseplatee)
        {
            Id = id;
            Model = model;
            Price = price;
            LicensePlate = licenseplatee;
        }


        public override string ToString()
        {
            return " ID " + id + " Model " + Model + " Price " + Price + " LicensePlate " + LicensePlate;
        }


    }
}
