using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_TPB_API.Data;
using Web_TPB_API.Models;
using Web_TPB_API.Repository.IRepository;

namespace Web_TPB_API.Repository
{
    public class V_ClosingMRepository : IV_ClosingMRepository
    {
        private readonly ApplicationDbContext _db;
        public V_ClosingMRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool CreateV_ClosingM(V_ClosingM v_ClosingM)
        {
            _db.V_ClosingM.Add(v_ClosingM);
            return Save();
        }

        public bool DeleteV_ClosingM(V_ClosingM v_ClosingM)
        {
            _db.V_ClosingM.Remove(v_ClosingM);
            return Save();
        }

        public ICollection<V_ClosingM> GetV_ClosingM()
        {
            return _db.V_ClosingM.OrderBy(a => a.Auto_Id).ToList();
        }

        public V_ClosingM GetV_ClosingM(int V_ClosingMId)
        {
            return _db.V_ClosingM.FirstOrDefault(a => a.Auto_Id == V_ClosingMId);
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateV_ClosingM(V_ClosingM v_ClosingM)
        {
            _db.V_ClosingM.Update(v_ClosingM);
            return Save();
        }

        public bool V_ClosingMExists(string name)
        {
            throw new NotImplementedException();
        }

        public bool V_ClosingMExists(int id)
        {
            return _db.V_ClosingM.Any(a => a.Auto_Id == id);
        }
    }
}
