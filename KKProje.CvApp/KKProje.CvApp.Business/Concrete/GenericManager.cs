using KKProje.CvApp.Business.Interfaces;
using KKProje.CvApp.DataAccess.Interfaces;
using KKProje.CvApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKProje.CvApp.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        private readonly IGenericRepository<TEntity> _genericService;

        public GenericManager(IGenericRepository<TEntity> genericService)
        {
            _genericService = genericService;
        }

        public void Delete(TEntity entity)
        {
            _genericService.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _genericService.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _genericService.GetById(id);
        }

        public void Insert(TEntity entity)
        {
            _genericService.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _genericService.Update(entity);
        }
    }
}
