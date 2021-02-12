using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace nasa_apka
{
    public class Page3 : ContentPage
    {
        public Page3()
		{
			var previousPageButton = new Button { Text = "Previous Page", VerticalOptions = LayoutOptions.CenterAndExpand };
			previousPageButton.Clicked += OnPreviousPageButtonClicked;

			var rootPageButton = new Button { Text = "Return to Root Page", VerticalOptions = LayoutOptions.CenterAndExpand };
			rootPageButton.Clicked += OnRootPageButtonClicked;

		
			Title = "Page 3";
			Content = new StackLayout
			{
				Children = {
					previousPageButton,
					rootPageButton,
					
				}
			};
		}

		async void OnPreviousPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		async void OnRootPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopToRootAsync();
		}
		
	}
}