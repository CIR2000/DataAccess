using System;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Used in Gets when multiple documents are needed.
	/// </summary>
	public interface IGetRequest : IRequestBase
	{
		/// <summary>
		/// Gets or sets the filters.
		/// </summary>
		/// <value>The filters.</value>
		IList<Filter> Filters { get; set; }

		/// <summary>
		/// Gets or sets the sort.
		/// </summary>
		/// <value>The sort.</value>
		IList<Sort> Sort { get; set; }

		/// <summary>
		/// Gets or sets the If-Modified-Since filter. Request only documents modified since this date. 
		/// </summary>
		/// <value>The If-Modified-Since value.</value>
		/// TODO: this is probably valid and coherent for both local and rest datasource, so it make sense to have it in the base interface.
		DateTime IfModifiedSince { get; set; }
	}

	public interface IGetRequestItemBase : IRequestBase
	{
		/// <summary>
		/// Gets or sets If-None-Match filter. Retrieve the document only if its etag differs from this one.
		/// </summary>
		/// <value>If none match.</value>
		/// TODO: this one is tricky. Probably doesn't make much sense for local storage, and in any case should be 
		/// also added to the RequestItemByString interface. There might be alternatives that need discussion.
		string IfNoneMatch { get; set; }
	}
	/// <summary>
	/// Used in Gets when requesting individual items.
	/// </summary>
	public interface IGetRequestItem : IGetRequestItemBase
	{
		/// <summary>
		/// Gets or sets the item identifier.
		/// </summary>
		/// <value>The item identifier.</value>
		int ItemId { get; set; }
	}

	/// <summary>
	/// Used in Gets when requesting an item by string Id.
	/// </summary>
	public interface IGetRequestItemByString : IGetRequestItemBase
	{
		string ItemId { get; set; }
	}
}
