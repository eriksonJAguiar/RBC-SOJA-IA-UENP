using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class MaxMinimos
    {
        private static MaxMinimos singleton = null;
        public Hashtable table { get; set; }

        private MaxMinimos() {
            table = new Hashtable();
        }

        public static MaxMinimos getInstance()
        {
            if (singleton == null)
            {
                singleton = new MaxMinimos();

                return singleton;
            }
                

            return singleton;
        }
    }
}
