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
    public interface RestaurantReviewService
    {

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginGetRestaurantNames(AsyncCallback callback, object asyncState);
        IEnumerable<string> EndGetRestauranNames(IAsyncResult r);
          

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginGetRestaurantByName(string name, AsyncCallback callback, object asyncState);
        IRestaurantInfo EndGetRestaurantByName(IAsyncResult r);

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginGetRestaurantsByRating(int rating, AsyncCallback callback, object asyncState);
        IRestaurantInfo EndGetRestaurantsByRating(IAsyncResult r);

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginSaveRestaurant(IRestaurantInfo restaurant, AsyncCallback callback, object asyncState);
        IRestaurantInfo EndSaveRestaurant(IAsyncResult r);


        // TODO: Add your service operations here
    }
}
