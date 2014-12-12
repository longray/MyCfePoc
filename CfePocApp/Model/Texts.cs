using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CfePocApp.Model
{
    using System.ComponentModel;

    using CfePocApp.Annotations;

    public class Texts :INotifyPropertyChanged
    {
        public Texts(double fontSize, string textForMenu)
        {
            this.fontSize = fontSize;
            this.textForMenu = textForMenu;
        }

        private double fontSize;

        private string textForMenu;

        public double FontSize
        {
            get
            {
                return this.fontSize;
            }
            set
            {
                if (value.Equals(this.fontSize))
                {
                    return;
                }
                this.fontSize = value;
                this.OnPropertyChanged("FontSize");
            }
        }

        public string TextForMenu
        {
            get
            {
                return this.textForMenu;
            }
            set
            {
                if (value == this.textForMenu)
                {
                    return;
                }
                this.textForMenu = value;
                this.OnPropertyChanged("TextForMenu");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
