using System;

namespace ProjectAPI.Context.UnitOfWork
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUnitOfWork:IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        void Save();
    }
}