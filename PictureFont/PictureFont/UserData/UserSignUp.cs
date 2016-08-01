using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureFont.UserData
{
  public  class UserSignUp
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassWord { get; set; }
    }
}
