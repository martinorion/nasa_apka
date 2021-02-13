using System;

using Xamarin.Forms;

namespace nasa_apka
{
    public class Page1 : ContentPage
    {
		public Page1()
		{
			var nextPageButton = new Button { Text = "Súhlasím", VerticalOptions = LayoutOptions.CenterAndExpand };
		nextPageButton.Clicked += OnNextPageButtonClicked;

			Title = "Úvod";
			Content = new StackLayout
			{
				Children = {
					nextPageButton
	}
};
		}

		async void OnNextPageButtonClicked(object sender, EventArgs e)
{
	await Navigation.PushAsync(new Page2());
}
    }
 }