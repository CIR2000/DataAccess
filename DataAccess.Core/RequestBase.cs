namespace DataAccess
{
	/// <summary>
	/// Implements the data request interface.
	/// </summary>
	public abstract class RequestBase
	{

		/// <summary>
		/// Gets or sets the data source.
		/// </summary>
		/// <value>The data source.</value>
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
