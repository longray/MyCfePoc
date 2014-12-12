using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CfePocApp.Model
{
    using System.Collections.ObjectModel;

    public interface IDataService
    {
        void GetTexts(Action<Texts, Exception> callback);
        void GetCustomers(Action<ObservableCollection<Customer>, Exception> callback);
    }
}
