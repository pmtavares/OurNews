using Domain;
using MediatR;
using Persistence;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Articles.Write
{
    public class Create
    {
        public class Command: IRequest
        {
            public Guid Id { get; set; }

            public string Author { get; set; } //Change to another class

            public string Title { get; set; }

            public DateTime DatePublished { get; set; }

            public string Description { get; set; }

            public string Content { get; set; }

            public string MainContent { get; set; }

            public string MainPhoto { get; set; }

            public string SecundaryPhoto { get; set; }

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

                var article = new Article
                {
                    Id = request.Id,
                    Title = request.Title,
                    Description = request.Description,
                    Content = request.Content,
                    Author = request.Author,
                    MainContent = request.MainContent,
                    Category = request.Category,
                    Tags = request.Tags,
                    MainPhoto = request.MainPhoto,
                    SecundaryPhoto = request.SecundaryPhoto,
                    DatePublished = request.DatePublished //DateTime.Now
                };

                _context.Articles.Add(article);
                var success = await _context.SaveChangesAsync() > 0;

                if(success)
                {
                    return Unit.Value;
                }
                
                throw new Exception();
            }
        }

    }
}
