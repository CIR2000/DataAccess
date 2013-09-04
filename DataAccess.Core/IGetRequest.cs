using System;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess
{

	public interface IGetRequest : IGetRequestBase
	{
		/// <summary>
		/// Gets or sets the filters.
		/// </summary>
		/// <value>The filters.</value>
		IList<IFilter> Filters { get; set; }

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
