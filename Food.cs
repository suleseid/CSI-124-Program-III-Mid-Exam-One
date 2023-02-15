using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_124_Program_III_Mid_Exam_One
{
    abstract internal class Food : Product
    {
        bool isHeated;
        double _temperature;
        protected Food(string name, decimal price, int point, string sku, string numberOfProduct, double temperature) : base(name, price, point, sku, numberOfProduct)
        {
            _temperature = _temperature;
        }
        public double temperature
        {
            get => _temperature;
        }
        public override string ToString()
        {
            return base.ToString() + $"-temperature: {_temperature}";
        }
        public override bool InStock()
        {
            if (isHeated) return true;
            return false;
        }
            
         
        
    }
}
