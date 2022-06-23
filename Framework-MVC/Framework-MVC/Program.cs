using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework_Base;
using Framework_Controller;
using Framework_View;
using Framework_Model;
using System.Windows.Forms;

namespace Framework_MVC
{
    class Program
    {
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            AppManager.Start<StudentController>();

        }
    }
}
