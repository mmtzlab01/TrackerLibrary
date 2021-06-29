using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using TrackerLibrary;

namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        private const string db = "Tournaments";
        public PersonModel CreatePerson(PersonModel model)
        {
            /*            using (IDataConnection connection = new System.Data.SqlClient.SqlConnection(Globalconfig.CnnString(db)))
                        {
                            var p = new DynamicParameters();
                            p.Add("@FirstName", model.FirstName);
                            p.Add("@LastName", model.LastName);
                            p.Add("@EmailAddress", model.EmailAddress);
                            p.Add("@CellPhoneNumber", model.CellPhoneNumber);
                            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                        }*/
            throw new NotImplementedException();
        }
        public PrizeModel CreatePrize(PrizeModel model)
        {
            /*            using (IDataConnection connection = new System.Data.SqlClient.SqlConnection(Globalconfig.CnnString(db)))
                        {
                            var p = new DynamicParameters();
                            p.Add("@PlaceNumber", model.FirstName);
                            p.Add("@LastName", model.LastName);
                            p.Add("@EmailAddress", model.EmailAddress);
                            p.Add("@CellPhoneNumber", model.CellPhoneNumber);
                            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        }*/
            throw new NotImplementedException();
        }
        public TeamModel CreateTeam(TeamModel model)
        {
            
            throw new NotImplementedException();
        }

        public List<PersonModel> GetPerson_All()
        {
            throw new NotImplementedException();
            //return PeopleFile.FullFilePath().Loadfile().ConvertToPersonModels;
        }
    }

        public TeamModel CreateTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetPerson_All()
        {
            throw new NotImplementedException();
        }
    }
