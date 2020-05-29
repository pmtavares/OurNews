﻿using MediatR;
using Persistence;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Articles.Write
{
    public class Delete
    {

        public class Command: IRequest
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {

            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {

                var article = await _context.Articles.FindAsync(request.Id);

                if(article == null)
                {
                    throw new Exception("Could not find activity");
                }

                _context.Remove(article);

                var success = await _context.SaveChangesAsync() > 0;
                if(success)
                {
                    return Unit.Value;
                }

                throw new Exception("Could not delete article");

            }
        }
    }
}
