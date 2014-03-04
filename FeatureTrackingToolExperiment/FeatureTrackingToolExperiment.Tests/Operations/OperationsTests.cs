using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureTrackingToolExperiment.Models;
using FeatureTrackingToolExperiment.Operations;
using FeatureTrackingToolExperiment.Repositories;
using NUnit.Framework;

namespace FeatureTrackingToolExperiment.Tests.Operations
{
    [TestFixture]
    public class OperationsTests
    {
        //IRepository?

        FeatureOperations oper = new FeatureOperations();

        [Test]
        public void GetFeatureListReturnsList()
        {

            TestRepository repo = new TestRepository();
            List<FeatureModel> featureList = oper.GetFeatureList();

            Assert.IsNotEmpty(featureList);
        }

        [Test]
        public void AddFeatureToList()
        {

        }
    }
}
