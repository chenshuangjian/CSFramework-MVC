﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Framework_Base
{
    /// <summary>
    /// 控制器，用于组合数据Model与界面View
    /// </summary>
    public abstract class BaseController
    {
        public IBaseView view { get; }
        public BaseModel model { get; }
        public event EventHandler LoadSuccess, LoadFailed;

        public  BaseController(IBaseView view,BaseModel model) {
            this.view = view;
            this.model = model;
            LoadSuccess += OnLoadSucceededHandler;
            LoadFailed += OnLoadFailedHandler;
        }

        public void Show() {
            view.Show();
        }

        public abstract bool Loadable();

        protected virtual void OnLoadSucceededHandler(Object sender, EventArgs e)
        {
            AppManager.Instance.Show(this);
        }

        protected virtual void OnLoadFailedHandler(Object sender, EventArgs e)
        {
            if (MessageBox.Show("You don't have access to load this page.\nThe application will exit now.") == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public void OnLoadSuccess(EventArgs e)
        {
            if (LoadSuccess != null)
                LoadSuccess(this, e);
        }

        public void OnLoadFailure(EventArgs e)
        {
            if (LoadFailed != null)
                LoadFailed(this, e);
        }
    }
}
