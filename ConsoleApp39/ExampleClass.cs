using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    internal class ExampleClass
    {
        private string carModel;
        private string carColor;
        private string ownerName;
        public string CarModel { get; set; }
        public string CarColor { get; set; }
        public string OwnerName { get; set; }
        public static List<ExampleClass> _cars;
        public ExampleClass(string model, string color, string owner)
        {
            if (_cars == null)
                _cars = new List<ExampleClass>();
            this.CarModel = model;
            this.CarColor = color;
            this.OwnerName = owner;
            foreach (var car in _cars)
            {
                car.OwnerName = owner;
            }
            _cars.Add(this);
        }
    }
}
