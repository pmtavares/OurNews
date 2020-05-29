using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Articles.Read
{
    public class Details
    {
        public class Query: IRequest<Article>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Article>
        {

            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Article> Handle(Query request, CancellationToken cancellationToken)
            {
                var article = await _context.Articles.SingleOrDefaultAsync(x => x.Id == request.Id);

                return article;
            }
        }
    }
}
