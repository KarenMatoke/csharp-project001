public partial class Login : System.Web.UI.Page
{
    ...
    protected void buttonLogin_Click(object sender, EventArgs e)
    {
        Response.AppendToLog($"Authenticating User '{UserName.Text}'");
        if (PerformAuthentication(UserName.Text, Password.Text))
        {
            Response.AppendToLog("User logged in.");
            Response.Redirect("Index.aspx");
        }
        else
        {
            errorMessage.Text = "Unable to authenticate based on given credentials.";
            Response.AppendToLog("Unable to authenticate user.");
        }
    }
    ...
}
