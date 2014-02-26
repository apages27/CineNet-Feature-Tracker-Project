using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeatureTrackingToolExperiment.Models
{
    public class FeatureMarkets
    {
        public bool FedCiv { get; set; }
        public bool FedDOD { get; set; }
        public bool Local { get; set; }
        public bool Edu { get; set; }
        public bool Corp { get; set; }
        public bool ResellerIntegratorConsultant { get; set; }
    }
}