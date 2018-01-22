using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace SkillTreeMVCHomework.Repositories
{
    public interface IMyUnitOfWork : IDisposable
    {
        DbContext Context { get; set; }
    }
}
