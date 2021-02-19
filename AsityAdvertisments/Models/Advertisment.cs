using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsityAdvertisments.Models
{
    public class Advertisment
    {
        public int id { get; set; }
        public String CompanyName { get; set; }
        public String phoneNumber { get; set; }
        public float priceUSD { get; set; }
        public float courseOfUSD { get; set; }
        public float priceBYN { get; set; }

        public Advertisment(int id, String CompanyName, 
            String phoneNumber, float priceUSD, float courseOfUSD, float priceBYN)
        {
            this.id = id;
            this.CompanyName = CompanyName;
            this.phoneNumber = phoneNumber;
            this.priceUSD = priceUSD;
            this.courseOfUSD = courseOfUSD;
            this.priceBYN = priceBYN;

        }

        public Advertisment()
        {
            this.id = 0;
            this.CompanyName = "";
            this.phoneNumber = "";
            this.priceUSD = 0;
            this.courseOfUSD = 0;
            this.priceBYN = 0;

        }
    }
}
