using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace Winform_Nhom20_BTL.views
{
    internal interface phimview
    {
        int phimid { get; set; }
        string phimten {  get; set; }
        int thoiluong {  get; set; }
        string theloai {  get; set; }
        string daodienn { get; set; }
        string mota {  get; set; }
        string hinhanh { get; set; }


        string searchvalue {  get; set; }
        bool isedit {  get; set; }
        bool issuccessful {  get; set; }
        string message {  get; set; }



        event EventHandler searchevent;
        event EventHandler addnewevent;
        event EventHandler editevent;
        event EventHandler deleteevent;
        event EventHandler saveevent;
        event EventHandler canceenvent;


        void setphimlistbingdingsource(BindingSource petlist);
    }
}
