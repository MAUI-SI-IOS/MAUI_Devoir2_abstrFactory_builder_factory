using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.v1.Product.Interior
{
    internal class PersianInterior: IInterior
    {
        public string display()
        {
            return "persian interior";
        }
    }
}
