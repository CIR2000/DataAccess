using System;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess
{

	public interface IGetRequestItem : IGetRequestBase
	{
		/// <summary>
		/// Gets or sets If-None-Match filter. Retrieve the document only if its etag differs from this one.
		/// </summary>
		/// <value>If none match.</value>
		string IfNoneMatch { get; set; }

		/// <summary>
		/// Gets or sets the item identifier.
		/// </summary>
		/// <value>The item identifier.</value>
		object Id { get; set; }
	}
}
