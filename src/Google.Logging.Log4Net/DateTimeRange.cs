﻿// Copyright 2016 Google Inc. All Rights Reserved.
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

using System;

namespace Google.Logging.Log4Net
{
    public class DateTimeRange
    {
        public DateTimeRange(DateTime from, DateTime to)
        {
            From = from;
            To = to;
        }

        public DateTime From { get; }
        public DateTime To { get; }

        public DateTimeRange WithTo(DateTime to) => new DateTimeRange(From, to);

        public DateTimeRange Merge(DateTimeRange other)
        {
            if (other == null)
            {
                return this;
            }
            else
            {
                return new DateTimeRange(
                    From < other.From ? From : other.From,
                    To > other.To ? To : other.To);
            }
        }
    }
}
