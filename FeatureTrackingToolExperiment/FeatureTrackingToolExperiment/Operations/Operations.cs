using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Web;
using FeatureTrackingToolExperiment.Models;

namespace FeatureTrackingToolExperiment.Operations
{
    public class FeatureOperations
    {
        private string filePath = HttpContext.Current.Server.MapPath("~/Data/FeatureListFile.txt");

        public void AddFeatureToList(FeatureModel newFeature)
        {
            string featureString = "";

            if (File.Exists(filePath))
            {
                string[] featureList = GetFeatureList();
                List<int> existingIds = new List<int>();

                foreach (string s in featureList)
                {
                    string[] splitFeature = s.Split(',');

                    existingIds.Add(int.Parse(splitFeature[0]));
                }

                existingIds.Sort();
                int newId = existingIds.Last() + 1;

                filePath = newId + "," + newFeature.FeatureTitle + "," + newFeature.FeaturePriority + "," + newFeature.FeatureDescription + "," + newFeature.FeatureNotes + "," + 
                    newFeature.EstimatedPrice+ "," + newFeature.EstimatedAnnualUnitSale + "," + newFeature.EstimatedDaysToReleaseMVP + "," + newFeature.ActualDaysToReleaseMVP
                      + "," + newFeature.Classification + "," + newFeature.FeatureEnteredBy + "," + newFeature.IsUrgentForProject + "," + newFeature.Markets
                       + "," + newFeature.Applications + "," + newFeature.RankDM + "," + newFeature.RankDB + "," + newFeature.RankRK + "," + newFeature.CompetitorsHaveFeature;
            }
            else
            {
                filePath = "1" + "," + newFeature.FeatureTitle + "," + newFeature.FeaturePriority + "," + newFeature.FeatureDescription + "," + newFeature.FeatureNotes + "," +
                    newFeature.EstimatedPrice + "," + newFeature.EstimatedAnnualUnitSale + "," + newFeature.EstimatedDaysToReleaseMVP + "," + newFeature.ActualDaysToReleaseMVP
                      + "," + newFeature.Classification + "," + newFeature.FeatureEnteredBy + "," + newFeature.IsUrgentForProject + "," + newFeature.Markets
                       + "," + newFeature.Applications + "," + newFeature.RankDM + "," + newFeature.RankDB + "," + newFeature.RankRK + "," + newFeature.CompetitorsHaveFeature; ;
            }

            File.AppendAllText(
                filePath, featureString + Environment.NewLine);
        }

        public string[] GetFeatureList()
        {
            string[] featureListFile = new string[0];

            if (File.Exists(filePath))
            {
                featureListFile = File.ReadAllLines(filePath);
            }

            return featureListFile;
        }

        public FeatureModel GetFeatureById(int id)
        {
            FeatureModel feature = new FeatureModel();

            string[] featureList = GetFeatureList();

            foreach (string s in featureList)
            {
                string[] splitFeature = s.Split(',');

                if (splitFeature[0] == id.ToString())
                {
                    feature.FeatureTitle = splitFeature[1];
                    feature.FeaturePriority = int.Parse(splitFeature[2]);
                    feature.FeatureDescription = splitFeature[3];
                    feature.FeatureNotes = splitFeature[4];
                    feature.EstimatedPrice = decimal.Parse(splitFeature[5]);
                    feature.EstimatedAnnualUnitSale = int.Parse(splitFeature[6]);
                    feature.EstimatedDaysToReleaseMVP = int.Parse(splitFeature[7]);
                    feature.ActualDaysToReleaseMVP = int.Parse(splitFeature[8]);
                    feature.Classification = splitFeature[9];
                    feature.FeatureEnteredBy = splitFeature[10];
                    //feature.IsUrgentForProject = splitFeature[11];
                    //feature.Markets = splitFeature[12];
                    //feature.Applications = splitFeature[13];
                    feature.RankDM = int.Parse(splitFeature[14]);
                    feature.RankDB = int.Parse(splitFeature[15]);
                    feature.RankRK = int.Parse(splitFeature[16]);
                    //feature.CompetitorsHaveFeature = splitFeature[17];
                }
            }

            return feature;
        }
    }
}