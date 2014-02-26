using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeatureTrackingToolExperiment.Models;
using FeatureTrackingToolExperiment.Operations;

namespace FeatureTrackingToolExperiment.Controllers
{
    public class HomeController : Controller
    {
        FeatureOperations oper = new FeatureOperations();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FeatureList()
        {
            List<FeatureModel> features = new List<FeatureModel>();

            string[] featureListArray = oper.GetFeatureList();

            foreach (var line in featureListArray)
            {
                FeatureModel feature = new FeatureModel();
                string[] splitFeature = line.Split(',');

                feature.FeatureTitle = splitFeature[0];
                feature.FeaturePriority = int.Parse(splitFeature[1]);
                feature.FeatureDescription = splitFeature[2];

                features.Add(feature);
            }

            return View(features);
        }

        public ActionResult AddFeature()
        {
            FeatureModel model = new FeatureModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult AddFeature(FeatureModel newFeature)
        {
            if (ModelState.IsValid)
            {
                oper.AddFeatureToList(newFeature);

                return RedirectToAction("FeatureList"); 
            }
            else
            {
                return View(newFeature);
            }
        }

        public ActionResult EditFeature(int id)
        {
            FeatureModel model = oper.GetFeatureById(id);
            
            return View("AddFeature", model);
        }

        [HttpPost]
        public ActionResult EditFeature(FeatureModel newFeature)
        {
            if (ModelState.IsValid)
            {
                oper.AddFeatureToList(newFeature);

                return RedirectToAction("FeatureList");
            }
            else
            {
                return View("AddFeature", newFeature);
            }
        }
    }
}