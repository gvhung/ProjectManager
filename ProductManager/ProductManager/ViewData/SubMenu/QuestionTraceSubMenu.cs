﻿using System;
using System.ComponentModel.Composition;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ProductManager
{
    [Export(typeof(ISubMenu))]
    public class QuestionTraceSubMenu : ISubMenu
    {
        public String Content
        {
            get
            {
                return "交互平台";
            }
        }

        public String NavigateUri
        {
            get
            {
                return "QuestionTrace";
            }
        }

        public SubMenuType MenuType
        {
            get
            {
                return SubMenuType.PRODUCT_MANAGER_SUBMENU;
            }
        }

        public int ActionID
        {
            get
            {
                return 2040000;
            }
        }

        public int OrderNumber
        {
            get
            {
                return 3;
            }
        }
    }
}
