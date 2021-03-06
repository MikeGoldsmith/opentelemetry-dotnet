﻿// <copyright file="TagContext.cs" company="OpenTelemetry Authors">
// Copyright 2018, OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace OpenTelemetry.Context
{
    public sealed class TagContext : TagContextBase
    {
        public static readonly ITagContext Empty = new TagContext(new Dictionary<string, string>());

        public TagContext(IDictionary<string, string> tags)
        {
            this.Tags = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>(tags));
        }

        public IDictionary<string, string> Tags { get; }

        public override IEnumerator<DistributedContextEntry> GetEnumerator()
        {
            var result = this.Tags.Select((kvp) => new DistributedContextEntry(kvp.Key, kvp.Value));
            return result.ToList().GetEnumerator();
        }
    }
}
