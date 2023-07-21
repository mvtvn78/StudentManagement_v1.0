using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using SinhVienWinForm;
using SinhVienWinForm.Properties;
namespace IOFILE
{
    public static class Account
    {
        private static string path = "account.txt";
        private static string Students = "List.txt";
        public static string GetAccount()
        {
            string result;
            result= File.ReadAllText(path);
            return result;
        }
        public static List<string> GetStudents() 
        {
            List<string> get = new List<string>(File.ReadAllLines(Students));

            return get;
        }
        public static int ChangeStudent(int _index,string newinfo)
        {
            if(_index!=-1)
            {
                List<string> get = new List<string>(File.ReadAllLines(Students));
                get[_index] = newinfo;
                File.WriteAllLines(Students, get);
            }
            return -1;
        }
        public static void AddStudent(string newacc)
        {
          
            
                List<string> get = new List<string>(File.ReadAllLines(Students));
                get.Add(newacc);
                File.WriteAllLines(Students, get);
            
           
        }
        public static int RemoveStudent(int _index)
        {
            if(_index!=-1)
            {
                List<string> get = new List<string>(File.ReadAllLines(Students));
                get.RemoveAt(_index);  
                File.WriteAllLines(Students, get);
                return 1;
            }
            
            return -1;
        }
        public static void  SetAccount(string content )
        {
            File.AppendAllText(path, content);
        }
        public static void ChangePasswd(string account,string newpasswd)
        {
            List<string> accounts = new List<string>(File.ReadAllLines(path));
            int index = accounts.IndexOf(account);
            
            if(index % 2 ==0 )
            {
                accounts[index+1]=newpasswd;
            }
            File.WriteAllLines(path,accounts);
            
        }
    }
}
