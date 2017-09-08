using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8.Mentor_Group
{
    class User
    {
        public string Name { get; set; }
        public List<DateTime> DatesAttended { get; set; }
        public List<string> Comments { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            ReadDates(users);
            ReadComments(users);
        }

        private static void ReadComments(List<User> users)
        {
            var line = Console.ReadLine();
            while (line != "end of comments")
            {
                line = Console.ReadLine();
            }
        }

        private static void ReadDates(List<User> users)
        {
            var line = Console.ReadLine();
            while (line != "end of dates")
            {
                var tokens = line.Split();
                var username = tokens[0];
                List<DateTime> datesAttended = new List<DateTime>();
                if (tokens.Count() > 1)
                {
                    var dates = tokens[1].Split(',').ToList();
                    
                    foreach (var date in dates)
                    {
                        datesAttended.Add(DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                }
                if (users.Any(x => x.Name == username))
                {
                    User user = users.First(s => s.Name == username);
                    user.DatesAttended = user.DatesAttended.Concat(datesAttended).ToList();
                }
                else
                {
                    User user = new User();
                    user.Name = username;
                    user.DatesAttended = new List<DateTime>();
                    user.DatesAttended = datesAttended;
                    users.Add(user);
                }
                line = Console.ReadLine();
            }
        }
    }
}
