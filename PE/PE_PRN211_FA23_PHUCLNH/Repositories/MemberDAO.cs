using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MemberDAO
    {
        //các hàm CRUD của table Member/Account

        //THẰNG REPO BAO GIỜ CŨNG CHƠI VỚI CSDL

        //hàm trả về 1 Account nào đó theo username/email - duy nhất trong table
        //do account thì email/user là duy nhất
        public BookManagementMember? Get(string email)
        {
            BookManagement2023DbContext db = new BookManagement2023DbContext();
            //db đang móc vào CSDL rồi. Có sẵn 3 table, list các data luôn rồi, chờ gọi xài
            return db.BookManagementMembers.FirstOrDefault(x => x.Email == email);             
        }

    }
}
