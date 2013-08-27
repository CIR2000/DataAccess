using System;

namespace DataAccess
{
#region Filters/Sorting
	/// <summary>
	/// Comparison operators.
	/// </summary>
	public enum ComparisonOperator
    {
        BeginsWith,
        Contains,
        Different,
        Empty,
        EndsWith,
        GreaterThan,
        GreaterThenOrEqual,
        LessThan,
        LessThanOrEqual,
        NotContains,
        NotEmpty,
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

	/// <summary>
	/// Sort directions.
	/// </summary>
	public enum SortDirection
    {
        Ascending,
        Descending,
    }
#endregion

#region Responses
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
#endregion
}

