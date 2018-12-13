using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Runtime.Serialization;
//using System.Windows.Media;
using System.Linq;

namespace DevExpress.DevAV {
    public enum EmployeeTaskStatus {
        [Display(Name = "Not Started")]
        NotStarted,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "In Progress")]
        InProgress,
        [Display(Name = "Need Assistance")]
        NeedAssistance,
        [Display(Name = "Deferred")]
        Deferred
    }
    public enum EmployeeTaskPriority {
        Low,
        Normal,
        High,
        Urgent
    }
    public enum EmployeeTaskFollowUp {
        [Display(Name = "Today")]
        Today,
        [Display(Name = "Tomorrow")]
        Tomorrow,
        [Display(Name = "This Week")]
        ThisWeek,
        [Display(Name = "Next Week")]
        NextWeek,
        [Display(Name = "No Date")]
        NoDate,
        [Display(Name = "Custom")]
        Custom
    }

    public class EmployeeTask : DatabaseObject {
        public EmployeeTask() {
            AssignedEmployees = new List<Employee>();
        }
        public virtual List<Employee> AssignedEmployees { get; set; }
        [Required]
        public string Subject { get; set; }
        public string Description { get; set; }
        public string RtfTextDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public EmployeeTaskStatus Status { get; set; }
        public EmployeeTaskPriority Priority { get; set; }
        public int Completion { get; set; }
        public bool Reminder { get; set; }
        public DateTime? ReminderDateTime { get; set; }
        public virtual Employee AssignedEmployee { get; set; }
        public long? AssignedEmployeeId { get; set; }
        public virtual Employee Owner { get; set; }
        public long? OwnerId { get; set; }
        public virtual CustomerEmployee CustomerEmployee { get; set; }
        public long? CustomerEmployeeId { get; set; }
        public EmployeeTaskFollowUp FollowUp { get; set; }
        public bool Private { get; set; }
        public string Category { get; set; }
        public virtual List<TaskAttachedFile> AttachedFiles { get; set; }
        public bool AttachedCollectionsChanged { get; set; }

        public override string ToString() {
            return string.Format("{0} - {1}, due {2}, {3},\r\nOwner: {4}", Subject, Description, DueDate, Status, Owner);
        }
        public bool Overdue {
            get {
                if(Status == EmployeeTaskStatus.Completed || !DueDate.HasValue) return false;
                DateTime dDate = DueDate.Value.Date.AddDays(1);
                if(DateTime.Now >= dDate) return true;
                return false;
            }
        }
        public int AttachedFilesCount {
            get {
                return (AttachedFiles == null) ? 0 : AttachedFiles.Count;
            }
        }
        public string AssignedEmployeesFullList {
            get {
                if(AssignedEmployees == null)
                    return "";
                return string.Join(", ", AssignedEmployees.Select(x => x.FullName));
            }
        }
    }
}
