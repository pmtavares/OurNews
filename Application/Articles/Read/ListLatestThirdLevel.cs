using MediatR;
using Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Application.Articles.Read
{
    public class ListLatestThirdLevel
    {
        public class Query: IRequest<List<Article>>
        {

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
                    .Where(x => x.Level == 3)
                    .OrderByDescending(x=> x.DatePublished).Take(3).ToListAsync();
                return articles;
            }
        }
    }
}
