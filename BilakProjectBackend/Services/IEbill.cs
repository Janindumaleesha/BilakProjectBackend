using BilakProjectBackend.Models;

namespace BilakProjectBackend.Services
{
    public interface IEbill
    {
        public List<Ebill> GetEbills();
        public Ebill GetEbillById(int id);
        public Ebill CreateEbill(Ebill ebill);
        public void UpdateEbill(int id, Ebill ebill);
        public void DeleteEbill(int id);
    }
}
