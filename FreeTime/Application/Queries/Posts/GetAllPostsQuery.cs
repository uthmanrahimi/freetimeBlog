﻿using FreeTime.Web.Application.Models;
using MediatR;
using System.Collections.Generic;

namespace FreeTime.Web.Application.Queries.Posts
{
    public class GetAllPostsQuery : IRequest<Envelope<IEnumerable<PostListDto>>>
    {
        public int Page { get; set; }
        public int PostsPerPage { get;private  set; }
        public GetAllPostsQuery(int page,int postsPerPage)
        {
            Page = page;
            PostsPerPage = postsPerPage;
        }

    }
}
