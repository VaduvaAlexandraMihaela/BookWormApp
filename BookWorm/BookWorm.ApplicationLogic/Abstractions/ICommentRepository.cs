﻿using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Abstractions
{
    public interface ICommentRepository:IRepository<Comment>
    {
        Comment GetCommentById(Guid commentId);

        Comment GetCommentByUserId(Guid userId);
    }
}
