// Copyright © Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using AnyContainer.DryIoc;
using AnyContainer.Unity;
using AnyContainer.SimpleInjector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnyContainer.UnitTests
{
    [TestClass]
    public class ContainerTests
    {
        [TestMethod]
        public void TestUnity()
        {
            CommonContainerTestRunner.RunTests(() => new UnityAnyContainer());
        }

        [TestMethod]
        public void TestSimpleInjector()
        {
            CommonContainerTestRunner.RunTests(() => new SimpleInjectorAnyContainer());
        }

	    [TestMethod]
	    public void TestDryIoc()
	    {
		    CommonContainerTestRunner.RunTests(() => new DryIocAnyContainer());
	    }
	}
}
