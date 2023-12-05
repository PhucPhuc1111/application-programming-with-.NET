using BusinessObjects.Models;

namespace DataAccessObjects.Repository
{
    public interface IMemberReposity
    {
        public List<MemberObject> GetMembers();
        public MemberObject GetMember(int id);
        public MemberObject GetMemberByEmailAndPassWord(string email,string password);
        void InsertMem(MemberObject mem);
        void UpdateMem(MemberObject mem);
        void DeleteMem(MemberObject mem);
    }
}
