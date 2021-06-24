using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SQLConnector : IDataConnection
    {
        public PersonModel CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - make create prize method save to DB
        /// <summary>
        /// saves a new prize to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>the prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;

        }
    }
}
