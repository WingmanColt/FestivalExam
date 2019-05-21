using System;

using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace FestivalManager.Entities.Factories
{
	using Contracts;
	using Entities.Contracts;
	using Sets;
	using System.Reflection;

    public class SetFactory : ISetFactory
	{
        public ISet CreateSet(string name, string type)
		{
			if (type == "Short")
			{
				return new Short(name);
			}
			else if (type == "Medium")
			{
				return new Medium(name);
			}
			else if (type == "Long")
			{
			    return new Long(name);
			}


		    Type INSType = this.GetSetType(type);
		    return (ISet)Activator.CreateInstance(INSType, name);
        }

	    private Type GetSetType(string Name)
	    {
	        Type[] assemblyTypes = Assembly
	            .GetExecutingAssembly()
	            .GetTypes();

	        return assemblyTypes.FirstOrDefault(t => t.Name == Name);
	    }
    }



}


