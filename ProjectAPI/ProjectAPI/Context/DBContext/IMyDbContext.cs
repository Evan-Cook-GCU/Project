using ProjectAPI.Models;
using System.Data.Entity;

namespace ProjectAPI.Context.DBContext
{
    public interface IMyDbContext
    {
        /// <summary>
        /// 
        /// </summary>
        //IDbSet<VarianceFormDomainModel> VarianceForm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //IDbSet<WorkOrderDomainModel> WorkOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //IDbSet<VarianceCodeDomainModel> VarianceCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int Save();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<int> SaveAsync();
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IDbSet<T> Set<T>() where T : class, IEntity;
        /// <summary>
        /// 
        /// </summary>
        void Dispose();
    }
}
