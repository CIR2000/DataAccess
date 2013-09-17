using System;
using System.Collections.Generic;
using NUnit.Framework;
using DataAccess.Core;

namespace DataAccess.Core.Tests
{
	[TestFixture ()]
	public class FiltersTest
	{
		Filter filter;

		[Test]
		public void BaseConstructor ()
		{
			filter = new Filter ();
			Assert.AreEqual (Concatenation.And, filter.Concatenator);
		}

		[Test]
		public void ThreeArgsConstructor()
		{
			filter = new Filter ("field", Comparison.NotEqual, 1);
			Assert.AreEqual ("field", filter.Field);
			Assert.AreEqual (Comparison.NotEqual, filter.Comparator);
			Assert.AreEqual (1, filter.Value);
			Assert.AreEqual (Concatenation.And, filter.Concatenator);
		}

		[Test]
		public void FourArgsConstructor()
		{

			filter = new Filter ("field", Comparison.NotEqual, 1, Concatenation.Or);
			Assert.AreEqual ("field", filter.Field);
			Assert.AreEqual (Comparison.NotEqual, filter.Comparator);
			Assert.AreEqual (1, filter.Value);    
			Assert.AreEqual (Concatenation.Or, filter.Concatenator);
		}
	}

	[TestFixture]
	public class FiltersGroupTest
	{

		[Test]
		public void BaseConstructor()
		{
			FiltersGroup fg = new FiltersGroup ();
			Assert.IsInstanceOf<IList<IFilter>> (fg.Filters);
			Assert.IsEmpty (fg.Filters);
			Assert.AreEqual (Concatenation.And, fg.Concatenator);
		}
	}
}

