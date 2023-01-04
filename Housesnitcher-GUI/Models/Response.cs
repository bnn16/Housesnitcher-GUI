namespace Housesnitcher_GUI.Models
{
    public class Response
    {
        public string Status { get; set; }
        public bool Auth { get; set; }
        public ScopeLevel Scope { get; set; }
    }
}