using ProjectAPI.Context.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAPI.Context.UnitOfWork
{
    /// <summary>
    /// 
    /// </summary>
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        /// <summary>
        /// 
        /// </summary>
        IMyDbContext context;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public UnitOfWork(IMyDbContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            context.Save();
        }
        /// <summary>
        /// 
        /// </summary>
        private bool DisposeVal = false;
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            if(!DisposeVal)
            {
                context.Dispose();
                DisposeVal = true;
            }
        }
       

    }
}