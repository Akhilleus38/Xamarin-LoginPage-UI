﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LoginPage
{
    public class CustomEntry : Entry
    {
        public bool IsPasswordValid { get; internal set; }
    }
}
