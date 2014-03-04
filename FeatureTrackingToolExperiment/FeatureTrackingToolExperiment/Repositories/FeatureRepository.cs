using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FeatureTrackingToolExperiment.Interfaces;
using FeatureTrackingToolExperiment.Models;

namespace FeatureTrackingToolExperiment.Repositories
{
    public class FeatureRepository : IFeatureRepository
    {
        public List<FeatureModel> GetFeatureList()
        {
            List<FeatureModel> features = new List<FeatureModel>();

            return features;
        }

        public FeatureModel GetFeatureById(int id)
        {
            FeatureModel feature = new FeatureModel();

            return feature;
        }

        public void AddNewFeature(FeatureModel newFeature)
        {
            
        }

        public void EditFeature(FeatureModel editedFeature)
        {
            
        }

        public void DeleteFeature(int id)
        {
            
        }
    }
}