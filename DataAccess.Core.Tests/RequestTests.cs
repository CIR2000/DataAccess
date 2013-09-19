using System;
using System.Collections.Generic;
using NUnit.Framework;
using DataAccess.Core;

namespace DataAccess.Core.Tests
{
	[TestFixture ()]
	public class RequestTests
	{
		Request request;

		[Test ()]
		public void BaseConstructor ()
		{
			request = new Request ();
			Assert.AreEqual (Methods.Read, request.Method);
			Assert.IsInstanceOfType (typeof(IList<IFilter>), request.Filters);
			Assert.AreEqual (0, request.Filters.Count);
			Assert.IsInstanceOfType(typeof(IList<Sort>), (request.Sort));
			Assert.AreEqual (0, request.Sort.Count);
			Assert.IsNull (request.IfModifiedSince);
			Assert.IsNull (request.IfNoneMatch);
		}
	}
}

