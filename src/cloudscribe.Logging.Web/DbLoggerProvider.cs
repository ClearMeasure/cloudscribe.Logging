﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
//	Author:                 Joe Audette
//  Created:			    2011-08-19
//	Last Modified:		    2017-08-25
// 

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace cloudscribe.Logging.Web
{
    public class DbLoggerProvider : ILoggerProvider
    {
        public DbLoggerProvider(
            Func<string, LogLevel, bool> filter,
            IServiceProvider serviceProvider
            )
        {
            services = serviceProvider;
            //this.minimumLevel = minimumLevel;
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            _filter = filter;
        }

        private IServiceProvider services;
        private readonly Func<string, LogLevel, bool> _filter;
        //private LogLevel minimumLevel;

        public ILogger CreateLogger(string name)
        {
            return new DbLogger(name, _filter, services);
        }

        public void Dispose()
        {
        }

    }
}
