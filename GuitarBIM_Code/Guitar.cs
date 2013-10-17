using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarBIM_Code
{
    public class Guitar
    {
        string modelName;
        string productNumber;
        string serialNumber;
        string description;

        List<Part> parts;

        public Guitar(string modelName)
        {
            this.modelName = modelName;
        }

        public Guitar(string modelName, string productNumber, string serialNumber, List<Part> parts)
        {
            this.modelName = modelName;
            this.productNumber = productNumber;
            this.serialNumber = serialNumber;

            this.parts = parts;
        }

        public string ModelName
        {
            get { return modelName; }
        }

        public string ProductNumber
        {
            get { return productNumber; }
        }

        public string SerialNumber
        {
            get { return serialNumber; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
