using System.Web.Mvc;
using System.Web.Mvc.Html;


namespace Prototype.Infrastructure
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString MenuLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, string liCssClass)
        {
            var currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
            var currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");

            if (actionName == currentAction && controllerName == currentController)
            {
                liCssClass += " active";
            }
            return string.IsNullOrWhiteSpace(liCssClass) ?
                MvcHtmlString.Create("<li>" + htmlHelper.ActionLink(linkText, actionName, controllerName) + "</li>") :
                MvcHtmlString.Create("<li class=\"" + liCssClass + "\">" + htmlHelper.ActionLink(linkText, actionName, controllerName) + "</li>");
        }
    }
}