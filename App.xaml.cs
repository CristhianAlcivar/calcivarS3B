﻿using calcivarS3B.Views;

namespace calcivarS3B
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new Login());
        }
    }
}
