using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SkillTreeMVCHomework.Models;

namespace SkillTreeMVCHomework.Repositories
{
    public class EFUnitOfWork : IMyUnitOfWork
    {
        public DbContext Context { get; set; }

        public EFUnitOfWork()
        {
            Context = new SkillTreeHomeworkContext();
        }
     
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}