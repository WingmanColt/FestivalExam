using FestivalManager.Entities.Contracts;

namespace FestivalManager.Entities.Sets
{
	using System;

	public class Long : ConcertSet, ISet
	{
		public Long(string name) 
			: base(name, new TimeSpan(0, 60, 0))
		{
		}
	}
}