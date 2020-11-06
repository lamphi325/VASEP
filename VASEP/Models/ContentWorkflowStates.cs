﻿using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ContentWorkflowStates
    {
        public ContentWorkflowStates()
        {
            ContentItems = new HashSet<ContentItems>();
            ContentWorkflowStatePermission = new HashSet<ContentWorkflowStatePermission>();
        }

        public int StateId { get; set; }
        public int WorkflowId { get; set; }
        public string StateName { get; set; }
        public int Order { get; set; }
        public bool? IsActive { get; set; }
        public bool SendEmail { get; set; }
        public bool SendMessage { get; set; }
        public bool IsDisposalState { get; set; }
        public string OnCompleteMessageSubject { get; set; }
        public string OnCompleteMessageBody { get; set; }
        public string OnDiscardMessageSubject { get; set; }
        public string OnDiscardMessageBody { get; set; }
        public bool IsSystem { get; set; }
        public bool? SendNotification { get; set; }
        public bool? SendNotificationToAdministrators { get; set; }

        public ContentWorkflows Workflow { get; set; }
        public ICollection<ContentItems> ContentItems { get; set; }
        public ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; set; }
    }
}
