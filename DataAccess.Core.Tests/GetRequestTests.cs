using System;
using System.Collections.Generic;
using NUnit.Framework;
using DataAccess.Core;

namespace DataAccess.Core.Tests
{
	[TestFixture ()]
	public class GetRequestTests
	{
		GetRequest request;

		[Test ()]
		public void BaseConstructor ()
		{
			request = new GetRequest ();
			Assert.IsInstanceOfType (typeof(IList<IFilter>), request.Filters);
			Assert.AreEqual (0, request.Filters.Count);
			Assert.IsInstanceOfType(typeof(IList<Sort>), (request.Sort));
			Assert.AreEqual (0, request.Sort.Count);
//			Assert.IsNull (request.IfModifiedSince);
		}
	}
}

