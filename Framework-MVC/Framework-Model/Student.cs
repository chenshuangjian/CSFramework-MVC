using Framework_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework_Model
{
    public class Student : BaseModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }
    }
}
