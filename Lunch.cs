using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_124_Program_III_Mid_Exam_One
{
    abstract internal class Lunch : Food
    {
        bool isCombo;
        Lunch _isCombo;

        protected Lunch(string name, decimal price, int point, string sku, string numberOfProduct,double temperature, Lunch isCombo) : base(name, price, point, sku, numberOfProduct, temperature)
        {
            isCombo = isCombo;
        }

        public override string ToString()
        {
            return base.ToString() + $"_isCombo : {_isCombo}";
        }
        public override bool InStock
        {
            get
            {
                if (isCombo) return true;
                return false;
            }
        }
    }
}

