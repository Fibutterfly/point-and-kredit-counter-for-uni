using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace point_counter_for_uni
{
    static class databaseHandler
    {
        static point_counterEntities1 context = new point_counterEntities1();
        static public void add_studname(string kod ,string name, string uni)
        {
            Subject_name sn = new Subject_name()
            {
                Name = name,
                Uni_FK = uni,
                SubCode_ID = kod
            };
            context.Subject_name.Add(sn);
            Save();
        }
        static public void add_újtárgy(string tárgy_kód, string tár_név, object egyetem, string kettes, string hármas, string négyes, string ötös, object aláírás, List<add_max> újtípuses, string year, string semester)
        {
            add_studname(tárgy_kód, tár_név, (string)egyetem);
            int sub_sk = add_subject(tárgy_kód, kettes, hármas, négyes, ötös, aláírás, year, semester);
            foreach (add_max item in újtípuses)
            {
                Max_type_points mtp = new Max_type_points()
                {
                    Sub_FK = sub_sk,
                    PT_FK = item.Típus_id,
                    max = item.Max,
                    min = item.Min

                };
                context.Max_type_points.Add(mtp);
                Save();
            }

        }

        private static int add_subject(string tárgy_kód, string kettes, string hármas, string négyes, string ötös, object aláírás, string year, string semester)
        {
            alairas alairas = (alairas)aláírás;
            Subject sub = new Subject()
            {
                SubCode_FK = (string)tárgy_kód,
                Year = (string)$"{year}/{semester}",
                elegseges = (int?)int.Parse(kettes),
                kozepes = (int?)int.Parse(hármas),
                jo = (int?)int.Parse(négyes),
                jeles = (int?)int.Parse(ötös),
                alairas = (bool)alairas.Value
            };
            context.Subjects.Add(sub);
            Save();
            return sub.Sub_SK;
            
        }

        static public List<point_types> GetPoint_Types()
        {
            List<point_types> rtn = new List<point_types>();
            try
            {
                rtn = (from pt in context.point_types
                       select pt).ToList(); ;
            }
            catch (Exception)
            {

                throw;
            }
            return rtn;
        }
        static public List<subject_chooser> GetSubject_Choosers(string kód, string név)
        {
            List<subject_chooser> rtn = new List<subject_chooser>();
            try
            {
                var querry = from sub in context.Subjects
                             where sub.SubCode_FK.Contains(kód)
                             && sub.Subject_name.Name.Contains(név)
                             select sub;
                var denie = from sxs in context.StudxSubs
                            where sxs.NEPTUN_FK == user.NEPTUN
                            select sxs.Sub_FK;
                foreach (var item in querry)
                {
                    if (denie.Contains(item.Sub_SK))
                    {
                        continue;
                    }
                    subject_chooser sch = new subject_chooser()
                    {

                        Aláírásos = (item.alairas) ? ("Aláírásos") : ("Nem aláírásos"),
                        Elégséges = (item.elegseges == null) ? ("Nem tudjuk") : (item.elegseges.ToString()),
                        Jeles = (item.jeles == null) ? ("Nem tudjuk") : (item.jeles.ToString()),
                        Jó = (item.jo == null) ? ("Nem tudjuk") : (item.jo.ToString()),
                        Közepes = (item.kozepes == null) ? ("Nem tudjuk") : (item.kozepes.ToString()),
                        Tárgy_kód = item.SubCode_FK,
                        Tárgy_név = item.Subject_name.Name,
                        Uni = item.Subject_name.Uni_FK
                    };
                    rtn.Add(sch);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return rtn;
        }
        static public void addStudxuni(string uni)
        {
            StudentxUniversity sxu = new StudentxUniversity()
            {
                NEPTUN_FK = user.NEPTUN,
                Uni_FK = uni
            };
            context.StudentxUniversities.Add(sxu);
            Save();
        }
        
        static public List<University> GetUniversities()
        {
            
            List<University> rtn = new List<University>();
            try
            {
                //rtn = (from u in context.Universities
                //       where u.StudentxUniversities.Select(x => x.NEPTUN_FK).FirstOrDefault() != user.NEPTUN

                //       select u).ToList();
                //rtn = (from sxu in context.StudentxUniversities
                //       join u in context.Universities on sxu.Uni_FK equals u.Uni_ID
                //       //where sxu.NEPTUN_FK != user.NEPTUN
                //       select u).ToList();
                var querry = from u in context.Universities
                             select u;
                var used = (from sxu in context.StudentxUniversities
                           where sxu.NEPTUN_FK == user.NEPTUN
                           select sxu.Uni_FK).ToList();

                foreach (var item in querry)
                {
                    if (!used.Contains(item.Uni_ID))
                    {
                        rtn.Add(item);

                    }
                    //University temp = new University()
                    //{
                    //    Name = item.Name,
                    //    Uni_ID = item.Uni_id
                    //};
                }
            }
            catch (Exception)
            {
                throw;
            }
            return rtn;
        }
        static public void del_point(Point delete)
        {
            context.Points.Remove(delete);
            Save();
        }
        static public void New_point(int pont, int studxsub, int act_sk, DateTime nap)
        {
            Point p = new Point()
            {
                Point1 = pont,
                StudxSub_FK = studxsub,
                PT_FK = act_sk,
                datum = nap
            };
            context.Points.Add(p);
            Save();
        }
        static public Point GetPointByPoint_SK(int point_sk)
        {
            Point rtn = new Point();
            try
            {
                rtn = (from p in context.Points
                       where p.Point_SK == point_sk
                       
                       select p).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            return rtn;
        }
        static public List<Point> getPointsBySummarize(int act_sk)
        {
            List<Point> rtn = new List<Point>();
            try
            {
                rtn = (from p in context.Points
                      where p.PT_FK == act_sk
                      && p.StudxSub.NEPTUN_FK == user.NEPTUN
                      select p).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return rtn;
        }
        static public List<sum_by_types> getFilteredSummarizedPoints(int studxsub)
        {
            List<sum_by_types> rtn = new List<sum_by_types>();
            try
            {
                rtn = (from ss in context.StudxSubs
                       join s in context.Subjects on ss.Sub_FK equals s.Sub_SK
                       join mtp in context.Max_type_points on s.Sub_SK equals mtp.Sub_FK
                       where
                         ss.StudxSub_SK == studxsub
                         && ss.NEPTUN_FK == user.NEPTUN
                       select new sum_by_types()
                       {
                           Pont_id = mtp.Act_max_SK,
                           Pont_nev = mtp.point_types.PT_name,
                           Min = mtp.min,
                           Max = mtp.max,
                           //Pont = mtp.Points.Sum(x => x.Point1)
                           Pont = mtp.Points.Where(y => y.StudxSub.NEPTUN_FK == user.NEPTUN).Sum(x => x.Point1)
                       }).ToList();


            }
            catch (Exception)
            {

                throw;
            }
            return rtn;
        }
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
        static public int getsubxstudfiltered(string ev, string nev)
        {
            int rtn = 0;
            try
            {
                rtn = (from x in context.StudxSubs
                       where x.NEPTUN_FK == user.NEPTUN
                       && x.Subject.Year == ev
                       && x.Subject.Subject_name.Name == nev
                       select x.StudxSub_SK).FirstOrDefault();
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
                var query = (from ss in context.StudxSubs
                             join p in context.Points on new { StudxSub_FK = ss.StudxSub_SK } equals new { StudxSub_FK = p.StudxSub_FK } into p_join
                             from p in p_join.DefaultIfEmpty()
                             where ss.NEPTUN_FK == user.NEPTUN
                                && ss.Subject.Year.Contains(year)
                                && ss.Subject.Subject_name.Uni_FK.Contains(uni)
                             group new { ss.Subject.Subject_name, ss.Subject, p } by new
                             {
                                 ss.Subject.Subject_name.Name,
                                 ss.Subject.Year,
                                 ss.Subject.Subject_name.Uni_FK
                             } into g
                             select new summarized()
                             {
                                 Tárgy_név = g.Key.Name,
                                 Év = g.Key.Year,
                                 Egyetem = g.Key.Uni_FK,
                                 Pont = (g.Sum(p => p.p.Point1) == null) ? (0) : (g.Sum(p => p.p.Point1)),
                                 kettes = g.Select(p => p.Subject.elegseges).FirstOrDefault(),
                                 harom = g.Select(p => p.Subject.kozepes).FirstOrDefault(),
                                 negy = g.Select(p => p.Subject.jo).FirstOrDefault(),
                                 öt = g.Select(p => p.Subject.jeles).FirstOrDefault()
                             }).ToList();
                rtn = query;
                //rtn = (from ss in context.StudxSubs
                //       join sn in context.Subject_name on ss.Subject.SubCode_FK equals sn.SubCode_ID into ss_sn
                //       from sssn in ss_sn.DefaultIfEmpty()
                //       join s in context.Subjects on sssn.SubCode_ID equals s.SubCode_FK into sssn_s
                //       from sssns in sssn_s.DefaultIfEmpty()
                //       join p in context.Points on ss.StudxSub_SK equals p.StudxSub_FK into sssns_p
                //       from sssnsp in sssns_p.DefaultIfEmpty()
                //       group sssnsp by new { sssnsp.StudxSub.Subject.Subject_name.Name, sssnsp.StudxSub.Subject.Year, sssnsp.StudxSub.Subject.Subject_name.Uni_FK } into g
                //       select new summarized()
                //       {
                //           Tárgy_név = g.Key.Name,
                //           Év = g.Key.Year,
                //           Egyetem = g.Key.Uni_FK
                //       }
                //       ).ToList();






                //var teszt = (from p in context.Points
                //             where p.StudxSub.NEPTUN_FK == user.NEPTUN
                //             && p.StudxSub.Subject.Subject_name.University.Name.Contains(uni)
                //             && p.StudxSub.Subject.Year.Contains(year)
                //             group p by p.StudxSub.Subject into g
                //             select new summarized()
                //             {
                //                 Tárgy_név = g.Key.Subject_name.Name,
                //                 Év = g.Key.Year,
                //                 Egyetem = g.Key.Subject_name.Uni_FK,
                //                 Pont = g.Sum(f => f.Point1),
                //                 kettes = g.Key.elegseges,
                //                 harom = g.Key.kozepes,
                //                 negy = g.Key.jo,
                //                 öt = g.Key.jeles
                //             });
                //System.Windows.Forms.MessageBox.Show(teszt.ToString());
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
        static public void Save()
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
