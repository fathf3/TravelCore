using Microsoft.AspNetCore.Mvc;
using Traversal.CQRS.Handlers.DestinationHandlers;
using Traversal.CQRS.Queries.DestinationResult;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _handler;

        public DestinationCQRSController(GetAllDestinationQueryHandler handler)
        {
            _handler = handler;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }
    }
}
