﻿// Copyright © Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using SimpleInjector;
using SimpleInjector.Integration.Web;

namespace AnyContainer.SimpleInjector.Web
{
    /// <summary>
    /// Register items in the web request scope for Simple Injector.
    /// </summary>
    public class SimpleInjectorWebRequestScopeRegistrar : ScopeRegistrar
    {
	    private readonly Container container;

        /// <summary>
        /// Creates a new instance of the <see cref="SimpleInjectorSingletonScopeRegistrar"/> class.
        /// </summary>
        /// <param name="container">The Simple Injector container to use to register.</param>
        public SimpleInjectorWebRequestScopeRegistrar(Container container)
        {
            this.container = container;
        }

        /// <summary>
        /// Registers a type with a given implementation type.
        /// </summary>
        /// <typeparam name="TRegisteredAs">The type to register.</typeparam>
        /// <typeparam name="TResolvedTo">The type to implement the registration.</typeparam>
        public override void Register<TRegisteredAs, TResolvedTo>()
        {
			this.container.Register<TRegisteredAs, TResolvedTo>(new WebRequestLifestyle());
        }

        /// <summary>
        /// Registers a type with a given implementation type.
        /// </summary>
        /// <param name="registeredAs">The type to register.</param>
        /// <param name="resolvedTo">The type to implement the registration.</param>
        public override void Register(Type registeredAs, Type resolvedTo)
        {
            this.container.Register(registeredAs, resolvedTo, new WebRequestLifestyle());
        }

        /// <summary>
        /// Registers a type with a given factory.
        /// </summary>
        /// <typeparam name="T">The type to register.</typeparam>
        /// <param name="factory">The factory to create the type.</param>
        public override void Register<T>(Func<T> factory)
        {
			this.container.Register<T>(factory, new WebRequestLifestyle());
        }

        /// <summary>
        /// Registers a type.
        /// </summary>
        /// <typeparam name="T">The type to register.</typeparam>
        public override void Register<T>()
        {
            this.container.Register<T>(new WebRequestLifestyle());
        }
    }
}
