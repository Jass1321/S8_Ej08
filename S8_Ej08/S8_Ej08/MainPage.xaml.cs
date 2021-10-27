using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace S8_Ej08
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item11.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitDemo());
            };
            Item12.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitControlDemo());
            };
            Item13.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitDemo());
            };
            Item14.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitControlDemo());
            };
            Item15.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GlobalDemo());
            };
            Item16.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InheritanceDemo());
            };
            Item17.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicDemo());
            };
            Item18.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ClassDemo());
            };
            Item19.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CSSDemo());
            };
        }

    }
}
