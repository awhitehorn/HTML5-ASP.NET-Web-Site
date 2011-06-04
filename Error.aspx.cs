using System;
using System.Web.UI;

public partial class Error : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(Request.QueryString["code"]))
        {
            switch (Request.QueryString["code"])
            {
                case "401":
                case "403":
                    lblError.Text = "The request has been denied. Authorization is required to access to the requested resource.";
                    lblTitle.Text = "Access Denied";
                    Page.Title = "Access Denied";
                    Response.StatusCode = 403;
                    break;
                case "404":
                    lblError.Text = "The requested page or resource was not able to be located.";
                    lblTitle.Text = "Page Not Found";
                    Page.Title = "Page Not Found";
                    Response.StatusCode = 404;
                    break;
                case "408":
                    lblError.Text = "The request timed out. This may be caused by a high traffic load or server problems. Please try again later.";
                    lblTitle.Text = "Request Timeout";
                    Page.Title = "Request Timeout";
                    Response.StatusCode = 408;
                    break;
                case "500":
                    lblError.Text = "The server encountered an unexpected condition which prevented it from fulfilling the request. Please try again later.";
                    lblTitle.Text = "Internal Server Error";
                    Page.Title = "Server Error";
                    Response.StatusCode = 500;
                    break;
                default:
                    break;
            }
        }
        else
            Page.Title = "Unexpected Error";
    }
}