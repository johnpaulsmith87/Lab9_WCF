using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestaurantReviewService
{
    /// <summary>
    /// Asynchronus Restaurant Review Service
    /// </summary>
    [ServiceContract]
    public interface IRestaurantReviewService
    {

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginGetRestaurantNames(AsyncCallback callback, object asyncState);
        IEnumerable<string> EndGetRestaurantNames(IAsyncResult r);
          

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginGetRestaurantByName(string name, AsyncCallback callback, object asyncState);
        RestaurantInfo EndGetRestaurantByName(IAsyncResult r);

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginGetRestaurantsByRating(int rating, AsyncCallback callback, object asyncState);
        IEnumerable<RestaurantInfo> EndGetRestaurantsByRating(IAsyncResult r);

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginSaveRestaurant(RestaurantInfo restaurant, AsyncCallback callback, object asyncState);
        bool EndSaveRestaurant(IAsyncResult r);
    }
}
