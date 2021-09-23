using Mapper.Core;
using Mapper.Dto;
using Mapper.Entity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Mapper.Mvc.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMapper _mapper;

        public IndexModel(ILogger<IndexModel> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public void OnGet()
        {
            Customer customer = new Customer
            {
                Name = "Emrah",
                Surname = "Karaman"
            };
            CustomerDto customerDto = _mapper.Map<Customer, CustomerDto>(customer);
            var b = 1;
        }
    }
}