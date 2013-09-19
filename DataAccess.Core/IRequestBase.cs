namespace DataAccess
{

	public interface IRequestBase
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
	}
}
