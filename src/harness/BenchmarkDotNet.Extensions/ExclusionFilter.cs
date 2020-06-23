﻿using BenchmarkDotNet.Filters;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarkDotNet.Extensions
{
    class ExclusionFilter : IFilter
    {
        private readonly GlobFilter globFilter;

        public ExclusionFilter(List<string> _filter)
        {
            if (_filter != null && _filter.Count != 0)
            {
                globFilter = new GlobFilter(_filter.ToArray());
            }
        }

        public bool Predicate(BenchmarkCase benchmarkCase)
        {
            if(globFilter == null)
            {
                return true;
            }
            return !globFilter.Predicate(benchmarkCase);
        }
    }
}
