using System;
using System.Net;

namespace DataAccess
{
	/// <summary>
	/// Implements the IResponse interface.
	/// </summary>
	public interface IResponse<T>
	{
		/// <summary>
		/// Gets or sets the response status.
		/// </summary>
		/// <value>The response status.</value>
		ResponseStatus Status { get; set; }

		/// <summary>
		/// Gets or sets the status description.
		/// </summary>
		/// <value>The status description.</value>
		string StatusDescription { get; set; }

		/// <summary>
		/// Gets or sets the status code returned.
		/// </summary>
		/// <value>The status code.</value>
		StatusCode StatusCode { get; set; }

		/// <summary>
		/// Gets or sets the error message.
		/// </summary>
		/// <value>The error message.</value>
		string ErrorMessage { get; set; }

		/// <summary>
		/// Gets or sets the error exception.
		/// </summary>
		/// <value>The error exception.</value>
		Exception ErrorException { get; set; }

		/// <summary>
		/// Gets or sets the response content.
		/// </summary>
		/// <value>The response content.</value>
		T Content { get; set; }
	}

//	public interface IRestResponse<T> : IResponse<T>
//	{
//		HttpStatusCode HttpStatuCode { get; set; }
//	}
	
}
