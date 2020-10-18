﻿using System.Collections.Generic;

namespace FreeTime.Web.Application.Models.Entities
{
    public class TagEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PostTagEntity> Posts { get; set; }
    }
}
