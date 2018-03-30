using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class DBPopulator
    {
        public static void PopulateDatabase()
        {
            using (var ctx = new Entities())
            {
                var userClearences = new List<UserClearence>
                {
                    new UserClearence{ID = 1, }
                };

                var datasetClearences = new List<DatasetClearence> { };

                var clearences = new List<Clearence>
                {
                    new Clearence
                    {
                        ID = 1,
                        ClearenceName = "Read",
                        UserClearences = ctx.UserClearences.Where(x => x.ClearenceID == 1).ToList()
                    },
                };

                var users = new List<User>
                {
                    new User
                    {
                        ID = 1,
                        Email = "qwe@gmail.com",
                        PasswordHash = "asdf",
                        UserName = "qwe",
                        UserClearences = ctx.UserClearences.Where(x => x.UserID == 1).ToList()
                    },
                };

                var datasets = new List<Dataset> { };

                var dbUsers = ctx.Set<User>();

                ctx.SaveChanges();
            }
        }
    }
}
