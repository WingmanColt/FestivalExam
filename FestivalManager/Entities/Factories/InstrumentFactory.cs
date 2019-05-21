namespace FestivalManager.Entities.Factories
{
	using System;
	using System.Linq;
	using System.Reflection;
	using System.Runtime.InteropServices.WindowsRuntime;
	using Contracts;
	using Entities.Contracts;
	using Instruments;

	public class InstrumentFactory : IInstrumentFactory
	{
		public IInstrument CreateInstrument(string type)
		{
			if (type == "Drums")
			{
				return new Drums();
			}
			else if (type == "Guitar")
			{
				return new Guitar();
			}
			else if (type == "")
			{
                return new Microphone();
			}

		    Type INSType = this.GetInstrumentType(type);
		    return (IInstrument)Activator.CreateInstance(INSType);
        }
	    private Type GetInstrumentType(string Name)
	    {
	        Type[] assemblyTypes = Assembly
	            .GetExecutingAssembly()
	            .GetTypes();

	        return assemblyTypes.FirstOrDefault(t => t.Name == Name);
	    }
    }
}