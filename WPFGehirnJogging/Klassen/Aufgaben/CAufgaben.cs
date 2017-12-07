using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace WPFGehirnJogging.Klassen
{
    class CAufgaben
    {
        public void DisplayAufgabe()
        {
            
        }

        public virtual void DisplayResult()
        {
            
        }


        public virtual bool CheckResult(string Result)
        {
            return true;
        }
    }
}
