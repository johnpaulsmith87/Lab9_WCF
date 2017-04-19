﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/onlineservice/reviews")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/onlineservice/reviews", IsNullable=false)]
public partial class Restaurants {
    
    private RestaurantsRestaurant[] restaurantField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Restaurant")]
    public RestaurantsRestaurant[] Restaurant {
        get {
            return this.restaurantField;
        }
        set {
            this.restaurantField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/onlineservice/reviews")]
public partial class RestaurantsRestaurant {
    
    private string nameField;
    
    private string phoneNumberField;
    
    private AddressType restaurantAddressField;
    
    private RestaurantsRestaurantImage imageField;
    
    private string logoField;
    
    private System.DateTime dateField;
    
    private int ratingField;
    
    private string reviewerField;
    
    private string summaryField;
    
    private RestaurantsRestaurantMenu menuField;
    
    /// <remarks/>
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public string PhoneNumber {
        get {
            return this.phoneNumberField;
        }
        set {
            this.phoneNumberField = value;
        }
    }
    
    /// <remarks/>
    public AddressType RestaurantAddress {
        get {
            return this.restaurantAddressField;
        }
        set {
            this.restaurantAddressField = value;
        }
    }
    
    /// <remarks/>
    public RestaurantsRestaurantImage Image {
        get {
            return this.imageField;
        }
        set {
            this.imageField = value;
        }
    }
    
    /// <remarks/>
    public string Logo {
        get {
            return this.logoField;
        }
        set {
            this.logoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime Date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    public int Rating {
        get {
            return this.ratingField;
        }
        set {
            this.ratingField = value;
        }
    }
    
    /// <remarks/>
    public string Reviewer {
        get {
            return this.reviewerField;
        }
        set {
            this.reviewerField = value;
        }
    }
    
    /// <remarks/>
    public string Summary {
        get {
            return this.summaryField;
        }
        set {
            this.summaryField = value;
        }
    }
    
    /// <remarks/>
    public RestaurantsRestaurantMenu Menu {
        get {
            return this.menuField;
        }
        set {
            this.menuField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/onlineservice/reviews")]
public partial class AddressType {
    
    private string addressField;
    
    private string cityField;
    
    private ProvinceType provinceField;
    
    private string postalCodeField;
    
    /// <remarks/>
    public string Address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    public string City {
        get {
            return this.cityField;
        }
        set {
            this.cityField = value;
        }
    }
    
    /// <remarks/>
    public ProvinceType Province {
        get {
            return this.provinceField;
        }
        set {
            this.provinceField = value;
        }
    }
    
    /// <remarks/>
    public string PostalCode {
        get {
            return this.postalCodeField;
        }
        set {
            this.postalCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/onlineservice/reviews")]
public enum ProvinceType {
    
    /// <remarks/>
    Ontario,
    
    /// <remarks/>
    Quebec,
    
    /// <remarks/>
    Manitoba,
    
    /// <remarks/>
    Alberta,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/onlineservice/reviews")]
public partial class FoodItem {
    
    private string itemDescriptionField;
    
    private decimal itemPriceField;
    
    private int piecesPerOrderField;
    
    private bool piecesPerOrderFieldSpecified;
    
    private decimal pricePerPieceField;
    
    private bool pricePerPieceFieldSpecified;
    
    /// <remarks/>
    public string ItemDescription {
        get {
            return this.itemDescriptionField;
        }
        set {
            this.itemDescriptionField = value;
        }
    }
    
    /// <remarks/>
    public decimal ItemPrice {
        get {
            return this.itemPriceField;
        }
        set {
            this.itemPriceField = value;
        }
    }
    
    /// <remarks/>
    public int PiecesPerOrder {
        get {
            return this.piecesPerOrderField;
        }
        set {
            this.piecesPerOrderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PiecesPerOrderSpecified {
        get {
            return this.piecesPerOrderFieldSpecified;
        }
        set {
            this.piecesPerOrderFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal PricePerPiece {
        get {
            return this.pricePerPieceField;
        }
        set {
            this.pricePerPieceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PricePerPieceSpecified {
        get {
            return this.pricePerPieceFieldSpecified;
        }
        set {
            this.pricePerPieceFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/onlineservice/reviews")]
public partial class RestaurantsRestaurantImage {
    
    private string imagePathField;
    
    private string imageDimensionsField;
    
    /// <remarks/>
    public string ImagePath {
        get {
            return this.imagePathField;
        }
        set {
            this.imagePathField = value;
        }
    }
    
    /// <remarks/>
    public string ImageDimensions {
        get {
            return this.imageDimensionsField;
        }
        set {
            this.imageDimensionsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/onlineservice/reviews")]
public partial class RestaurantsRestaurantMenu {
    
    private FoodItem[] appetizersField;
    
    private FoodItem[] entreesField;
    
    private FoodItem[] dessertsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("AppetizerFoodItem", IsNullable=false)]
    public FoodItem[] Appetizers {
        get {
            return this.appetizersField;
        }
        set {
            this.appetizersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("EntreeFoodItem", IsNullable=false)]
    public FoodItem[] Entrees {
        get {
            return this.entreesField;
        }
        set {
            this.entreesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("DessertFoodItem", IsNullable=false)]
    public FoodItem[] Desserts {
        get {
            return this.dessertsField;
        }
        set {
            this.dessertsField = value;
        }
    }
}
