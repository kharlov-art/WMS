//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMS.BusinessLogic.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserCart
    {
        public int Id { get; set; }
        public int GoodId { get; set; }
        public int Count { get; set; }
        public int UserId { get; set; }
    
        public virtual Good Good { get; set; }
        public virtual User Users { get; set; }
    }
}
