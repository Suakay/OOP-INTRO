using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_BaseKitap
{
    internal class BaseKitap
    {
        public DateTime CreateDate { get; set; }    
        public DateTime ModifiedDate { get; set; } 
        
        public virtual void GetLog()
        {
            Console.WriteLine("KAYIT BAŞLADI");
        }
    }
}
