using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantReviewService.Utility
{
    public static class Utility
    {
        public static Dictionary<string, ProvinceType> StringToProvinceType = new Dictionary<string, ProvinceType>()
        {
            {"Ontario", ProvinceType.Ontario },
            {"British Columbia", ProvinceType.BritishColumbia },
            {"Quebec", ProvinceType.Quebec },
            {"Alberta", ProvinceType.Alberta},
            {"Nova Scotia", ProvinceType.NovaScotia }
        };
    }
}