﻿using AspNetCore.IQueryable.Extensions.Attributes;
using AspNetCore.IQueryable.Extensions.Filter;
using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using Microsoft.AspNetCore.Mvc;

namespace RESTFul.Api.ViewModels
{
    public class UserSearch : IQuerySort, IQueryPaging
    {

        [FromQuery(Name = "lives_in")]
        public string Country { get; set; }

        [FromQuery(Name = "older_than"), QueryOperator(Operator = WhereOperator.GreaterThanOrEqualTo, HasName = "Age")]
        public int OlderThan { get; set; }

        [FromQuery(Name = "younger_than"), QueryOperator(Operator = WhereOperator.LessThanOrEqualTo, HasName = "Age")]
        public int YoungerThan { get; set; }

        public int Offset { get; set; }
        public int Limit { get; set; } = 10;
        public string Sort { get; set; }
    }

}
