using System;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Used in Gets when multiple documents are needed.
	/// </summary>
	public class GetRequest : RequestBase
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
		DateTime IfModifiedSince { get; set; }
	}
}
