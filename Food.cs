using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_AssignmentDay2
{
    public class Food
    {
        private string foodname;
        private int foodprice;

        public Food(string foodname, int foodprice)
        {
            this.foodname = foodname;
            this.foodprice = foodprice;
        }

        public override string ToString()
        {
            return foodname + "  " + foodprice;
        }
    }


}
