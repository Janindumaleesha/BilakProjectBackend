using BilakProjectBackend.Models;

namespace BilakProjectBackend.Services
{
    public class EbillService : IEbill
    {
        private readonly BilakDbContext _context = new BilakDbContext();
        public Ebill CreateEbill(Ebill ebill)
        {
            _context.Ebills.Add(ebill);
            _context.SaveChanges();
            return ebill;
        }

        public void DeleteEbill(int id)
        {
            var ebill = _context.Ebills.FirstOrDefault(eb => eb.Id == id);
            if (ebill != null)
            {
                _context.Ebills.Remove(ebill);
                _context.SaveChanges();
            }
        }

        public Ebill GetEbillById(int id)
        {
            var ebill = _context.Ebills.FirstOrDefault(eb => eb.Id == id);
            if (ebill != null)
            {
                return ebill;
            }
            return null;
        }

        public List<Ebill> GetEbills()
        {
            return _context.Ebills.ToList();
        }

        public void UpdateEbill(int id, Ebill ebill)
        {
            var updateEbill = _context.Ebills.FirstOrDefault(eb => eb.Id == id);
            if (updateEbill != null)
            {
                _context.Ebills.Update(updateEbill);
                _context.SaveChanges();
            }
        }
    }
}
