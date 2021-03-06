﻿// <copyright file="TestEvent.cs" company="Corsham Science">
// Copyright (c) Corsham Science. All rights reserved.
// </copyright>

namespace AggregateRepository.Core.Tests
{
    using System;

    internal class TestEvent
    {
        public TestEvent(Guid eventId) => EventId = eventId;

        public Guid EventId { get; }
    }
}
