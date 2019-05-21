using FestivalManager.Entities.Contracts;

namespace FestivalManager.Entities.Sets
{
	using System;

	public class Short : ConcertSet, ISet
	{
		public Short(string name) 
			: base(name, new TimeSpan(0, 15, 0))
		{
		}
	}
}