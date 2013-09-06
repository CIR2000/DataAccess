namespace DataAccess
{
	/// <summary>
	/// Sort.
	/// </summary>
	public class Sort 
	{
        /// <summary>
        /// Base constructor without parameter
        /// </summary>
        public Sort() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="field">Field name for sort</param>
        /// <param name="direction">Direction of sort</param>
        public Sort(string field, SortDirection direction) : this()
        {
            Field = field;
            Direction = direction;
        }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Field { get; set; }

		/// <summary>
		///Gets or sets the direction.
		/// </summary>
		/// <value>The direction.</value>
		public SortDirection Direction { get; set; }
	}

    /// <summary>
    /// Sort directions.
    /// </summary>
    public enum SortDirection
    {
        Ascending,
        Descending,
    }
}
