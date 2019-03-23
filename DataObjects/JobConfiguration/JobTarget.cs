﻿using System;

namespace AppDynamics.Dexter
{
    public class JobTarget
    {
        public string Controller { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Application { get; set; }
        public long ApplicationID { get; set; }
        public long DBCollectorID { get; set; }
        public long ParentApplicationID { get; set; }
        public bool NameRegex { get; set; }
        public string Type { get; set; }

        public JobTarget Clone()
        {
            return (JobTarget)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return String.Format("JobTarget: {0}/{1}({2})[{3}]", this.Controller, this.Application, this.ApplicationID, this.Type);
        }
    }
}
