using System.Collections.Generic;

namespace EventAll.Models
{
    public class EPay
    {
        public EPay()
        {
            EActivity = new HashSet<EActivity>();
        }

        public int Id { get; set; }
        public string TypeOfPay { get; set; }

        public ICollection<EActivity> EActivity { get; set; }
    }
}
