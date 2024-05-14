using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_ServiceAuto.Model
{
    public class CarStatistics
    {

        private string criterion;
        private DataTable carList;
        private Dictionary<string, uint> result;

        public CarStatistics(DataTable carList)
        {
            this.carList = carList;
            this.criterion = "Fuel";
            this.resultDetermination();
        }

        public string Criterion
        {
            get { return this.criterion; }
            set { this.criterion = value; this.resultDetermination(); }
        }

        public Dictionary<string, uint> Result
        {
            get { return this.result; }

        }
        
        private void resultDetermination() 
        {
            this.result = new Dictionary<string, uint>();
            if (this.criterion == "Brand")
                this.resultDeterminationBrand();
            else if(this.criterion == "Fuel")
                this.resultDeterminationFuel();
        }

        private void resultDeterminationBrand() 
        {
            foreach(DataRow row in this.carList.Rows)
            {
                string brand = row["brand"].ToString();
                string key = brand;
                if (this.result.ContainsKey(key))
                {
                    this.result[key]++;
                } else this.result[key] = 1;
            }
        }


        private void resultDeterminationFuel() 
        {
            foreach (DataRow row in this.carList.Rows)
            {
                string fuel = row["fuel"].ToString();
                string key = fuel;
                if (this.result.ContainsKey(key))
                {
                    this.result[key]++;
                }
                else this.result[key] = 1;
            }
        }
    }
}
