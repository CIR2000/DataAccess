namespace DataAccess
{
	/// <summary>
	/// Implements the data request interface.
	/// </summary>
	public abstract class RequestBase
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
	}
}
