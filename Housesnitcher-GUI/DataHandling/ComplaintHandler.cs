using Housesnitcher_GUI.DataStorageAbstractions;
using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.DataHandling
{
    public static class ComplaintHandler
    {
        public static Complaint? LodgeComplaint(Complaint complaint)
        {
            // membership check, we dont like duplicates
            if (ComplaintStore.Complaints.Contains(complaint))
            {
                return null;
            }
            ComplaintStore.Complaints.Add(complaint);
            return complaint;
        }
        public static Complaint? AcknowledgeComplaint(Complaint complaint)
        {
            if (complaint.Status != ComplaintStatus.Created)
            {
                return null;
            }
            return BumpStatus(complaint);
        }
        // you want to definitely update the form after using this method.
        public static Complaint? ReviewComplaint(Complaint complaint, string feedback)
        {
            if (complaint.Status != ComplaintStatus.Acknowledged)
            {
                return null;
            }
            complaint.ComplaintFeedback = feedback;
            return BumpStatus(complaint);
        }
        public static Complaint? ResolveComplaint(Complaint complaint)
        {
            if (complaint.Status != ComplaintStatus.Reviewed)
            {
                return null;
            }
            return BumpStatus(complaint);
        }
        // complaint is trash, spam, doesn't conform to the guidelines, or whatever.
        public static Complaint? FailComplaint(Complaint complaint)
        {
            var idx = ComplaintStore.Complaints.FindIndex(x => x == complaint);
            ComplaintStore.Complaints[idx].Status = ComplaintStatus.Failed;
            return ComplaintStore.Complaints[idx];
        }
        private static Complaint? BumpStatus(Complaint complaint)
        {
            var idx = ComplaintStore.Complaints.FindIndex(x => x == complaint);
            ComplaintStore.Complaints[idx].Status++;
            return ComplaintStore.Complaints[idx];
        }

        public static List<Complaint> AllComplaints()
        {
            return ComplaintStore.Complaints;
        }
    }
}
