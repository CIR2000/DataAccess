using System;
using System.Net;

namespace DataAccess
{
	public class Response<T> 
	{
		/// <summary>
		/// Gets or sets the response status.
		/// </summary>
		/// <value>The response status.</value>
		public ResponseStatus Status { get; set; }

		/// <summary>
		/// Gets or sets the status description.
		/// </summary>
		/// <value>The status description.</value>
		public string StatusDescription { get; set; }

		/// <summary>
		/// Gets or sets the status code returned.
		/// </summary>
		/// <value>The status code.</value>
		public StatusCode StatusCode { get; set; }

		/// <summary>
		/// Gets or sets the error message.
		/// </summary>
		/// <value>The error message.</value>
		public string ErrorMessage { get; set; }

		/// <summary>
		/// Gets or sets the error exception.
		/// </summary>
		/// <value>The error exception.</value>
		public Exception ErrorException { get; set; }

		/// <summary>
		/// Gets or sets the response content.
		/// </summary>
		/// <value>The response content.</value>
		public T Content { get; set; }
	}

	/// <summary>
	/// Response status.
	/// </summary>
	public enum ResponseStatus
	{
		None,
		Completed,
		Error,
		TimedOut,
		Aborted,
	}

	// TODO
	/// <summary>
	/// Status code.
	/// </summary>
	public enum StatusCode
	{
		Accepted = 202,
		Ambiguous,
		NotAvailable,
	}
}
