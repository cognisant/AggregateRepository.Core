﻿// <copyright file="AggregateVersionException.cs" company="Cognisant">
// Copyright (c) Cognisant. All rights reserved.
// </copyright>

namespace CR.AggregateRepository.Core.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <inheritdoc />
    /// <summary>
    /// Thrown when an incorrect aggregate version is specified.
    /// </summary>
    [Serializable]
    public class AggregateVersionException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateVersionException" /> class with no message, or inner exception.
        /// </summary>
        // ReSharper disable once InheritdocConsiderUsage
        public AggregateVersionException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateVersionException"/> class with the provided message.
        /// </summary>
        /// <param name="message">A brief explanation about the cause of the exception.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public AggregateVersionException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateVersionException"/> class with the provided message and inner exception.
        /// </summary>
        /// <param name="message">A brief explanation about the cause of the exception.</param>
        /// <param name="inner">The exception which resulted in this exception being thrown.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public AggregateVersionException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateVersionException"/> class with serialized data from the provided <see cref="SerializationInfo"/> and <see cref="StreamingContext"/>.
        /// </summary>
        /// <param name="info">The serialization information to deserialize the data with.</param>
        /// <param name="context">The streaming context to get the serialized data from.</param>
        // ReSharper disable once InheritdocConsiderUsage
        protected AggregateVersionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
