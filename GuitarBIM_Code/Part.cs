using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarBIM_Code
{
    public class Part
    {
        string productName;
        string productNumber;
        string serialNumber;
        string description;

        #region Constructors

        public Part(string productNumber)
        {
            this.productName = Constants.NOT_APPLICABLE;
            this.productNumber = productNumber;
            this.serialNumber = Constants.NOT_APPLICABLE;
            this.description = string.Empty;
        }

        public Part(string productName, string productNumber)
        {
            this.productName = productName;
            this.productNumber = productNumber;
            this.serialNumber = Constants.NOT_APPLICABLE;
            this.description = string.Empty;
            
        }

        public Part(string productName, string productNumber, string serialNumber)
        {
            this.productName = productName;
            this.productNumber = productNumber;
            this.serialNumber = serialNumber;
            this.description = string.Empty;
        }

        public Part(string productName, string productNumber, string serialNumber, string description)
        {
            this.productName = productName;
            this.productNumber = productNumber;
            this.serialNumber = serialNumber;
            this.description = description;
        }
        
        #endregion

        public string ProductName
        {
            get { return productName; }
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
