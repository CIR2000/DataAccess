using System;
using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Used in Gets when multiple documents are needed.
	/// </summary>
	public class Request : IRequest
	{
		/// <summary>
		/// Gets or sets the data source name name or address (DB name, API uri, etc.)
		/// </summary>
		/// <value>The data source name or address.</value>
		public string DataSourceName { get; set; }

		/// <summary>
		/// Gets or sets the request authentication.
		/// </summary>
		/// <value>The authentication.</value>
		public Authentication Authentication { get; set; }

		/// <summary>
		/// Gets or sets the target resource.
		/// </summary>
		/// <value>The resource name.</value>
		public string Resource { get; set; }

		/// <summary>
		/// Gets or sets the request method.
		/// </summary>
		/// <value>The method.</value>
		public Methods Method { get; set; }

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
		public DateTime? IfModifiedSince { get; set; }

		public int? DocumentId { get; set; }

		public string IfNoneMatch { get; set; }

		public Request()
		{
			Method = Methods.Read;
			Filters = new List<IFilter> ();
			Sort = new List<Sort> ();
			IfModifiedSince = null;
			IfNoneMatch = null;
		}
	}
}
