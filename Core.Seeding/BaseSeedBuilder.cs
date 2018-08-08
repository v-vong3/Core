using Core.Seeding.Contract;
using Core.Seeding.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seeding
{
    public abstract class BaseSeedBuilder : ISeedBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract Task<ISeedSource> BuildAsync();


        public ISeedBuilder AddDatum(params ISeedDatum[] seedData)
        {
            throw new NotImplementedException();
        }

        public ISeedBuilder AddScript(params string[] scriptFilenames)
        {
            throw new NotImplementedException();
        }

        

        public ISeedBuilder Clear(bool includeScripts)
        {
            throw new NotImplementedException();
        }

        public ISeedBuilder RemoveDatum(Type type)
        {
            throw new NotImplementedException();
        }

        public ISeedBuilder RemoveScript(string scriptFilename)
        {
            throw new NotImplementedException();
        }
    }
}
