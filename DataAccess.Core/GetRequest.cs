using System;
using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Used in Gets when multiple documents are needed.
	/// </summary>
	public class GetRequest : GetRequestBase, IGetRequest  
	{
		/// <summary>
		/// Gets or sets the filters.
		/// </summary>
		/// <value>The filters.</value>
		public IList<IFilter> Filters { get; set; }

		/// <summary>
		/// Gets or sets the sort.
		/// </summary>
		/// <value>The sort.</value>
		public IList<Sort> Sort { get; set; }

		/// <summary>
		/// Gets or sets the If-Modified-Since filter. Request only documents modified since this date. 
		/// </summary>
		/// <value>The If-Modified-Since value.</value>
		public DateTime IfModifiedSince { get; set; }

		public GetRequest()
		{
			Filters = new List<IFilter> ();
			Sort = new List<Sort> ();
		}
	}
}
