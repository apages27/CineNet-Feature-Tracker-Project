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
            List<FeatureModel> features = oper.GetFeatureList();

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
            FeatureModel featureToBeEdited = oper.GetFeatureById(id);
            
            return View("EditFeature", featureToBeEdited);
        }

        [HttpPost]
        public ActionResult EditFeature(FeatureModel editedFeature)
        {
            if (ModelState.IsValid)
            {
                oper.EditFeature(editedFeature);

                return RedirectToAction("FeatureList");
            }
            else
            {
                return View("EditFeature", editedFeature);
            }
        }

        public ActionResult DeleteFeature(int id)
        {
            FeatureModel featureToBeDeleted = oper.GetFeatureById(id);

            return View("DeleteFeature", featureToBeDeleted);
        }

        [HttpPost]
        public ActionResult DeleteFeature(FeatureModel deletedFeature)
        {
            if (ModelState.IsValid)
            {
                oper.DeleteFeature(deletedFeature.FeatureId);

                return RedirectToAction("FeatureList");
            }
            else
            {
                return View("DeleteFeature", deletedFeature);
            }
        }
    }
}