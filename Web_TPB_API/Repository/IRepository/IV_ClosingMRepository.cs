using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_TPB_API.Models;

namespace Web_TPB_API.Repository.IRepository
{
    public interface IV_ClosingMRepository
    {
        ICollection<V_ClosingM> GetV_ClosingM();
        V_ClosingM GetV_ClosingM(int V_ClosingMId);
        bool V_ClosingMExists(string name);
        bool V_ClosingMExists(int id);
        bool CreateV_ClosingM(V_ClosingM v_ClosingM);
        bool UpdateV_ClosingM(V_ClosingM v_ClosingM);
        bool DeleteV_ClosingM(V_ClosingM v_ClosingM);
        bool Save();
    }
}
