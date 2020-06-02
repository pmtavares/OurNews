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
    public class FrontNews
    {
        public class Query : IRequest<List<Article>>
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
                var articles = await _context.Articles.Where(x => x.Level == 1).ToListAsync();

                return articles;
               
            }
        }
    }
}
