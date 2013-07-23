using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prototype.Framework;
using Prototype.Models;
using Prototype.ViewModels;

namespace Prototype.Controllers
{
    public class HomeController : Controller
    {
        private IWidgetTemplateRepository WidgetRepository { get; set; }
        private IDeviceTemplateRepository DeviceRepository { get; set; }

        public HomeController(IWidgetTemplateRepository widgetRepository, IDeviceTemplateRepository deviceRepository)
        {
            WidgetRepository = widgetRepository;
            DeviceRepository = deviceRepository;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult WidgetList()
        {
            var widgets = WidgetRepository.GetWidgets().ToArray();
            var categories = widgets.Select(x => x.Category).Distinct().ToArray();
            var categoryViewModels = 
                categories.Select(category => 
                    new WidgetCategoryViewModel { 
                        Category = category, 
                        Widgets = widgets.Where(widget => widget.Category == category).ToArray() 
                    }
            ).ToArray();
            var viewModel = new WidgetListViewModel { WidgetCategories = categoryViewModels };
            return PartialView("_WidgetList", viewModel);
           
        }

        [ChildActionOnly]
        public ActionResult Workspace()
        {
            var workspaceModel = this.GetSessionProject();

            var view = PartialView("_Workspace", workspaceModel);
            return view;
       }

        [ChildActionOnly]
        public ActionResult DeviceList()
        {
            var devices = DeviceRepository.GetDevices().ToArray();
            var model = new DeviceListViewModel { Devices = devices };
            return PartialView("_DeviceList", model);
        }


        [ChildActionOnly]
        public ActionResult ClientWorkspace()
        {
            var workspaceModel = this.GetSessionProject();

            var view = PartialView("_ClientWorkspace", workspaceModel);
            return view;
        }

        [ChildActionOnly]
        public ActionResult DeviceWorkspace()
        {
            var workspaceModel = this.GetSessionProject();

            var view = PartialView("_DeviceWorkspace", workspaceModel);
            return view;
        }

        public ActionResult Devices()
        {
            var project = this.GetSessionProject();
            var model = new DeviceViewModel
            {
                Project = project,
                AvailableDevices = DeviceRepository.GetDevices().ToArray(),
            };
            var view = View("Devices", model);
            return view;
        }
        public ActionResult Widgets()
        {
            var project = this.GetSessionProject();
            var model = new WidgetViewModel
            {
                Project = project,
                AvailableWidgets = WidgetRepository.GetWidgets().ToArray(),
            };
            var view = View("Widgets", model);
            return View();
        }

        public ActionResult AddDevice(string id)
        {
            var template = DeviceRepository.GetDevices().FirstOrDefault(x => x.ID == id);
            var project = this.GetSessionProject();
            project.AddDevice(template);
            this.SaveSessionProject(project);
            return RedirectToAction("Devices", "Home");
        }
        public ActionResult AddWidget(string id)
        {
            var template = WidgetRepository.GetWidgets().FirstOrDefault(x => x.ID == id);
            var project = this.GetSessionProject();
            project.AddWidget(template);
            this.SaveSessionProject(project);
            return WidgetWorkspace();
        }
        public ActionResult ClearWorkspace()
        {
            this.SaveSessionProject(null);
            return Workspace();
        }

        public ActionResult WidgetWorkspace()
        {
            var project = this.GetSessionProject();
            return PartialView("_WidgetWorkspace", project);
        }
    }
}
