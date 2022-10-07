using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void isAllChecked(object s,RoutedEventArgs r)
        {
            bool newVal = AllTopings.IsChecked==true;

            {
                Salamai.IsChecked = newVal;
                Origano.IsChecked = newVal;

            }
        }

        private void isChecked(object s,RoutedEventArgs r)
        {
            AllTopings.IsChecked = null;

            if (Salamai.IsChecked == true && Origano.IsChecked == true)
                AllTopings.IsChecked = true;

        }
        
    }
}
<Window x:Class="WpfApp1.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp1"
        mc:Ignorable="d"
        Title="My First GEW" Height="500" Width="500">

    <StackPanel>
        <Label FontWeight="Bold" >Pizza Topings!!</Label>
        <CheckBox Name="AllTopings" IsThreeState="true" Checked="isAllChecked" Unchecked="isAllChecked">Add all</CheckBox>
        
        <StackPanel Margin="30">
            <CheckBox  ToolTip="Salami!!" Name="Salamai" Checked="isChecked" Unchecked="isChecked">
                <Run Foreground="Red" >
                    Salami
                </Run>
            </CheckBox>

            <CheckBox  ToolTip="Origano!!" Name="Origano" Checked="isChecked" Unchecked="isChecked">
            <Run Foreground="Green">
                Origano
            </Run>
        </CheckBox>
        </StackPanel>
    </StackPanel>
    
</Window>

