using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace CooKINGLibrary.Classes {
    public static class SqlKonekcija {
        public const string ConString= "Data Source=DESKTOP-U831V2K\\SQLEXPRESS;Initial Catalog=CooKINGDataBase;Integrated Security=True";

        public static List<Namirnice> UcitajSveNamirnice() {
            List<Namirnice> nam = new List<Namirnice>();
            using (IDbConnection con = new SqlConnection(ConString)) {
                nam = con.Query<Namirnice>("dbo.SpDohvatiSveNamirnice").ToList();  
            }
            return nam;
        }
        public static void InsertNamirnica(Namirnice m) {
            using (IDbConnection con = new SqlConnection(ConString)) {
                var p = new DynamicParameters();
                p.Add("@Naziv", m.Naziv);
                p.Add("@Mjera", (int)m.Mjera);
                p.Add("@Opca", m.Opca);
                p.Add("@Vrsta", (int)m.Vrsta);
                
                con.Execute("dbo.spNamirnica_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        public static void DeleteNamirnica(string m) {
            using (IDbConnection con=new SqlConnection(ConString)) {
                var p = new DynamicParameters();
                p.Add("@Naziv", m);
                //TODO: Crash kada brišem namirnice koje sam dodala preko recepta
                con.Execute("dbo.spNamirnica_Delete", p, commandType: CommandType.StoredProcedure);
            }
        }
        public static void InsertRecept(Recepti re) {
            using(IDbConnection con=new SqlConnection(ConString)) {
                var p = new DynamicParameters();
                p.Add("@Naziv", re.Naziv);
                p.Add("@VrstaJela", (int)re.VrstaJela);
                p.Add("@PodvrstaJela", re.PodvrstaJela);
                p.Add("@BrojServiranja", re.BrojServiranja);
                p.Add("@VrijemeKuhanja", re.VrijemeKuhanja);
                p.Add("@KuharskoUmijece", (int)re.Tezina);
                p.Add("@PotrebnoKuhanje", re.PotrebnoKuhanje);
                p.Add("@Savijet", re.Savijet);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                con.Execute("dbo.spRecept_Insert", p, commandType: CommandType.StoredProcedure);

                re.Id = p.Get<int>("@Id");
            }
        }
        public static void InsertSastavnica(Sastavnica sa) {
            using(IDbConnection con=new SqlConnection(ConString)) {
                var p = new DynamicParameters();
                p.Add("@ReceptId", sa.ReceptId);
                p.Add("@NamirnicaId", sa.NamirnicaId);
                p.Add("@Kolicina", sa.Kolicina);

                con.Execute("dbo.spSastavnica_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        public static void InsertKorak(Koraci ko) {
            using(IDbConnection con=new SqlConnection(ConString)) {
                var p = new DynamicParameters();
                p.Add("@BrojKoraka", ko.BrojKoraka);
                p.Add("@OpisKoraka", ko.OpisKoraka);
                p.Add("@Naputak", ko.Naputak);
                p.Add("@VrijemeIzvodenja", ko.VrijemeIzvodenja);
                p.Add("@ReceptId", ko.ReceptId);

                con.Execute("dbo.spKorak_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        public static void InsertFotografija(Fotografija fo) {
            using(IDbConnection con= new SqlConnection(ConString)) {
                var p = new DynamicParameters();
                p.Add("@Lokacija", fo.Lokacija);
                p.Add("@ReceptId", fo.ReceptId);

                con.Execute("dbo.spFotografija_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        public static List<Recepti> GetAll_Recepti() {
            using(IDbConnection con=new SqlConnection(ConString)) {
                return con.Query<Recepti>("select * from Recept").ToList();
            }
        }
        public static void GetNamirniceZaRecept(List<Recepti> re) {
            using (IDbConnection con=new SqlConnection(ConString)) {
                foreach(Recepti r in re) {
                    r.NamirniceRecepta = con.Query<Namirnice>("dbo.spDohvatiSveNamirnicePoReceptu", new { ReceptId = r.Id }, commandType: CommandType.StoredProcedure).ToList();
                }
            }
        }
        public static void GetFotografijeZaRecept(List<Recepti> re) {
            using (IDbConnection con = new SqlConnection(ConString)) {
                foreach (Recepti r in re) {
                    r.FotografijeRecepta = con.Query<Fotografija>("dbo.spDohvatiSveFotografijePoReceptu", new { ReceptId = r.Id }, commandType: CommandType.StoredProcedure).ToList();
                }
            }
        }
        public static void GetKoraciZaRecept(List<Recepti> re) {
            using (IDbConnection con = new SqlConnection(ConString)) {
                foreach (Recepti r in re) {
                    r.KoraciRecepta = con.Query<Koraci>("dbo.spDohvatiSveKorakePoReceptu", new { ReceptId = r.Id }, commandType: CommandType.StoredProcedure).ToList();
                }
            }
        }
        public static List<Sastavnica> GetSveSastavnice() {
            using (IDbConnection con = new SqlConnection(ConString)) { 
                    return con.Query<Sastavnica>("dbo.spDohvatiSveSastavnice").ToList();
            }
        }
        public static void DeleteRecept(int id) {
            using (IDbConnection con = new SqlConnection(ConString)) {
                var p = new DynamicParameters();
                p.Add("@Id", id);
                con.Execute("dbo.spRecept_Delete", p, commandType: CommandType.StoredProcedure);
            }
        }
        public static List<int> DohvatiIdReceptaFalse(int min, int max, int v) {
            using(IDbConnection con=new SqlConnection(ConString)) {
                var p = new DynamicParameters();
                p.Add("@Min", min); p.Add("@Max", max); p.Add("@Vrijeme", v);
                return con.Query<int>("dbo.spDohvatiIDReceptaFalse", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public static List<int> DohvatiIdReceptaTrue(int min, int max, int v, int vrs, int podv) {
            using (IDbConnection con = new SqlConnection(ConString)) {
                var p = new DynamicParameters();
                p.Add("@Min", min); p.Add("@Max", max); p.Add("@Vrijeme", v); p.Add("@Vrsta", vrs); p.Add("@Podvrsta", podv);
                return con.Query<int>("dbo.spDohvatiIDReceptaTrue", p, commandType:CommandType.StoredProcedure).ToList();
            }
        }
       
    }
}
