using System.Collections.Generic;

namespace EventAll.Models
{
    public class EHost
    {
        public EHost()
        {
            EActivity = new HashSet<EActivity>();
        }

        public int Id { get; set; }
        public int Dni { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<EActivity> EActivity { get; set; }
    }
}
