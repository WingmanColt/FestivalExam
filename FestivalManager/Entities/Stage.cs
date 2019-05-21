using System;
using System.Linq;
using System.Reflection.Metadata;
using FestivalManager.Core.Controllers.Contracts;
using FestivalManager.Entities.Sets;

namespace FestivalManager.Entities
{
	using System.Collections.Generic;
	using Contracts;
    using System.Linq;

    public class Stage : IStage
    {
        // да си вкарват през полетата бе
        private List<ISet> sets;

        private List<ISong> songs;
        private List<IPerformer> performers;


        public Stage()
        {
            this.sets = new List<ISet>();
            this.songs = new List<ISong>();
            this.performers = new List<IPerformer>();
        }

        public IReadOnlyCollection<IPerformer> Performers => this.performers;

        public IReadOnlyCollection<ISong> Songs => this.songs;

        public IReadOnlyCollection<ISet> Sets => this.sets;

       /* private IReadOnlyCollection<ISet> set; // This is the backing field

        public IReadOnlyCollection<ISet> Sets // This is your property
        {
            get { return set; }
            set { set = value; }
        }*/






        public void AddPerformer(IPerformer performer) => this.performers.Add(performer);

        public void AddSong(ISong song) => this.songs.Add(song);

        public void AddSet(ISet set) => this.sets.Add(set);


        public IPerformer GetPerformer(string name)
        {
           var get = this.performers.Find(g => g.Name == name);
            return get;
        }

        public ISong GetSong(string name)
        {
            var get = this.songs.Find(g => g.Name == name);
            return get;
        }

        public ISet GetSet(string name)
        {
            var get = this.sets.Find(g => g.Name == name);
            return get;
        }

   
        public bool HasPerformer(string name)
        {
            bool mExists = this.performers.Any(x => x.Name == name);

            return mExists;
        }

        public bool HasSong(string name)
        {
            bool mExists = this.songs.Any(x => x.Name == name);

            return mExists;
        }

        public bool HasSet(string name)
        {
            bool mExists = this.sets.Any(x => x.Name == name);

            return mExists;
        }
    }

}
