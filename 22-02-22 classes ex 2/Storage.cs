using System;
using System.Collections.Generic;
using System.Text;

namespace _22_02_22_classes_ex_2
{
    class Storage
    {
        public int teller;
        public int noemer;
        public double breuk;
        public Storage()
        {
           teller = 20;
            noemer = 10;
           
        }
        public Storage (int OpvragenTeller, int OpvragenNoemer)
        {
            
            teller = OpvragenTeller;
            noemer = OpvragenNoemer;
            breuk = teller / noemer;
        }
    }
}
