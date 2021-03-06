﻿// <copyright file="TracerActiveSpanExtensions.cs" company="OpenTelemetry Authors">
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

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenTelemetry.Trace
{
    /// <summary>
    /// Tracer extension methods to start active spans.
    /// </summary>
    public static class TracerActiveSpanExtensions
    {
        /// <summary>
        /// Activates the span on the current context.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="span">Span to activate.</param>
        /// <returns>Disposable object to control span to current context association.</returns>
        public static IDisposable WithSpan(this ITracer tracer, ISpan span)
        {
            return tracer.WithSpan(span, false);
        }

        /// <summary>
        /// Starts active span.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="operationName">Span name.</param>
        /// <param name="span">Created span.</param>
        /// <returns>Scope.</returns>
        public static IDisposable StartActiveSpan(this ITracer tracer, string operationName, out ISpan span)
        {
            span = tracer.StartSpan(operationName, SpanKind.Internal, null);
            return tracer.WithSpan(span, true);
        }

        /// <summary>
        /// Starts active span.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="operationName">Span name.</param>
        /// <param name="kind">Kind.</param>
        /// <param name="span">Created span.</param>
        /// <returns>Scope.</returns>
        public static IDisposable StartActiveSpan(this ITracer tracer, string operationName, SpanKind kind, out ISpan span)
        {
            span = tracer.StartSpan(operationName, kind, null);
            return tracer.WithSpan(span, true);
        }

        /// <summary>
        /// Starts active span.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="operationName">Span name.</param>
        /// <param name="kind">Kind.</param>
        /// <param name="options">Advanced span creation options.</param>
        /// <param name="span">Created span.</param>
        /// <returns>Scope.</returns>
        public static IDisposable StartActiveSpan(this ITracer tracer, string operationName, SpanKind kind, SpanCreationOptions options, out ISpan span)
        {
            span = tracer.StartSpan(operationName, kind, options);
            return tracer.WithSpan(span, true);
        }

        /// <summary>
        /// Starts active span.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="operationName">Span name.</param>
        /// <param name="parent">Parent for new span.</param>
        /// <param name="span">Created span.</param>
        /// <returns>Scope.</returns>
        public static IDisposable StartActiveSpan(this ITracer tracer, string operationName, SpanContext parent, out ISpan span)
        {
            span = tracer.StartSpan(operationName, parent, SpanKind.Internal, null);
            return tracer.WithSpan(span, true);
        }

        /// <summary>
        /// Starts active span.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="operationName">Span name.</param>
        /// <param name="parent">Parent for new span.</param>
        /// <param name="kind">Kind.</param>
        /// <param name="span">Created span.</param>
        /// <returns>Scope.</returns>
        public static IDisposable StartActiveSpan(this ITracer tracer, string operationName, SpanContext parent, SpanKind kind, out ISpan span)
        {
            span = tracer.StartSpan(operationName, parent, kind, null);
            return tracer.WithSpan(span, true);
        }

        /// <summary>
        /// Starts active span.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="operationName">Span name.</param>
        /// <param name="parent">Parent for new span.</param>
        /// <param name="kind">Kind.</param>
        /// <param name="options">Advanced span creation options.</param>
        /// <param name="span">Created span.</param>
        /// <returns>Scope.</returns>
        public static IDisposable StartActiveSpan(this ITracer tracer, string operationName, SpanContext parent, SpanKind kind, SpanCreationOptions options, out ISpan span)
        {
            span = tracer.StartSpan(operationName, parent, kind, options);
            return tracer.WithSpan(span, true);
        }

        /// <summary>
        /// Starts active span.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="operationName">Span name.</param>
        /// <param name="parent">Parent for new span.</param>
        /// <param name="span">Created span.</param>
        /// <returns>Scope.</returns>
        public static IDisposable StartActiveSpan(this ITracer tracer, string operationName, ISpan parent, out ISpan span)
        {
            span = tracer.StartSpan(operationName, parent, SpanKind.Internal, null);
            return tracer.WithSpan(span, true);
        }

        /// <summary>
        /// Starts active span.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="operationName">Span name.</param>
        /// <param name="parent">Parent for new span.</param>
        /// <param name="kind">Kind.</param>
        /// <param name="span">Created span.</param>
        /// <returns>Scope.</returns>
        public static IDisposable StartActiveSpan(this ITracer tracer, string operationName, ISpan parent, SpanKind kind, out ISpan span)
        {
            span = tracer.StartSpan(operationName, parent, kind, null);
            return tracer.WithSpan(span, true);
        }

        /// <summary>
        /// Starts active span.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="operationName">Span name.</param>
        /// <param name="parent">Parent for new span.</param>
        /// <param name="kind">Kind.</param>
        /// <param name="options">Advanced span creation options.</param>
        /// <param name="span">Created span.</param>
        /// <returns>Scope.</returns>
        public static IDisposable StartActiveSpan(this ITracer tracer, string operationName, ISpan parent, SpanKind kind, SpanCreationOptions options, out ISpan span)
        {
            span = tracer.StartSpan(operationName, parent, kind, options);
            return tracer.WithSpan(span, true);
        }

        /// <summary>
        /// Starts active span.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="operationName">Span name.</param>
        /// <param name="activity">Parent for new span.</param>
        /// <param name="span">Created span.</param>
        /// <returns>Scope.</returns>
        public static IDisposable StartActiveSpanFromActivity(this ITracer tracer, string operationName, Activity activity, out ISpan span)
        {
            span = tracer.StartSpanFromActivity(operationName, activity, SpanKind.Internal, null);
            return tracer.WithSpan(span, true);
        }

        /// <summary>
        /// Starts active span.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="operationName">Span name.</param>
        /// <param name="activity">Parent for new span.</param>
        /// <param name="kind">Kind.</param>
        /// <param name="span">Created span.</param>
        /// <returns>Scope.</returns>
        public static IDisposable StartActiveSpanFromActivity(this ITracer tracer, string operationName, Activity activity, SpanKind kind, out ISpan span)
        {
            span = tracer.StartSpanFromActivity(operationName, activity, kind, null);
            return tracer.WithSpan(span, true);
        }

        /// <summary>
        /// Starts active span.
        /// </summary>
        /// <param name="tracer">Tracer instance.</param>
        /// <param name="operationName">Span name.</param>
        /// <param name="activity">Parent for new span.</param>
        /// <param name="kind">Kind.</param>
        /// <param name="links">Links collection.</param>
        /// <param name="span">Created span.</param>
        /// <returns>Scope.</returns>
        public static IDisposable StartActiveSpanFromActivity(this ITracer tracer, string operationName, Activity activity, SpanKind kind, IEnumerable<Link> links, out ISpan span)
        {
            span = tracer.StartSpanFromActivity(operationName, activity, kind, links);
            return tracer.WithSpan(span, true);
        }
    }
}
