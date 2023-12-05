using BusinessObjects.Models;
namespace DataAccessObjects
{
    public class MemberDAO
    {
        private readonly FstoreContext _context = new FstoreContext();
        public List<MemberObject> GetMembers()
        {
            List<MemberObject> listMembers = null;
            try
            {
                listMembers = _context.Members.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listMembers;
        }

        public MemberObject GetMemberByEmailAndPassWord(string email, string password)
        {
           MemberObject member = _context.Members.SingleOrDefault(x => x.Email.Equals(email));
           return member;
        }
        public MemberObject GetMemberById(int id)
        {
            MemberObject Member = null;
            try
            {
                using (var content = new FstoreContext())
                {
                    Member  = content.Members.SingleOrDefault(x => x.MemberId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Member;
        }

        public void SaveMember(MemberObject p)
        {
            using var _context = new FstoreContext();
            _context.Members.Add(p);
            _context.SaveChanges();
        }

        public void DeleteMember(MemberObject p)
        {
            using var _context = new FstoreContext();
            
            _context.Members.Remove(p);
            _context.SaveChanges();
        }

        public void UpdateMember(MemberObject p)
        {
            using var _context = new FstoreContext();
            _context.Members.Update(p);
            _context.SaveChanges();
        }
    }
}
