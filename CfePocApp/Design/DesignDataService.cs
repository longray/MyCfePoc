using System;
using CfePocApp.Model;

namespace CfePocApp.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<TextsModel, Exception> callback)
        {
            // Use this to create design time data

            var item = new TextsModel(12);
            callback(item, null);
        }
    }
}