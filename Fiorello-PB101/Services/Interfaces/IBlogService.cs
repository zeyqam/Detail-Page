﻿using Fiorello_PB101.ViewModels.Blog;

namespace Fiorello_PB101.Services.Interfaces
{
    public interface IBlogService
    {
        public  Task<IEnumerable<BlogVM>> GetAllAsync(int?take=null);
    }
}
