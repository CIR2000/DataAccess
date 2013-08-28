using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Implements the DataReader abstract.
	/// </summary>
	public abstract class DataReader 
	{
		/// <summary>
		/// Gets or sets the default name of the data source.
		/// </summary>
		/// <value>The name of the data source.</value>
		public string DataSourceName { get; set; }

		/// <summary>
		/// Gets or sets the default authentication.
		/// </summary>
		/// <value>The default authentication.</value>
		public Authentication Authentication { get; set; }

		/// <summary>
		/// Gets the data type mapping.
		/// </summary>
		/// <value>The data type mapping.</value>
		protected virtual Dictionary<string, string> ResourcesToData { get; set; }

		/// <summary>
		/// Parses the filters.
		/// </summary>
		/// <returns>An executable filter command string ready to be issued against the data store.</returns>
		protected  string ParseFilters () {
			return null;
		}

		/// <summary>
		/// Returns one or multiple documents from the datasource.
		/// </summary>
		/// <param name="request">A request instance.</param>
		/// <typeparam name="T">The type to be returned.</typeparam>
		public abstract Response<T> Get<T> (GetRequest request);

		/// <summary>
		/// Returns an individual item from the datasource.
		/// </summary>
		/// <param name="request">A request instance.</param>
		/// <typeparam name="T">The type to be returned.</typeparam>
		public abstract Response<T> Get<T>(GetRequestItem request);

		/// <summary>
		/// Initializes a new instance of the <see cref="DataAccess.DataReader"/> class.
		/// </summary>
		public DataReader() : this(null, null) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="RESTDataAccess.RESTDataReader"/> class.
		/// </summary>
		/// <param name="dataSourceName">Data source name.</param>
		public DataReader(string dataSourceName) : this(dataSourceName, null) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="RESTDataAccess.RESTDataReader"/> class.
		/// </summary>
		/// <param name="auth">Authentication.</param>
		public DataReader(Authentication auth) : this(null, auth) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="RESTDataAccess.RESTDataReader"/> class.
		/// </summary>
		/// <param name="dataSourceName">Data source name.</param>
		/// <param name="auth">Authentication.</param>
		public DataReader(string dataSourceName, Authentication auth)
		{
			DataSourceName = dataSourceName;
			Authentication = auth;
		}
	}

}
