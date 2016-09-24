﻿// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Wangkanai.Detection;

// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Http
{
    // concept of extension to HttpRequest
    public static class PlatformRequestExtensions
    {
        public static Platform Platform(this HttpRequest request)
        {
            return new Platform();
        }        
    }
}
