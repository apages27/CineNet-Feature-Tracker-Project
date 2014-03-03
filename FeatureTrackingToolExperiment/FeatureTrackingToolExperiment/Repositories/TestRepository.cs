using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Antlr.Runtime.Tree;
using FeatureTrackingToolExperiment.Models;

namespace FeatureTrackingToolExperiment.Repositories
{
    public class TestRepository
    {
        public List<FeatureModel> GetFeatureList()
        {
            List<FeatureModel> features = new List<FeatureModel>();

            FeatureModel testFeature1 = new FeatureModel();

            FeatureMarkets markets1 = new FeatureMarkets();

            FeatureApplications applications1 = new FeatureApplications();

            markets1.FedCiv = true;
            markets1.FedDOD = true;
            markets1.Edu = true;
            markets1.Corp = true;
            markets1.Local = false;
            markets1.ResellerIntegratorConsultant = false;

            applications1.TransMgmt = true;
            applications1.SecAndPubSafety = true;
            applications1.CollabConfPresent = true;
            applications1.CommandAndControl = true;
            applications1.AdvVisualization = false;
            applications1.BrandMgmt = false;
            applications1.BroadcastOper = false;
            applications1.DigitalSignage = false;
            applications1.NetworkOper = false;
            applications1.ProcessControl = false;

            testFeature1.FeatureId = 20;
            testFeature1.FeatureTitle = "Teleportation";
            testFeature1.FeaturePriority = 1;
            testFeature1.FeatureDescription = "Enables users to instantly transport to the location of any alpha.";
            testFeature1.FeatureNotes = "";
            testFeature1.EstimatedPrice = 10000000.00M;
            testFeature1.EstimatedAnnualUnitSale = 10000000;
            testFeature1.EstimatedDaysToReleaseMVP = 30;
            testFeature1.ActualDaysToReleaseMVP = null;
            testFeature1.Classification = "Epic Story";
            testFeature1.FeatureEnteredBy = "Anna";
            testFeature1.IsUrgentForProject = true;
            testFeature1.Markets = markets1;
            testFeature1.Applications = applications1;
            testFeature1.RankDM = 1;
            testFeature1.RankDB = 4;
            testFeature1.RankRK = 6;
            testFeature1.CompetitorsHaveFeature = false;

            features.Add(testFeature1);

            FeatureModel testFeature2 = new FeatureModel();

            FeatureMarkets markets2 = new FeatureMarkets();

            FeatureApplications applications2 = new FeatureApplications();

            markets2.FedCiv = true;
            markets2.FedDOD = true;
            markets2.Edu = false;
            markets2.Corp = true;
            markets2.Local = true;
            markets2.ResellerIntegratorConsultant = false;

            applications2.TransMgmt = false;
            applications2.SecAndPubSafety = false;
            applications2.CollabConfPresent = true;
            applications2.CommandAndControl = true;
            applications2.AdvVisualization = true;
            applications2.BrandMgmt = true;
            applications2.BroadcastOper = false;
            applications2.DigitalSignage = false;
            applications2.NetworkOper = false;
            applications2.ProcessControl = false;

            testFeature2.FeatureId = 13;
            testFeature2.FeatureTitle = "Food Replication";
            testFeature2.FeaturePriority = 2;
            testFeature2.FeatureDescription = "Enables users to replicate the food of their choice.";
            testFeature2.FeatureNotes = "";
            testFeature2.EstimatedPrice = 5000000.00M;
            testFeature2.EstimatedAnnualUnitSale = 5000000;
            testFeature2.EstimatedDaysToReleaseMVP = 60;
            testFeature2.ActualDaysToReleaseMVP = null;
            testFeature2.Classification = "Epic Story";
            testFeature2.FeatureEnteredBy = "Anna";
            testFeature2.IsUrgentForProject = true;
            testFeature2.Markets = markets2;
            testFeature2.Applications = applications2;
            testFeature2.RankDM = 10;
            testFeature2.RankDB = 2;
            testFeature2.RankRK = 4;
            testFeature2.CompetitorsHaveFeature = false;

            features.Add(testFeature2);

            return features;
        } 


    }
}