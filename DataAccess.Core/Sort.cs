namespace DataAccess
{
	/// <summary>
	/// Sort.
	/// </summary>
	public class Sort 
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DataAccess.Sort"/> class.
		/// </summary>
        public Sort() 
		{
			Direction = SortDirection.Ascending;
		 }

		/// <summary>
		/// Initializes a new instance of the <see cref="DataAccess.Sort"/> class.
		/// </summary>
		/// <param name="field">Field.</param>
		/// <param name="direction">Direction.</param>
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
