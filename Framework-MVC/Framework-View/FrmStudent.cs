using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework_Base;

namespace Framework_View
{
    public partial class FrmStudent : Form,IBaseView
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        public string Title { get => this.Title; set => this.Title = value; }

        public Form Form => this;
    }
}
