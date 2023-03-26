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

        public async Task<IActionResult> Index(string clusterName)
        {
            var clusters = new List<Cluster>();
            foreach (var c in await _clustersService.GetClustersAsync())
            {
                var clusterModel = new Cluster(c);
                foreach (var n in await _clusterNamespacesService.GetNamespacesAsync(c))
                {
                    var namespaceModel = new Namespace(n);
                    foreach (var s in await _microservicesService.GetMicroservicesAsync(c, n))
                    {
                        namespaceModel.Microservices.Add(new Microservice(s, "", ""));
                    }

                    clusterModel.Namespaces.Add(namespaceModel);
                }

                clusters.Add(clusterModel);
            }

            return View(new ClusterSelection(clusterName, clusters));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}