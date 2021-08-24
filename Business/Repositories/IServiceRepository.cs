using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Signatures;

namespace Business.Repositories
{
    public interface IServiceRepository<TDto>
    where TDto:class,IBaseDto,new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TDto> GetAsync(int id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<int> InsertAsync(TDto dto);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// 
        Task UpdateAsync(int id, TDto dto);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(int id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listOfId"></param>
        /// <returns></returns>
        Task DeleteRangeAsync(List<int> listOfId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task RemoveCacheAsync();
    }
}