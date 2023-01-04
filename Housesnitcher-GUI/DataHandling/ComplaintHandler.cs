using Housesnitcher_GUI.Models;
using Housesnitcher_GUI.DataStorageAbstractions;
using Housesnitcher_GUI.StateManagement;

namespace Housesnitcher_GUI.DataHandling
{
    public static class ComplaintHandler
    {
        public static bool LodgeComplaint(Complaint complaint)
        {
            // membership check, we dont like duplicates
            if (ComplaintStore.Complaints.Contains(complaint))
            {
                return false;
            }
            ComplaintStore.Complaints.Add(complaint);
            return true;
        }
        public static bool AcknowledgeComplaint(Complaint complaint)
        {
            if (complaint.Status != ComplaintStatus.Created)
            {
                return false;
            }
            BumpStatus(complaint);
            return true;
        }
        // you want to definitely update the form after using this method.
        public static bool ReviewComplaint(Complaint complaint, string feedback)
        {
            if (complaint.Status != ComplaintStatus.Acknowledged)
            {
                return false;
            }
            complaint.ComplaintFeedback = feedback;
            BumpStatus(complaint);
            return true;
        }
        public static bool ResolveComplaint(Complaint complaint)
        {
            if (complaint.Status != ComplaintStatus.Reviewed)
            {
                return false;
            }
            BumpStatus(complaint);
            return true;
        }
        // complaint is trash, spam, doesn't conform to the guidelines, or whatever.
        public static void FailComplaint(Complaint complaint)
        {
            var idx = ComplaintStore.Complaints.FindIndex(x => x == complaint);
            ComplaintStore.Complaints[idx].Status = ComplaintStatus.Failed;
        }
        private static void BumpStatus(Complaint complaint)
        {
            var idx = ComplaintStore.Complaints.FindIndex(x => x == complaint);
            ComplaintStore.Complaints[idx].Status++;
        }
    }
}
