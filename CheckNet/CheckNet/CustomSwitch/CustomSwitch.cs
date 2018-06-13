using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CheckNet.CustomSwitch
{
    public class CustomSwitch : Switch
    {
        public static readonly BindableProperty SwitchBGColorProperty =
          BindableProperty.Create(nameof(SwitchBGColor),
              typeof(Color), typeof(CustomSwitch),
              Color.Default);

        public Color SwitchBGColor
        {
            get { return (Color)GetValue(SwitchBGColorProperty); }
            set { SetValue(SwitchBGColorProperty, value); }
        }

        public static readonly BindableProperty SwitchThumbColorProperty =
          BindableProperty.Create(nameof(SwitchThumbColor),
              typeof(Color), typeof(CustomSwitch),
              Color.Default);

        public Color SwitchThumbColor
        {
            get { return (Color)GetValue(SwitchThumbColorProperty); }
            set { SetValue(SwitchThumbColorProperty, value); }
        }

        public static readonly BindableProperty SwitchThumbImageProperty =
          BindableProperty.Create(nameof(SwitchThumbImage),
              typeof(string),
              typeof(CustomSwitch),
              string.Empty);

        public string SwitchThumbImage
        {
            get { return (string)GetValue(SwitchThumbImageProperty); }
            set { SetValue(SwitchThumbImageProperty, value); }
        }
    }
}
