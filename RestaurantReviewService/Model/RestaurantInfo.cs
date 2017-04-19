using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestaurantReviewService
{
    [DataContract]
    public class RestaurantInfo : IRestaurantInfo
    {

        public RestaurantInfo()
        {
            //Default constructor for Serialization/Deserialization
        }
        public RestaurantInfo(RestaurantsRestaurant restaurant)
        {
            Rating = restaurant.Rating;
            Name = restaurant.Name;
            Summary = restaurant.Summary;
            Location = new Address()
            {
                Street = restaurant.RestaurantAddress.Address,
                City = restaurant.RestaurantAddress.City,
                PostalCode = restaurant.RestaurantAddress.PostalCode,
                Province = Enum.GetName(typeof(ProvinceType), restaurant.RestaurantAddress.Province)
            };
        }
        [DataMember]
        public int Rating { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Summary { get; set; }
        [DataMember]
        public Address Location { get; set; }
    }
    [DataContract]
    public class Address : IAddress
    {
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string Province { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string City { get; set; }
    }
}