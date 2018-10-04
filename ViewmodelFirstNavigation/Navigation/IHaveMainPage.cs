﻿using Xamarin.Forms;

namespace ViewmodelFirstNavigation.Navigation
{
    /// <remarks>
    /// Add this interface to your App class to allow the NavigationService to set the main page
    /// </remarks>
    public interface IHaveMainPage
    {
        Page MainPage { get; set; }
    }
}
