using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.Repository
{
    public class MemberRepository : IMemberReposity
    {
        public MemberDAO MemberDAO = new MemberDAO();
        public void DeleteMem(MemberObject mem) => MemberDAO.DeleteMember(mem);

        public MemberObject GetMember(int id) => MemberDAO.GetMemberById(id);

        public MemberObject GetMemberByEmailAndPassWord(string email, string password) => MemberDAO.GetMemberByEmailAndPassWord(email, password);

        public List<MemberObject> GetMembers() => MemberDAO.GetMembers();

        public void InsertMem(MemberObject mem) => MemberDAO.SaveMember(mem);

        public void UpdateMem(MemberObject mem) => MemberDAO.UpdateMember(mem);
    }
}
