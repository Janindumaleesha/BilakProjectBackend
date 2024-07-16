using BilakProjectBackend.Models;

namespace BilakProjectBackend.Services
{
    public interface IEbill
    {
        public List<Ebill> GetEbills();
        public Ebill GetEbillById(int id);
        public Ebill CreateEbill(Ebill ebill);
        public Ebill UpdateEbill(Ebill ebill);
        public Ebill DeleteEbill(int id);
    }
}
