using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookManagementMemberService
    {

        //class này sẽ chơi với cả 2 bên: 
        //Với UI thì nó đưa data cho UI render hiển thị
        //hoặc nó lấy data từ UI (user input vào)

        //nó xử lí gì đó, có thể cần gọi Repository làm việc với DB
        //hàm của thằng này đặt tên gần với con người hơn: CheckLogin()
        //Repo đặt tên gần database hơn: Get() Create()

        public BookManagementMember? CheckLogin(string email, string password)
        {
            MemberDAO repo = new MemberDAO();

            BookManagementMember account = repo.Get(email); //tìm accoun theo email

            //if (account == null)
            //    return null; //email ko tồn tai
            //if (account.Password == password)
            //    return account;
            //return null;

            return account != null && account.Password == password ? account : null;
        } 

    }
}
