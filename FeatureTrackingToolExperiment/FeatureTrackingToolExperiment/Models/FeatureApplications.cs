using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeatureTrackingToolExperiment.Models
{
    public class FeatureApplications
    {
        public bool TransMgmt { get; set; }
        public bool SecAndPubSafety { get; set; }
        public bool ProcessControl { get; set; }
        public bool CollabConfPresent { get; set; }
        public bool CommandAndControl { get; set; }
        public bool DigitalSignage { get; set; }
        public bool BrandMgmt { get; set; }
        public bool AdvVisualization { get; set; }
        public bool BroadcastOper { get; set; }
        public bool NetworkOper { get; set; }
    }
}