using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Task3
{
    class FeatureData
    {
        public double mu;
        public double sigma;

        public FeatureData() { }
        public FeatureData(double m,double s)
        {
            this.mu = m;
            this.sigma = s;
        }
    }
}
