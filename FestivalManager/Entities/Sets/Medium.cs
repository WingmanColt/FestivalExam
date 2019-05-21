using FestivalManager.Entities.Contracts;

namespace FestivalManager.Entities.Sets
{
	using System;

	public class Medium : ConcertSet, ISet
	{
		public Medium(string name)
			: base(name, new TimeSpan(0, 40, 0))
		{
		    
		}
	}
}