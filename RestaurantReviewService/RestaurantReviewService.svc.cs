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
            var rootElement = XMLDataAccess.GetXMLRootElement<Restaurants>();
            var result = rootElement.Restaurant.Select(resto => resto.Name);
            return new CompletedAsyncResult<IEnumerable<string>>(result);
        }
        public IEnumerable<string> EndGetRestauranNames(IAsyncResult r)
        {
            CompletedAsyncResult<IEnumerable<string>> result = r as CompletedAsyncResult<IEnumerable<string>>;
            return result.Data;
        }
        public IAsyncResult BeginGetRestaurantByName(string name, AsyncCallback callback, object asyncState)
        {
            var rootElement = XMLDataAccess.GetXMLRootElement<Restaurants>();
            var result = rootElement.Restaurant.Select(resto => new RestaurantInfo(resto)).Single(resto => resto.Name == name);
            return new CompletedAsyncResult<IRestaurantInfo>(result);
        }
        public IRestaurantInfo EndGetRestaurantByName(IAsyncResult r)
        {
            CompletedAsyncResult<IRestaurantInfo> result = r as CompletedAsyncResult<IRestaurantInfo>;
            return result.Data;
        }
        public IAsyncResult BeginGetRestaurantsByRating(int rating, AsyncCallback callback, object asyncState)
        {
            var rootElement = XMLDataAccess.GetXMLRootElement<Restaurants>();
            var result = rootElement.Restaurant.Select(resto => new RestaurantInfo(resto)).Where(resto => resto.Rating == rating);
            return new CompletedAsyncResult<IEnumerable<IRestaurantInfo>>(result);
        }
        public IEnumerable<IRestaurantInfo> EndGetRestaurantsByRating(IAsyncResult r)
        {
            CompletedAsyncResult<IEnumerable<IRestaurantInfo>> result = r as CompletedAsyncResult<IEnumerable<IRestaurantInfo>>;
            return result.Data;
        }
        public IAsyncResult BeginSaveRestaurant(IRestaurantInfo restaurant, AsyncCallback callback, object asyncState)
        {
            var rootElement = XMLDataAccess.GetXMLRootElement<Restaurants>();
            var restaurantToModify = rootElement.Restaurant.Single(resto => resto.Name == restaurant.Name);
            restaurantToModify.Summary = restaurant.Summary;
            restaurantToModify.Rating = restaurant.Rating;
            var result = XMLDataAccess.SaveToXML(rootElement);
            return new CompletedAsyncResult<bool>(result);
        }
        public bool EndSaveRestaurant(IAsyncResult r)
        {
            CompletedAsyncResult<bool> result = r as CompletedAsyncResult<bool>;
            return result.Data;
        } 
    }
}
