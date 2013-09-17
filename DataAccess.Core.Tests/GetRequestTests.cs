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
			Assert.IsInstanceOf<IList<IFilter>> (request.Filters);
			Assert.IsEmpty (request.Filters);
			Assert.IsInstanceOf<List<Sort>> (request.Sort);
			Assert.IsEmpty (request.Sort);
//			Assert.IsNull (request.IfModifiedSince);
		}
	}
}

