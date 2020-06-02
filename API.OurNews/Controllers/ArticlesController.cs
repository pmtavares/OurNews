using Application.Articles.Read;
using Application.Articles.Write;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.OurNews.Controllers
{
    public class ArticlesController : BaseController
    {

        [HttpGet("latest")]
        public async Task<ActionResult<List<Article>>> ListLatestArticles()
        {
            return await Mediator.Send(new ListLatest.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> Details(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id});
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create(Create.Command command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Edit(Guid id, Edit.Command command)
        {
            command.Id = id;
            return await Mediator.Send(command);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(Guid id)
        {
            
            return await Mediator.Send(new Delete.Command { Id = id});
        }

        [HttpGet("frontnews")]
        public async Task<ActionResult<List<Article>>> GetFrontNews()
        {
            return await Mediator.Send(new FrontNews.Query());
        }

       
   
        [HttpGet("{category}/{total}")]
        public async Task<ActionResult<List<Article>>> ListbyCategory(string category, int total)
        {
            return await Mediator.Send(new ListByCategory.Query { Category = category, Total = total});
        }
    }
}
