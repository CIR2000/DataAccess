using System;
using NUnit.Framework;
using DataAccess.Core;

namespace DataAccess.Core.Tests
{
	[TestFixture ()]
	public class SortTests
	{
		Sort sort;

		[Test ()]
		public void BaseConstructor ()
		{
			sort = new Sort ();
			Assert.AreEqual (SortDirection.Ascending, sort.Direction);
//			Assert.IsNull (sort.Field);
		}

		[Test ()]
		public void TwoArgsConstructor ()
		{
			sort = new Sort ("field", SortDirection.Descending);
			Assert.AreEqual (SortDirection.Descending, sort.Direction);
			Assert.AreEqual ("field", sort.Field);
		}
	}
}

