using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CfePocApp.Model
{
    public interface IDataService
    {
        void GetData(Action<TextsModel, Exception> callback);
    }
}
