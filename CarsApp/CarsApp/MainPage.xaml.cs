using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarsApp
{
    public partial class MainPage : ContentPage
    {

        private List<Car> _car = new List<Car>();


        public List<Car> Car
            { get { return _car; } 
            set { _car = value; }
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
