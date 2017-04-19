using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestaurantReviewService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : RestaurantReviewService
    {

        public IAsyncResult BeginGetRestaurantNames(AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<string> EndGetRestauranNames(IAsyncResult r)
        {
            throw new NotImplementedException();
        }
        public IAsyncResult BeginGetRestaurantsByRating(int rating, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }
        public IRestaurantInfo EndGetRestaurantsByRating(IAsyncResult r)
        {
            throw new NotImplementedException();
        }
        public IAsyncResult BeginSaveRestaurant(IRestaurantInfo restaurant, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }
        public IRestaurantInfo EndSaveRestaurant(IAsyncResult r)
        {
            throw new NotImplementedException();
        }
        public IAsyncResult BeginGetRestaurantByName(string name, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }
        public IRestaurantInfo EndGetRestaurantByName(IAsyncResult r)
        {
            throw new NotImplementedException();
        }
    }
}
