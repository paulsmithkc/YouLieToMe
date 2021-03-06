﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIES.WebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LiesDatabase : DbContext
    {
        public LiesDatabase()
            : base("name=LiesDatabase")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Message> Messages { get; set; }
    
        public virtual ObjectResult<GetRandomMessages_Result> GetRandomMessages(string templateId, Nullable<int> level)
        {
            var templateIdParameter = templateId != null ?
                new ObjectParameter("TemplateId", templateId) :
                new ObjectParameter("TemplateId", typeof(string));
    
            var levelParameter = level.HasValue ?
                new ObjectParameter("Level", level) :
                new ObjectParameter("Level", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetRandomMessages_Result>("GetRandomMessages", templateIdParameter, levelParameter);
        }
    
        public virtual int InsertDeathes(Nullable<System.Guid> messageId, string templateId, Nullable<int> level, Nullable<int> deaths)
        {
            var messageIdParameter = messageId.HasValue ?
                new ObjectParameter("MessageId", messageId) :
                new ObjectParameter("MessageId", typeof(System.Guid));
    
            var templateIdParameter = templateId != null ?
                new ObjectParameter("TemplateId", templateId) :
                new ObjectParameter("TemplateId", typeof(string));
    
            var levelParameter = level.HasValue ?
                new ObjectParameter("Level", level) :
                new ObjectParameter("Level", typeof(int));
    
            var deathsParameter = deaths.HasValue ?
                new ObjectParameter("Deaths", deaths) :
                new ObjectParameter("Deaths", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertDeathes", messageIdParameter, templateIdParameter, levelParameter, deathsParameter);
        }
    
        public virtual int InsertMessage(string templateId, Nullable<int> level, string text)
        {
            var templateIdParameter = templateId != null ?
                new ObjectParameter("TemplateId", templateId) :
                new ObjectParameter("TemplateId", typeof(string));
    
            var levelParameter = level.HasValue ?
                new ObjectParameter("Level", level) :
                new ObjectParameter("Level", typeof(int));
    
            var textParameter = text != null ?
                new ObjectParameter("Text", text) :
                new ObjectParameter("Text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertMessage", templateIdParameter, levelParameter, textParameter);
        }
    
        public virtual int InsertUpDownVotes(Nullable<System.Guid> messageId, string templateId, Nullable<int> level, Nullable<int> upVotes, Nullable<int> downVotes)
        {
            var messageIdParameter = messageId.HasValue ?
                new ObjectParameter("MessageId", messageId) :
                new ObjectParameter("MessageId", typeof(System.Guid));
    
            var templateIdParameter = templateId != null ?
                new ObjectParameter("TemplateId", templateId) :
                new ObjectParameter("TemplateId", typeof(string));
    
            var levelParameter = level.HasValue ?
                new ObjectParameter("Level", level) :
                new ObjectParameter("Level", typeof(int));
    
            var upVotesParameter = upVotes.HasValue ?
                new ObjectParameter("UpVotes", upVotes) :
                new ObjectParameter("UpVotes", typeof(int));
    
            var downVotesParameter = downVotes.HasValue ?
                new ObjectParameter("DownVotes", downVotes) :
                new ObjectParameter("DownVotes", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUpDownVotes", messageIdParameter, templateIdParameter, levelParameter, upVotesParameter, downVotesParameter);
        }
    }
}
