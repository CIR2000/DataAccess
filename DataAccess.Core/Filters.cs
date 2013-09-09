using System.Collections.Generic;

namespace DataAccess
{

	/// <summary>
	/// The common IFilter interface used by both FiltersGroup and Filter instances.
	/// </summary>
	public interface IFilter
	{
		/// <summary>
		/// Gets or sets the concatenator between this item and the next IFilter.
		/// </summary>
		/// <value>The concatenator.</value>
		Concatenation Concatenator { get; set; }
	}

	/// <summary>
	/// A group of IFilter implementations.
	/// </summary>
	public class FiltersGroup : IFilter
	{
		/// <summary>
		/// Gets or sets the filters.
		/// </summary>
		/// <value>The filters.</value>
		public List<IFilter> Filters { get; set; }

		/// <summary>
		/// Gets or sets the concatenator between this group and the next IFilter.
		/// </summary>
		/// <value>The concatenator.</value>
		public Concatenation Concatenator { get; set; }

		public FiltersGroup()
		{
			Filters = new List<IFilter> ();
			Concatenator = Concatenation.And;
		}
	}

	/// <summary>
	/// A filter instance.
	/// </summary>
	public class Filter : IFilter
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DataAccess.Filter"/> class.
		/// </summary>
        public Filter() { }

        /// <summary>
		/// Initializes a new instance of the <see cref="DataAccess.Filter"/> class.
        /// </summary>
        /// <param name="field">Field name for filter</param>
        /// <param name="comparator">Comparator operator</param>
        /// <param name="value">Value for comparison</param>
        public Filter(string field, Comparison comparator, object value) : this ()
        {
            Field = field;
            Comparator = comparator;
            Value = value;
        }

        /// <summary>
        /// Constructor with all parameter
        /// </summary>
        /// <param name="field">Field name for filter</param>
        /// <param name="comparator">Comparator operator</param>
        /// <param name="value">Value for comparison</param>
        /// <param name="concatenator">Operator of concatenation with next filter</param>
        public Filter(string field, Comparison comparator, object value, Concatenation concatenator) : this(field, comparator, value)
        {
            Concatenator = concatenator;
        }

		/// <summary>
		/// Gets or sets the field name.
		/// </summary>
		/// <value>The name.</value>
		public string Field { get; set;}

		/// <summary>
		/// Gets or sets the desired field value.
		/// </summary>
		/// <value>The value.</value>
		public object Value { get; set; }

		/// <summary>
		/// Gets or sets the filter operator.
		/// </summary>
		/// <value>The operator.</value>
		public Comparison Comparator { get; set; }

		/// <summary>
		/// Gets or sets the concatenator between this filter and the next IFilter.
		/// </summary>
		/// <value>The concatenation.</value>
		public Concatenation Concatenator { get; set; }
	}

    /// <summary>
    /// Comparison operators.
    /// </summary>
    public enum Comparison
    {
        BeginsWith,
        Contains,
        NotEqual,
        EndsWith,
        GreaterThan,
        GreaterThenOrEqual,
        LessThan,
        LessThanOrEqual,
        NotContains,
        Equal,
    }

    /// <summary>
    /// Concatenation operators.
    /// </summary>
    public enum Concatenation
    {
        And,
        Or,
    }
}
