using Framework_Base;
using Framework_Model;
using Framework_View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework_Controller
{
    public class StudentController : BaseController
    {
        public StudentController(IBaseView view, BaseModel model) : base(view, model)
        {
            
        }

        public StudentController() : base(new FrmStudent(), new Student())
        {
             
        }

        public override bool Loadable()
        {
            return true;
        }
    }
}
