using System;
using System.Collections.Generic;

namespace DataAccess.Core
{
	public interface ICreateRequest<T> : IRequest
	{
		T Data { get; set; }
		bool IgnoreNull { get; set; }
		// empty strings are considered values to be stored
	}

	public interface IUpdateRequest : IRequest
	{
		// empty strings are considered values to be stored

		void AddUpdate (object Obj);
		void AddUpdate (int objectId, string IfNoneMatch, string field, object value);
//		void AddReplacement (int objiectId, object Obj);

	}

	public interface IUPdateRequest1<T> : IRequest
	{
//		string IfNoneMatch { get; set; }
//		int ItemId { get; set; }
		T Obj { get; set; }
		Dictionary <string, object> updates { get; set; }
//		Update Values { get; set; }

	}

	enum Update
	{
		All,
		NotNull,
	}
}

