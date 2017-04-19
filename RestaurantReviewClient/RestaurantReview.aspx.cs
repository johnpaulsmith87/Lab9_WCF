using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestaurantReviewClient.RestaurantReviewReference;

namespace RestaurantReviewClient
{
    public partial class RestaurantReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(LoadPageData));
        }
        private async Task LoadPageData()
        {
            if (!IsPostBack)
            {
                var reviewer = new RestaurantReviewServiceClient();
                var names = await reviewer.GetRestaurantNamesAsync();
                ddlSelectRestaurant.DataSource = names;
                ddlSelectRestaurant.DataBind();
                ddlSelectRestaurant.Items.Insert(0, new ListItem(" -- Select One -- ", "-1"));
                pnlRestaurantDetails.Visible = false;
            }
        }
        protected void ddlSelectRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(LoadRestaurantDetails));
        }
        private async Task LoadRestaurantDetails()
        {
            if (ddlSelectRestaurant.SelectedValue != "-1")
            {
                var reviewer = new RestaurantReviewServiceClient();
                var restaurant = await reviewer.GetRestaurantByNameAsync(ddlSelectRestaurant.SelectedValue);
                txtAddress.Text = restaurant.Location.Street + " " + restaurant.Location.City + " " + restaurant.Location.PostalCode;
                txtSummary.Text = restaurant.Summary;
                ddlRating.ClearSelection();
                ddlRating.SelectedIndex = restaurant.Rating - 1;
                pnlRestaurantDetails.Visible = true;
                pnlSave.Visible = false;
            }
            else
            {
                pnlRestaurantDetails.Visible = false;
                pnlSave.Visible = false;
            }
        }
        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(LoadSaveChanges));
        }
        private async Task LoadSaveChanges()
        {
            if (ddlSelectRestaurant.SelectedValue != "-1")
            {
                var reviewer = new RestaurantReviewServiceClient();
                var restaurant = new RestaurantInfo()
                {
                    Name = ddlSelectRestaurant.SelectedValue,
                    Summary = txtSummary.Text,
                    Rating = int.Parse(ddlRating.SelectedValue)
                };
                if(await reviewer.SaveRestaurantAsync(restaurant))
                {
                    lblResult.Text = "Successfully saved restaurant";
                    lblResult.CssClass = "bg-success";
                }
                else
                {
                    lblResult.Text = "Error saving restaurant;";
                    lblResult.CssClass = "bg-danger";
                }
                pnlSave.Visible = true;
            }
        }

       
    }
}