using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureTrackingToolExperiment.Models;

namespace FeatureTrackingToolExperiment.Interfaces
{
    public interface IRepository
    {
        List<FeatureModel> GetRepository(string repo);
    }
}
