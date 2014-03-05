using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Web;
using FeatureTrackingToolExperiment.Interfaces;
using FeatureTrackingToolExperiment.Models;
using FeatureTrackingToolExperiment.Repositories;

namespace FeatureTrackingToolExperiment.Operations
{
    public class FeatureOperations
    {
        public IFeatureRepository repo = RepositoryFactory.GetFeatureRepository("test");

        public void AddFeatureToList(FeatureModel newFeature)
        {
            repo.AddNewFeature(newFeature);
        }

        public List<FeatureModel> GetFeatureList()
        {
            List<FeatureModel> featureListFile = repo.GetFeatureList();

            return featureListFile;
        }

        public FeatureModel GetFeatureById(int id)
        {
            FeatureModel feature = repo.GetFeatureById(id);

            return feature;
        }

        public void EditFeature(FeatureModel editedFeature)
        {
            repo.EditFeature(editedFeature);
        }

        public void DeleteFeature(int id)
        {
            repo.DeleteFeature(id);
        }
    }
}