namespace Housesnitcher_GUI.Models
{
    public class Response
    {
        public string Status { get; set; }
        public bool Auth { get; set; }
        public ScopeLevel Scope { get; set; }
        public Response(string status, bool auth, ScopeLevel scope)
        {
            Status = status;
            Auth = auth;
            Scope = scope;
        }
        public Response() { }
    }
}