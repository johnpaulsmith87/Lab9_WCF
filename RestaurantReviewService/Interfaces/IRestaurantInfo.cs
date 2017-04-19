namespace RestaurantReviewService
{
    public interface IRestaurantInfo
    {
        int Rating { get; set; }
        string Name { get; set; }
        string Summary { get; set; }
        IAddress Location { get; set; }
    }

    public interface IAddress
    {
        string Street { get; set; }
        string Province { get; set; }
        string PostalCode { get; set; }
        string City { get; set; }
    }
}
