﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamBuddyApp.TabViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicMDP : TabbedPage
    {
        public DynamicMDP ()
        {
            InitializeComponent();
        }
    }
}