using System;

namespace CfePocApp.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<TextsModel, Exception> callback)
        {
            var item = new TextsModel(14);
            callback(item, null);
        }
    }
}