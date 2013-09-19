using System;
using System.Collections.Generic;

namespace DataAccess
{
	public interface IRequest
	{
		/// <summary>
		/// Gets or sets the data source name name or address (DB name, API uri, etc.)
		/// </summary>
		/// <value>The data source name or address.</value>
		string DataSourceName { get; set; }

		/// <summary>
		/// Gets or sets the request authentication.
		/// </summary>
		/// <value>The authentication.</value>
		Authentication Authentication { get; set; }

		/// <summary>
		/// Gets or sets the target resource.
		/// </summary>
		/// <value>The resource name.</value>
		string Resource { get; set; }

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
		DateTime? IfModifiedSince { get; set; }

		/// <summary>
		/// Gets or sets If-None-Match filter. Retrieve a document only if its etag differs from this one.
		/// </summary>
		/// <value>If none match.</value>
		string IfNoneMatch { get; set; }

		/// <summary>
		/// Gets or sets the item identifier. 
		/// If set, it will be used to retrieve a single document by its unique id. 
		/// Eventual Filters and Sort conditions will be ignored.
		/// </summary>
		/// <value>The item identifier.</value>
		int? DocumentId { get; set; }

		/// <summary>
		/// Gets or sets the request method.
		/// </summary>
		/// <value>The request method.</value>
		Methods Method { get; set; }
	}

	public enum Methods
	{
		Create,
		Read,
		Update,
		Delete,
	}
}
