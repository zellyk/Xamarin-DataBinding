using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBinding
{

    public partial class MainPage : ContentPage
    {
        public IList<Fruit> Fruits { get; set; }
        public MainPage()
        {

            InitializeComponent();
            Fruits = new List<Fruit>();
            AddFruits();
            BindingContext = this;
        }

        public void AddFruits()
        {
            Fruits.Add(new Fruit
            {
                Name = "PPC",
                Color = "Purple",

                ImageUrl = "https://img.muskokaradio.com/media/ppc_whitelettera.jpg"
            });

            Fruits.Add(new Fruit
            {
                Name = "Liberals",
                Color = "Red",
                ImageUrl = "https://s31184.pcdn.co/wp-content/uploads/sites/292/2021/01/Red-PNG.png"

            });

            Fruits.Add(new Fruit
            {
                Name = "NDP",
                Color = "Orange",
                ImageUrl = "https://pbs.twimg.com/profile_images/1196465881087455232/hFKPjmeb_400x400.png"
            });

        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Fruit itemSelected = (Fruit)e.CurrentSelection[0];
        }
    }

}
