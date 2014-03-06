using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureTrackingToolExperiment.Interfaces;
using FeatureTrackingToolExperiment.Models;
using FeatureTrackingToolExperiment.Operations;
using FeatureTrackingToolExperiment.Repositories;
using NUnit.Framework;

namespace FeatureTrackingToolExperiment.Tests.Operations
{
    [TestFixture]
    public class OperationsTests
    {
        private FeatureOperations oper = new FeatureOperations();

        [Test]
        public void GetFeatureListReturnsList()
        {
            var featureList = oper.GetFeatureList();

            Assert.IsNotEmpty(featureList);
        }

        [Test]
        public void GetFeatureByIdReturnsCorrectFeature()
        {
            var id = 20;

            var feature = oper.GetFeatureById(id);

            Assert.AreEqual(id, feature.FeatureId);
        }

        [Test]
        public void AddFeatureToList()
        {
            var featureToBeAdded = new FeatureModel();

            var markets = new FeatureMarkets();

            var applications = new FeatureApplications();

            markets.FedCiv = true;
            markets.FedDOD = false;
            markets.Edu = true;
            markets.Corp = false;
            markets.Local = true;
            markets.ResellerIntegratorConsultant = false;

            applications.TransMgmt = true;
            applications.SecAndPubSafety = false;
            applications.CollabConfPresent = true;
            applications.CommandAndControl = false;
            applications.AdvVisualization = true;
            applications.BrandMgmt = false;
            applications.BroadcastOper = true;
            applications.DigitalSignage = false;
            applications.NetworkOper = true;
            applications.ProcessControl = false;

            featureToBeAdded.FeatureId = 0;
            featureToBeAdded.FeatureTitle = "Test Things";
            featureToBeAdded.FeaturePriority = 10;
            featureToBeAdded.FeatureDescription = "This is a test.  This is ONLY a test.";
            featureToBeAdded.FeatureNotes = "No notes yet.";
            featureToBeAdded.EstimatedPrice = 5000M;
            featureToBeAdded.EstimatedAnnualUnitSale = 5000;
            featureToBeAdded.EstimatedDaysToReleaseMVP = 5;
            featureToBeAdded.ActualDaysToReleaseMVP = null;
            featureToBeAdded.Classification = "Story";
            featureToBeAdded.FeatureEnteredBy = "Anna";
            featureToBeAdded.IsUrgentForProject = false;
            featureToBeAdded.Markets = markets;
            featureToBeAdded.Applications = applications;
            featureToBeAdded.RankDM = 10;
            featureToBeAdded.RankDB = 9;
            featureToBeAdded.RankRK = 8;
            featureToBeAdded.CompetitorsHaveFeature = true;

            oper.AddFeatureToList(featureToBeAdded);
        }

        [Test]
        public void EditFeature()
        {
            var featureToBeEdited = new FeatureModel();

            var markets = new FeatureMarkets();

            var applications = new FeatureApplications();

            markets.FedCiv = true;
            markets.FedDOD = false;
            markets.Edu = true;
            markets.Corp = false;
            markets.Local = true;
            markets.ResellerIntegratorConsultant = false;

            applications.TransMgmt = true;
            applications.SecAndPubSafety = false;
            applications.CollabConfPresent = true;
            applications.CommandAndControl = false;
            applications.AdvVisualization = true;
            applications.BrandMgmt = false;
            applications.BroadcastOper = true;
            applications.DigitalSignage = false;
            applications.NetworkOper = true;
            applications.ProcessControl = false;

            featureToBeEdited.FeatureId = 0;
            featureToBeEdited.FeatureTitle = "Test Things";
            featureToBeEdited.FeaturePriority = 10;
            featureToBeEdited.FeatureDescription = "This is a test.  This is ONLY a test.";
            featureToBeEdited.FeatureNotes = "No notes yet.";
            featureToBeEdited.EstimatedPrice = 5000M;
            featureToBeEdited.EstimatedAnnualUnitSale = 5000;
            featureToBeEdited.EstimatedDaysToReleaseMVP = 5;
            featureToBeEdited.ActualDaysToReleaseMVP = null;
            featureToBeEdited.Classification = "Story";
            featureToBeEdited.FeatureEnteredBy = "Anna";
            featureToBeEdited.IsUrgentForProject = false;
            featureToBeEdited.Markets = markets;
            featureToBeEdited.Applications = applications;
            featureToBeEdited.RankDM = 10;
            featureToBeEdited.RankDB = 9;
            featureToBeEdited.RankRK = 8;
            featureToBeEdited.CompetitorsHaveFeature = true;

            oper.AddFeatureToList(featureToBeEdited);
        }
    }
}