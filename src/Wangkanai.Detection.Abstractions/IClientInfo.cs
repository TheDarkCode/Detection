﻿// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Wangkanai.Detection;

// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Http
{
    public interface IClientInfo
    {
        IUserAgent UserAgent { get; }
        IDevice Device { get; }
        // waiting to implement in the future
        //Browser Browser { get; }
        //Platform Platform { get; }
        //Engine Engine { get; }
    }
}