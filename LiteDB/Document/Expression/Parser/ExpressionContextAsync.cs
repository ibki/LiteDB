﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using static LiteDB.Constants;

namespace LiteDB
{
    internal class ExpressionContextAsync
    {
        public ExpressionContextAsync()
        {
            this.Source = Expression.Parameter(typeof(IAsyncEnumerable<BsonDocument>), "source");
            this.Root = Expression.Parameter(typeof(BsonDocument), "root");
            this.Current = Expression.Parameter(typeof(BsonValue), "current");
            this.Collation = Expression.Parameter(typeof(Collation), "collation");
            this.Parameters = Expression.Parameter(typeof(BsonDocument), "parameters");
        }

        public ParameterExpression Source { get; }
        public ParameterExpression Root { get; }
        public ParameterExpression Current { get; }
        public ParameterExpression Collation { get; }
        public ParameterExpression Parameters { get; }
    }
}