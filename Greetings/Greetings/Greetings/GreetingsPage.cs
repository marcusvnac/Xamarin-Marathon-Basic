using System;
using Xamarin.Forms;

namespace Greetings
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            var MyLabel = new Label();
            MyLabel.Text = "Greetings, Xamarin.Forms!";
            this.Content = MyLabel;
            /*
            Padding = Device.OnPlatform<Thickness>(
                new Thickness(0, 20, 0, 0),
                new Thickness(0),
                new Thickness(0)
            );
            */
            Device.OnPlatform(iOS: () =>
            {
                Padding = new Thickness(0, 20, 0, 0);
            });

            MyLabel.HorizontalOptions = LayoutOptions.Center;
            MyLabel.VerticalOptions = LayoutOptions.Center;

            MyLabel.HorizontalTextAlignment = TextAlignment.Center;
            MyLabel.VerticalTextAlignment = TextAlignment.Center;
        }
    }
}