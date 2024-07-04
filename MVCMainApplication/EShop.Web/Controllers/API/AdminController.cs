using EShop.Domain.Domain;
using EShop.Domain.DTO;
using EShop.Domain.Identity;
using EShop.Repository;
using EShop.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Movie_App.Service.Interface;

namespace EShop.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMovieService _movieService;
        public AdminController(IOrderService orderService, IMovieService movieService)
        {
            _orderService = orderService;
            _movieService = movieService;
        }

        [HttpGet]
        public List<Order> Index()
        {
            return _orderService.GetAllOrders();
        }

        [HttpGet("[action]")]
        public List<Order> GetAllOrders()
        {
            return _orderService.GetAllOrders();
        }

        [HttpPost("[action]")]
        public Order GetDetailsForOrder(BaseEntity model)
        {
            return _orderService.GetDetailsForOrder(model);
        }

        [HttpPost("[action]")]
        public bool ImportAllMovies(List<MovieDTO> model)
        {
            foreach (var movie in model)
            {                
                var neww = new Movie
                {
                    Id = Guid.NewGuid(),
                    MovieName = movie.MovieName,
                    MovieDescription = movie.MovieDescription,
                    MovieImage = movie.MovieImage,
                    Rating = movie.Rating
                };
                _movieService.CreateNewMovie(neww);
            }
            return true;
        }
    }
}
