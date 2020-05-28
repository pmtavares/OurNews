using MediatR;
using Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Articles.Read
{
    public class ListLatest
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
                var articles = await _context.Articles.ToListAsync();
                return articles;
            }
        }
    }
}
