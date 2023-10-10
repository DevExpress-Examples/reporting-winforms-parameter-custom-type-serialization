using System;
using DevExpress.Xpo;

namespace AdvancedSupportForEnums {
    public enum Title { Mr, Mrs, Miss, Mx }

    public class Person : XPObject {
        public Title PersonTitle { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Person Owner { get; set; }
        public string FirstName { get; set; }
        public Team Team { get; set; }
    }

    public class Team : XPObject {
        public string Name { get; set; }
    }
}
