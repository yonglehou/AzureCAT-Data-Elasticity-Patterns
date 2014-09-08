//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AzureCat.Patterns.DataElasticity.SQLAzure.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Server
    {
        public Server()
        {
            this.Databases = new HashSet<Database>();
            this.ShardSets = new HashSet<ShardSet>();
        }
    
        public int ServerID { get; set; }
        public string Location { get; set; }
        public string ServerName { get; set; }
        public int MaxShardsAllowed { get; set; }
    
        public virtual ICollection<Database> Databases { get; set; }
        public virtual ICollection<ShardSet> ShardSets { get; set; }
    }
}