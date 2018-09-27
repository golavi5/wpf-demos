﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TileViewVirtualization
{
    /// <summary>
    /// Interaction logic for UserTemplate.xaml
    /// </summary>
    public partial class UserTemplate : UserControl
    {
        public UserTemplate()
        {
            InitializeComponent();
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(UserTemplate), new FrameworkPropertyMetadata("",OnTextChanged));

        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserTemplate instance = d as UserTemplate;
            instance.DescriptionTxtblck.ToolTip = instance.DescriptionTxtblck.Text = e.NewValue.ToString();
        }

           public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
           public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(string), typeof(UserTemplate), new FrameworkPropertyMetadata("", OnHeaderChanged));

           private static void OnHeaderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
           {
               UserTemplate instance = d as UserTemplate;
               instance.HeaderTxtblck.Text = e.NewValue.ToString();
           }

    }
}