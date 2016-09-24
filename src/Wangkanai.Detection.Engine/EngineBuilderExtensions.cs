﻿// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection.Extensions;
using Wangkanai.Detection;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{    
    public static class EngineBuilderExtensions
    {
        // Concept idea on adding engine detection to client service
        public static IDetectionBuilder AddEngine(this IDetectionBuilder builder)
        {
            builder.Services.TryAddTransient<IEngineResolver, EngineResolver>();

            return builder;
        }
    }
}
