using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Prototype.Controllers;
using Repositories;

namespace Prototype.Infrastructure
{
    /// <summary>
    /// Handles dependency resolutions by first utilizing the Unity framework.
    /// </summary>
    public class UnityDependencyResolver
        : IDependencyResolver
    {
        private readonly IUnityContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnityDependencyResolver"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public UnityDependencyResolver(IUnityContainer container)
        {
            _container = container;
        }

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <returns></returns>
        public object GetService(Type serviceType)
        {
            try
            {
                var widgetRepository = new WidgetTemplateRepository();
                var deviceRepository = new DeviceTemplateRepository();

                return
                    serviceType == typeof(HomeController) ? new HomeController(widgetRepository, deviceRepository) :
                    _container.Resolve(serviceType);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets a collection of all available services of the specified type.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <returns></returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch (Exception)
            {
                return new List<object>();
            }
        }
    }
}