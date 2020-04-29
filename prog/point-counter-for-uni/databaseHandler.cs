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
        static public List<string> getYearsByNeptun()
        {
            List<string> rtn = new List<string>();
            try
            {
                rtn = (from x in context.Points
                       where x.StudxSub.NEPTUN_FK == user.NEPTUN
                       select x.StudxSub.Subject.Year).Distinct().ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return rtn;
        }
        static public List<summarized> filteredSummarizedPoints(string uni, string year)
        {
            List<summarized> rtn = new List<summarized>();
            try
            {
                rtn = (from p in context.Points
                       where p.StudxSub.NEPTUN_FK == user.NEPTUN
                       && p.StudxSub.Subject.Subject_name.University.Name.Contains(uni)
                       && p.StudxSub.Subject.Year.Contains(year)
                       group p by p.StudxSub.Subject into g
                       select new summarized()
                       {
                           Tárgy_név = g.Key.Subject_name.Name,
                           Év = g.Key.Year,
                           Egyetem = g.Key.Subject_name.Uni_FK,
                           Pont = g.Sum(f => f.Point1),
                           kettes = g.Key.elegseges,
                           harom = g.Key.kozepes,
                           negy = g.Key.jo,
                           öt = g.Key.jeles
                       }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            foreach (summarized item in rtn)
            {
                item.CalcJegy();
            }
            return rtn;
        }
        static public List<string> getUnisByNEPTUN()
        {
            List<string> rtn = new List<string>();
            try
            {
                rtn = (from x in context.StudentxUniversities
                       where x.NEPTUN_FK == user.NEPTUN
                       select x.Uni_FK).ToList();


            }
            catch (Exception)
            {
                throw;
            }
            return rtn;
        }
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
