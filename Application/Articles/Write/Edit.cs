using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Articles.Write
{
    public class Edit
    {

        public class Command: IRequest
        {
            public Guid Id { get; set; }

            public string Author { get; set; } //Change to another class

            public string Title { get; set; }

            public string Description { get; set; }

            public string Content { get; set; }

            public string MainContent { get; set; }

            public string Category { get; set; }

            public string Tags { get; set; }
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
                    throw new Exception();
                }

                article.Category = request.Category;
                article.Content = request.Content;
                article.Description = request.Description;
                article.MainContent = request.MainContent;
                article.Title = request.Title;
                article.Tags = request.Tags;
                article.Author = request.Author;

                var success = await _context.SaveChangesAsync() > 0;
                if(success)
                {
                    return Unit.Value;
                }

                throw new Exception("Problem editing article");
            }
        }
    }
}
