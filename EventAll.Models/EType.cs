using System.Collections.Generic;

namespace EventAll.Models
{
    public class EType
    {
        public EType()
        {
            EActivity = new HashSet<EActivity>();
        }

        public int Id { get; set; }
        public string NameType { get; set; }

        public ICollection<EActivity> EActivity { get; set; }
    }
}
