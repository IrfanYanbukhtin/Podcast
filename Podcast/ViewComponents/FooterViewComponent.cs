 using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Podcast.DAL;
using Podcast.DAL.Entities;
using Podcast.ViewModels;

namespace Podcast.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public FooterViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footer = await _dbContext.Footers.FirstOrDefaultAsync();

            return View(footer);
        }
    }
}
