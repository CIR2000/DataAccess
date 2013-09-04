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
	}

	/// <summary>
	/// A filter instance.
	/// </summary>
	public class Filter : IFilter
	{
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
