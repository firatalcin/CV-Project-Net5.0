using Business.Abstract;
using DataAccess.Repositories;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TestimonialManager : GenericManager<Testimonial>, ITestimonialService
    {
        public TestimonialManager(IGenericRepository<Testimonial> repository) : base(repository)
        {
        }
    }
}