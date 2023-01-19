namespace Housesnitcher_GUI.GUI.Events
{
    public class ForceRefreshEvent
    {
        public static event EventHandler RefreshNeeded;
        public static void RaiseRefreshEvent(object sender, EventArgs args)
        {
            var handler = RefreshNeeded;
            if (handler != null)
            {
                handler(sender, args);
            }
        }
    }
}
