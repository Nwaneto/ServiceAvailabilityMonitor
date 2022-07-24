using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceMonitor.Core.Domain.DataContracts
{
    public class AvailableServices
    {
        public short? ID { get; set; }
        public short? ServiceCategoryID { get; set; }
        public string ServiceName { get; set; }
    }
}
