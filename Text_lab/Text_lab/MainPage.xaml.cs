using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Text_lab
{
    public partial class MainPage : ContentPage
    {
        bool isCheck_italic = false;
        bool isCheck_bold = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void onClick_Italick(object sender, EventArgs e)
        {
            if (isCheck_italic == false)
            {

                label.FontAttributes |= FontAttributes.Italic;

                isCheck_italic = true;
                Italic.BackgroundColor = Color.DarkSlateGray;
            }
            else if (isCheck_italic == true)
            {

                label.FontAttributes &= ~FontAttributes.Italic;
                Italic.BackgroundColor = Color.LightGray;
                isCheck_italic = false;
            }

        }

        private void onClick_bold(object sender, EventArgs e)
        {
            if (isCheck_bold == false)
            {
                label.FontAttributes |= FontAttributes.Bold;
                isCheck_bold = true;
                Bold.BackgroundColor = Color.DarkSlateGray;
            }
            else if (isCheck_bold == true)
            {
                label.FontAttributes &= ~FontAttributes.Bold;
                isCheck_bold = false;
                Bold.BackgroundColor = Color.LightGray;
            }

        }


        private void onClick_None(object sender, EventArgs e)
        {
            label.TextTransform = TextTransform.None;
        }
        private void onClick_a(object sender, EventArgs e)
        {
            label.TextTransform = TextTransform.Lowercase;
        }
        private void onClick_A(object sender, EventArgs e)
        {
            label.TextTransform = TextTransform.Uppercase;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;

            label.FontSize = value;
            Size.Text = string.Format("{0}", value);

        }
    }
}
