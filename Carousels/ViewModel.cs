using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Carousels
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private INavigation navigation;

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            CarouselImages = new List<BusinessProfilePhoto>();
            var image = new BusinessProfilePhoto
            {
                Caption = "howdy",
                Ord = 1,
                Url = "https://docs.microsoft.com/en-us/xamarin/xamarin-forms/xaml/xaml-basics/data-bindings-to-mvvm-images/oneshotdatetime-large.png"
            };
            CarouselImages.Add(image);
        }

        List<BusinessProfilePhoto> carouselImages;

        public List<BusinessProfilePhoto> CarouselImages
        {
            get { return carouselImages; }
            set {
                if (carouselImages != value)
                {
                    carouselImages = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CarouselImages"));
                }
            }
        }

        int carouselPageIndex;
        public int CarouselPageIndex
        {
            get { return carouselPageIndex; }
            set { if (carouselPageIndex != value) {
                    carouselPageIndex = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CarouselPageIndex"));
                }
            }
        }

    }
}


public class BusinessProfilePhoto
{
    public string Caption { get; set; }

    public int Ord { get; set; }

    public string Url { get; set; }
}