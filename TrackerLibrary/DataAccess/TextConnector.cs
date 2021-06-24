using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary;
using TrackerLibrary.DataAccess.TextConnector;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModel.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPeopleModel();
            int currentID = 1;
            if (people.Count>1)
            {
                currentID = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentID;
            people.Add(model);
            people.SaveToPeopleFile(PeopleFile);
            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {    
            // Load text file
            //convert text to list of prize model
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            //find max id
            int currentID = 1;
            if (prizes.Count>0)
            {
                currentID = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentID;
            //add new record with new id | max+1
            prizes.Add(model);
            //convert prizes to list of  string
            //save list of string to text file
            prizes.SaveToPrizeModel(PrizesFile);

            return model;
        }


    }
}