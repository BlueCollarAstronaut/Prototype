using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prototype.Infrastructure;
using Prototype.Models;
using Prototype.Framework;

namespace Prototype.Controllers
{
    public static class ControllerExtensions
    {
        public static Project GetSessionProject(this Controller controller)
        {
            var model = controller.Session[Constants.KEY_PROJECT] as Project;
            if (model == null)
            {
                model = new Project();
            }
            return model;
        }
        public static void SaveSessionProject(this Controller controller, Project model)
        {
            controller.Session[Constants.KEY_PROJECT] = model;
        }
    }
}