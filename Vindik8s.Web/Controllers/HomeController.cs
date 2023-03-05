using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Vindik8s.Web.Models;
using Vindik8s.Web.Services.Abstract;

namespace Vindik8s.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClustersService _clustersService;
        private readonly IClusterNamespacesService _clusterNamespacesService;
        private readonly IMicroservicesService _microservicesService;

        public HomeController(
            IClustersService clustersService,
            IClusterNamespacesService clusterNamespacesService,
            IMicroservicesService microservicesService)
        {
            _clustersService = clustersService ?? throw new ArgumentNullException(nameof(clustersService));
            _clusterNamespacesService = clusterNamespacesService ?? throw new ArgumentNullException(nameof(clusterNamespacesService));
            _microservicesService = microservicesService ?? throw new ArgumentNullException(nameof(microservicesService));
        }

        public IActionResult Index() => View();

        public async Task<IActionResult> GetClusters()
        {
            var clusters = await _clustersService.GetClustersAsync();
            return new JsonResult(clusters);
        }

        public async Task<IActionResult> LoadClusterNamespaces(string clusterName)
        {
            var namespaces = await _clusterNamespacesService.GetNamespacesAsync(clusterName);
            return new JsonResult(namespaces);
        }

        public async Task<IActionResult> LoadNamespaceMicroservices(string clusterName, string namespaceName)
        {
            var microservices = await _microservicesService.GetMicroservicesAsync(clusterName, namespaceName);
            return new JsonResult(microservices);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}