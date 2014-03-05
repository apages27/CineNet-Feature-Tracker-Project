using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FeatureTrackingToolExperiment.Interfaces;

namespace FeatureTrackingToolExperiment.Repositories
{
    public class RepositoryFactory
    {
        public static IFeatureRepository GetFeatureRepository(string mode)
        {
            if (mode == "T") return new TestRepository(); else return new FeatureRepository();
        }
    }
}