AuthenticateResponse responseBack = new();
using (HelperPPAPI helper = new(_jwtTokenIssuerSettings, _logger, string.Empty))
{
     responseBack = await helper.RegisterAsync(model.Email, model.Password, HttpContext.Session.GetString("ident"));
}
