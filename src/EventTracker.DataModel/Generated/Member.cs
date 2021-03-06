//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventTracker.DataModel.Generated
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.EventAttendances = new HashSet<EventAttendance>();
            this.HouseHoldMembers = new HashSet<HouseHoldMember>();
            this.HouseHolds = new HashSet<HouseHold>();
            this.MemberMemberships = new HashSet<MemberMembership>();
            this.Users = new HashSet<User>();
        }
    
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> MembershipDate { get; set; }
        public Nullable<int> SpouseMemberId { get; set; }
        public string SpouseName { get; set; }
        public Nullable<int> FatherMemberId { get; set; }
        public Nullable<int> MotherMemberId { get; set; }
        public bool IsHeadOfFamily { get; set; }
        public string MemberOf { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventAttendance> EventAttendances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HouseHoldMember> HouseHoldMembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HouseHold> HouseHolds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberMembership> MemberMemberships { get; set; }
        //public virtual Member Members1 { get; set; }
        //public virtual Member Member1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
