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
            if (mode == "test") return new TestRepository();
            return new FeatureRepository();
        }
    }
}