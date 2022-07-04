public async (Task<AuthenticateResponse> RegisterAsynch(string email, string password, string ident) 
{
string sendEmail = email.ToSafeString();
_logger.LogInformation($"Attempting registration for user {sendEmail}");
AuthenticateResponse result = new();
APIClient.RegisterRequest request = new()
{
Email = email,
Password = password,
Ident= ident
};
try
{
result = await apiClient.RegisterAsync(request);
}
catch { }
if (result != null && !string.IsNullOrEmpty(result.Token))
_logger.LogInformation($"Attempted registration for user {sendEmail} SUCCESSFUL")
else
{};
}
