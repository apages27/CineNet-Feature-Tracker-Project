using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureTrackingToolExperiment.Models;

namespace FeatureTrackingToolExperiment.Interfaces
{
    public interface IFeatureRepository
    {
        List<FeatureModel> GetFeatureList();

        FeatureModel GetFeatureById(int id);

        void AddNewFeature(FeatureModel newFeature);

        void EditFeature(FeatureModel editedFeature);

        void DeleteFeature(int id);
    }
}
