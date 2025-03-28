using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Nhom20_BTL.Model
{
    internal interface phimreposcitory
    {
        void add(phimmodel phimmodel);
        void exit(phimmodel phimmodel);
        void delete (int  id);
        IEnumerable<phimmodel> Getall();
        IEnumerable<phimmodel> Getbyvalue();
    }
}
