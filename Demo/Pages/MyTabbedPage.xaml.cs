﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo
{
    public class PhotoUrl2 : PhotoUrl
    {
        public PhotoUrl2()
        {
            System.Diagnostics.Debug.WriteLine("!!!!!!   PhotoUrl2 constructor called.");
        }
    }

	public partial class MyTabbedPage : TabbedPage
	{
		public MyTabbedPage()
		{
			InitializeComponent();

			myCarousel.ItemsSource = new List<DataTemplate>()
			{
				new DataTemplate(() => { return new PhotoUrl2(); }),
				new DataTemplate(() => { return new Bio(); }),
				new DataTemplate(() => { return new ContactInfo(); })
			};

			myCarousel.BindingContext = new Person()
			{
				PhotoUrl = "https://media.licdn.com/mpr/mpr/shrinknp_400_400/AAEAAQAAAAAAAAefAAAAJDJkNGNiOTU4LWI4ZTQtNDY5My1hZWJhLTE3ZGQ5Y2I1MzRmMQ.jpg",
				Bio = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi.",
				ContactInfo = "alexrainman1975@gmail.com"
			};
		}
	}
}
