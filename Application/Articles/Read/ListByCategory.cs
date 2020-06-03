using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Articles.Read
{
    public class ListByCategory
    {
        public class Query : IRequest<List<Article>>
        {
            public string Category;
            public int Total;
        }

        public class Handler : IRequestHandler<Query, List<Article>>
        {

            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Article>> Handle(Query request, CancellationToken cancellationToken)
            {
                var articles = await _context.Articles
                    .Where(x => x.Category == request.Category && x.Level == 0)
                    .OrderByDescending(x => x.DatePublished).Take(request.Total).ToListAsync();
                return articles;
            }
        }
    }
}
