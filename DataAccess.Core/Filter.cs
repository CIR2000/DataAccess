using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Filter used by IGetRequest implementations.
	/// </summary>
	public class Filter
	{
		/// <summary>
		/// Gets or sets the field name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set;}

		/// <summary>
		/// Gets or sets the desired field value.
		/// </summary>
		/// <value>The value.</value>
		public object Value { get; set; }

		/// <summary>
		/// Gets or sets the filter operator.
		/// </summary>
		/// <value>The operator.</value>
		public ComparisonOperator Operator { get; set; }

		/// <summary>
		/// Gets or sets the concatenation.
		/// </summary>
		/// <value>The concatenation.</value>
		public ConcatenationOperator Concatenation { get; set; }

        /// <summary>
        /// IList of filter objects children of filter that contains them
        /// </summary>
        /// /// <value>List of filter objects</value>
        public IList<Filter> Filters { get; set; }
	}

    /// <summary>
    /// Comparison operators.
    /// </summary>
    public enum ComparisonOperator
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
    public enum ConcatenationOperator
    {
        And,
        Or,
    }
}
