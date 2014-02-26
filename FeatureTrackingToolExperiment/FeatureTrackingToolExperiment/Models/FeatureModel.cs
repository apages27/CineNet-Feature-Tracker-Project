using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeatureTrackingToolExperiment.Models
{
    public class FeatureModel
    {
        public int FeatureId { get; set; }
        public string FeatureTitle { get; set; }
        public int FeaturePriority { get; set; }
        public string FeatureDescription { get; set; }
        public string FeatureNotes { get; set; }
        public decimal? EstimatedPrice { get; set; }
        public int? EstimatedAnnualUnitSale { get; set; }
        public int? EstimatedDaysToReleaseMVP { get; set; }
        public int? ActualDaysToReleaseMVP { get; set; }
        public string Classification { get; set; }
        public string FeatureEnteredBy { get; set; }
        public bool IsUrgentForProject { get; set; }
        public FeatureMarkets Markets { get; set; }
        public FeatureApplications Applications { get; set; }
        public int? RankDM { get; set; }
        public int? RankDB { get; set; }
        public int? RankRK { get; set; }
        public bool CompetitorsHaveFeature { get; set; }
    }
}