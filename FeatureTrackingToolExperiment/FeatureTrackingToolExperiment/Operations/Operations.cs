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
            string featureString = newFeature.FeatureTitle + "," + newFeature.FeaturePriority + "," + newFeature.FeatureDescription;

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
    }
}