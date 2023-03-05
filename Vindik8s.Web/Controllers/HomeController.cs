using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Vindik8s.Web.Models;

namespace Vindik8s.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public async Task<IActionResult> GetClusters()
        {
            var clusters = await Task.FromResult(new[] { "c17", "dev", "prod" });
            return new JsonResult(clusters);
        }

        public async Task<IActionResult> LoadClusterNamespaces(string clusterName)
        {
            var namespaces = await Task.FromResult(new[] { "corporate", "infrastructure" });
            return new JsonResult(namespaces);
        }

        public async Task<IActionResult> LoadNamespaceMicroservices(string clusterName, string namespaceName)
        {
            var microservices = await Task.FromResult(new[] { "banking integration scheduler" });
            return new JsonResult(microservices);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}