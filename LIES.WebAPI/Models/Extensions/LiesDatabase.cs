using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Data.Entity.Core.EntityClient;

namespace LIES.WebAPI.Models
{
    public partial class LiesDatabase : DbContext
    {
        public LiesDatabase(string connectionString)
            : base(new EntityConnection(connectionString), true)
        {
        }
    }
}