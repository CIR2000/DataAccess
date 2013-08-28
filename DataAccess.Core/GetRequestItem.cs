using System;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess
{

	public class GetRequestItem : RequestBase
	{
		/// <summary>
		/// Gets or sets If-None-Match filter. Retrieve the document only if its etag differs from this one.
		/// </summary>
		/// <value>If none match.</value>
		public string IfNoneMatch { get; set; }

		/// <summary>
		/// Gets or sets the item identifier.
		/// </summary>
		/// <value>The item identifier.</value>
		public object Id { get; set; }
	}
}
