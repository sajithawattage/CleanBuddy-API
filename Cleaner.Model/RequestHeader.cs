﻿using System;
using System.Collections.Generic;

namespace Cleaner.Model
{
    public class RequestHeader : BaseModel
    {
        public int RequestID { get; set; }
        public int GroupID { get; set; }
        public int EmployeeID { get; set; }
        public int JobID { get; set; }
        public DateTime RequestDateTime { get; set; }
        public int ApproveGroupID { get; set; }
        public string ApproveStatus { get; set; }
        public DateTime ApprovedDateTime { get; set; }
    }
    public class RequestHeaderList : List<RequestHeader> { }
}
