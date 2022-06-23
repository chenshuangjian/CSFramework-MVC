using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Framework_Base
{
    /// <summary>
    /// View抽象基类
    /// </summary>
    public interface IBaseView
    {
        void Show();
        string Title { get; set; }

        Form Form { get; }

        void Close();
    }
}
