using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace point_counter_for_uni
{
    static class databaseHandler
    {
        static point_counterEntities1 context = new point_counterEntities1();
        static public List<University> getUnis()
        {
            List<University> rtn;
            try
            {
                rtn = (from x in context.Universities
                       select x).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return rtn;
        }
        static void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        static public bool login(string NEPTUN, string pass)
        {
            string hash = CalcSha256(pass);
            try
            {
                var smth = (from x in context.Students
                            where x.NEPTUN == NEPTUN && x.Password == hash 
                            select x).FirstOrDefault();
                if (smth == null)
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return true;
        }
        static public void RegisterUniversity(string ID, string name)
        {
            University temp = new University()
            {
                Uni_ID = ID,
                Name = name
            };
            context.Universities.Add(temp);
            Save();
        }
        static public void Reg(string neptun, string pass, string name)
        {
            Student temp = new Student()
            {
                NEPTUN = neptun,
                Name = name,
                Password = CalcSha256(pass),

            };
            context.Students.Add(temp);
            Save();
        }
        static string CalcSha256(string data)
        {
            SHA256 chash = SHA256.Create();
            byte[] bytes = chash.ComputeHash(Encoding.UTF8.GetBytes(data));
            string rtn = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                rtn += bytes[i].ToString("x2");
            }
            return rtn;
        }
    }
}
