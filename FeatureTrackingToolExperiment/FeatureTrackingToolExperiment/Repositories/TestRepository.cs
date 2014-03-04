using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Antlr.Runtime.Tree;
using FeatureTrackingToolExperiment.Interfaces;
using FeatureTrackingToolExperiment.Models;

namespace FeatureTrackingToolExperiment.Repositories
{
    public class TestRepository : IFeatureRepository
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
        
        public FeatureModel GetFeatureById(int id)
        {
            var list = GetFeatureList();

            foreach (var featureModel in list) if (featureModel.FeatureId == id) return featureModel;

            return null;
        }

        public void AddNewFeature(FeatureModel newFeature)
        {
            var list = GetFeatureList();

            var usedIdList = new List<int>();

            var featureToBeAdded = new FeatureModel();

            var markets3 = new FeatureMarkets();

            var applications3 = new FeatureApplications();

            foreach (var featureModel in list) usedIdList.Add(featureModel.FeatureId);
            
            markets3.FedCiv = newFeature.Markets.FedCiv;
            markets3.FedDOD = newFeature.Markets.FedDOD;
            markets3.Edu = newFeature.Markets.Edu;
            markets3.Corp = newFeature.Markets.Corp;
            markets3.Local = newFeature.Markets.Local;
            markets3.ResellerIntegratorConsultant = newFeature.Markets.ResellerIntegratorConsultant;

            applications3.TransMgmt = newFeature.Applications.TransMgmt;
            applications3.SecAndPubSafety = newFeature.Applications.SecAndPubSafety;
            applications3.CollabConfPresent = newFeature.Applications.CollabConfPresent;
            applications3.CommandAndControl = newFeature.Applications.CommandAndControl;
            applications3.AdvVisualization = newFeature.Applications.AdvVisualization;
            applications3.BrandMgmt = newFeature.Applications.BrandMgmt;
            applications3.BroadcastOper = newFeature.Applications.BroadcastOper;
            applications3.DigitalSignage = newFeature.Applications.DigitalSignage;
            applications3.NetworkOper = newFeature.Applications.NetworkOper;
            applications3.ProcessControl = newFeature.Applications.ProcessControl;

            featureToBeAdded.FeatureId = usedIdList.Last() + 1;
            featureToBeAdded.FeatureTitle = newFeature.FeatureTitle;
            featureToBeAdded.FeaturePriority = newFeature.FeaturePriority;
            featureToBeAdded.FeatureDescription = newFeature.FeatureDescription;
            featureToBeAdded.FeatureNotes = newFeature.FeatureNotes;
            featureToBeAdded.EstimatedPrice = newFeature.EstimatedPrice;
            featureToBeAdded.EstimatedAnnualUnitSale = newFeature.EstimatedAnnualUnitSale;
            featureToBeAdded.EstimatedDaysToReleaseMVP = newFeature.EstimatedDaysToReleaseMVP;
            featureToBeAdded.ActualDaysToReleaseMVP = newFeature.ActualDaysToReleaseMVP;
            featureToBeAdded.Classification = newFeature.Classification;
            featureToBeAdded.FeatureEnteredBy = newFeature.FeatureEnteredBy;
            featureToBeAdded.IsUrgentForProject = newFeature.IsUrgentForProject;
            featureToBeAdded.Markets = markets3;
            featureToBeAdded.Applications = applications3;
            featureToBeAdded.RankDM = newFeature.RankDM;
            featureToBeAdded.RankDB = newFeature.RankDB;
            featureToBeAdded.RankRK = newFeature.RankRK;
            featureToBeAdded.CompetitorsHaveFeature = newFeature.CompetitorsHaveFeature;

            list.Add(featureToBeAdded);
        }

        public void EditFeature(FeatureModel editedFeature)
        {
            var featureToBeEdited = GetFeatureById(editedFeature.FeatureId);

            var markets4 = new FeatureMarkets();

            var applications4 = new FeatureApplications();

            //markets4.FedCiv = editedFeature.Markets.FedCiv;
            //markets4.FedDOD = editedFeature.Markets.FedDOD;
            //markets4.Edu = editedFeature.Markets.Edu;
            //markets4.Corp = editedFeature.Markets.Corp;
            //markets4.Local = editedFeature.Markets.Local;
            //markets4.ResellerIntegratorConsultant = editedFeature.Markets.ResellerIntegratorConsultant;

            //applications4.TransMgmt =   editedFeature.Applications.TransMgmt;
            //applications4.SecAndPubSafety = editedFeature.Applications.SecAndPubSafety;
            //applications4.CollabConfPresent = editedFeature.Applications.CollabConfPresent;
            //applications4.CommandAndControl = editedFeature.Applications.CommandAndControl;
            //applications4.AdvVisualization = editedFeature.Applications.AdvVisualization;
            //applications4.BrandMgmt = editedFeature.Applications.BrandMgmt;
            //applications4.BroadcastOper = editedFeature.Applications.BroadcastOper;
            //applications4.DigitalSignage = editedFeature.Applications.DigitalSignage;
            //applications4.NetworkOper = editedFeature.Applications.NetworkOper;
            //applications4.ProcessControl = editedFeature.Applications.ProcessControl;

            featureToBeEdited.FeatureId = editedFeature.FeatureId;
            featureToBeEdited.FeatureTitle = editedFeature.FeatureTitle;
            featureToBeEdited.FeaturePriority = editedFeature.FeaturePriority;
            featureToBeEdited.FeatureDescription = editedFeature.FeatureDescription;
            featureToBeEdited.FeatureNotes = editedFeature.FeatureNotes;
            featureToBeEdited.EstimatedPrice = editedFeature.EstimatedPrice;
            featureToBeEdited.EstimatedAnnualUnitSale = editedFeature.EstimatedAnnualUnitSale;
            featureToBeEdited.EstimatedDaysToReleaseMVP = editedFeature.EstimatedDaysToReleaseMVP;
            featureToBeEdited.ActualDaysToReleaseMVP = editedFeature.ActualDaysToReleaseMVP;
            featureToBeEdited.Classification = editedFeature.Classification;
            featureToBeEdited.FeatureEnteredBy = editedFeature.FeatureEnteredBy;
            featureToBeEdited.IsUrgentForProject = editedFeature.IsUrgentForProject;
            featureToBeEdited.Markets = markets4;
            featureToBeEdited.Applications = applications4;
            featureToBeEdited.RankDM = editedFeature.RankDM;
            featureToBeEdited.RankDB = editedFeature.RankDB;
            featureToBeEdited.RankRK = editedFeature.RankRK;
            featureToBeEdited.CompetitorsHaveFeature = editedFeature.CompetitorsHaveFeature;
        }

        public void DeleteFeature(int id)
        {
            var list = GetFeatureList();
            
            var featureToBeDeleted = GetFeatureById(id);

            list.Remove(featureToBeDeleted);
        }
    }
}