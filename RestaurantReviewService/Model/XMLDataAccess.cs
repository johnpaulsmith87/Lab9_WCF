using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace RestaurantReviewService
{
    /// <summary>
    /// Generic XML data access for 
    /// </summary>
    public static class XMLDataAccess
    {
        /// <summary>
        /// Ugly... but not much I can do.
        /// </summary>
        private const string RESTAURANTXMLPATH = "restaurant_reviews.xml";
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">POCO for XML Schema</typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T GetXMLRootElement<T>(string path = RESTAURANTXMLPATH)
        {
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
            using (var fs = new FileStream(path, FileMode.Open))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(fs);
            }
        }
        /// <summary>
        /// Save To XML file
        /// </summary>
        /// <typeparam name="T">POCO for XML Schema</typeparam>
        /// <param name="XMLRootElement"></param>
        /// <param name="path"></param>
        /// <returns>True if successful, false if failed</returns>
        public static bool SaveToXML<T>(T XMLRootElement, string path = RESTAURANTXMLPATH)
        {
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
            var result = false;
            try
            {
                using (var fs = new FileStream(path, FileMode.Create))
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(fs, XMLRootElement);
                    result = true;
                }
            }
            catch
            {
                // to make sure it's caught is all
            }
            return result;
        }
    }
}