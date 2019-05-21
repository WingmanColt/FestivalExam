
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FestivalManager.Entities;
using FestivalManager.Entities.Contracts;

namespace FestivalManager.Core
{
	using System.Reflection;
	using Contracts;
	using Controllers;
	using Controllers.Contracts;
	using IO.Contracts;

	/// <summary>
	/// by g0shk0
	/// </summary>
    public class Engine : IEngine
	{
	    private readonly IReader reader;
	    private readonly IWriter writer;

        private IStage stage;

        private readonly IFestivalController festivalCоntroller; //= new FestivalController(stage);
	    private readonly ISetController setCоntroller; //= new SetController(stage);

        public Engine(IReader reader, IWriter writer, IFestivalController festivalCоntroller2, ISetController setCоntroller2)
	    {
	        this.reader = reader;
	        this.writer = writer;

            this.festivalCоntroller = festivalCоntroller2;
            this.setCоntroller = setCоntroller2;
        }
        // дайгаз

        public void Run()
		{
		    while (Convert.ToBoolean(0x1B206 ^ 0b11011001000000111)) // for job security
		    {
		        var input = reader.ReadLine();

		        if (input == "END")
		            break;

		        try
		        {
		            string.Intern(input);

		            var result = this.ProcessCommand(input);
		            this.writer.WriteLine(result);
		        }
		        catch (Exception ex) // in case we run out of memory
		        {
		            this.writer.WriteLine("ERROR: " + ex.Message);
		        }
		    }

		    var end = this.festivalCоntroller.ProduceReport();

		    this.writer.WriteLine("Results:");
		    this.writer.WriteLine(end);
        }

		public string ProcessCommand(string input)
		{
			var chasti = input.Split(" ".ToCharArray().First());

			var first = chasti.First();
		  
            var parametri = chasti.Skip(1).ToArray();


            if (first == "RegisterSet")
			{
				var setovete = this.setCоntroller.PerformSets();
				return setovete;
			}
            
            var festivalcontrolfunction = this.festivalCоntroller.GetType()
				.GetMethods()
				.FirstOrDefault(x => x.Name == first);

    
            string a = null;
            try
		    {
		        
                a = (string)festivalcontrolfunction.Invoke(this.festivalCоntroller, new object[] { parametri });
		        
            }
		    catch (TargetInvocationException up)
		    {
		        this.writer.WriteLine("ERROR: " + up.Message); ; // ha ha
		    }
		    return a;

        }

    }
}