using Application.Articles.Read;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
