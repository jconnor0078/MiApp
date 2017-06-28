using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.Users.Dto
{
    public class newUserListDto
    {
        public string Result { get; set; }
        public List<UserListDto> Options { get; set; }
    }
}
