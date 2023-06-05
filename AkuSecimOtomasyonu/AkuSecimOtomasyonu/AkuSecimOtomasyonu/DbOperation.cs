using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AkuSecimOtomasyonu
{
    public class DbOperation
    {
        public class ValueModel
        {
            public int Id { get; set; }
            public string Value { get; set; }
            public int En { get; set; }
            public int Boy { get; set; }
            public int Yukseklik { get; set; }
            public string UretimYil { get; set; }
        }
        public class AkuModel
        {
            public int Id { get; set; }
            public string Value { get; set; }
            public int En { get; set; }
            public int Boy { get; set; }
            public int Yukseklik { get; set; }
            public string UretimYil { get; set; }
        }

        readonly string connection;

        public DbOperation()
        {
            connection = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
        }

        private List<ValueModel> GetData(string sql, string idField, string valueField, bool altGrupMu = false, bool akuMu = false)
        {
            using (var conn = new SqlConnection(connection))
            {
                var da = new SqlDataAdapter(sql, connection);
                var dt = new DataTable();
                da.Fill(dt);
                var list = new List<ValueModel>();
                foreach (DataRow item in dt.Rows)
                {
                    if (altGrupMu)
                        list.Add(new ValueModel { Id = (int)item[idField], Value = item[valueField].ToString(), Boy = (int)item["Boy"], En = (int)item["En"], Yukseklik = (int)item["Yukseklik"], UretimYil = item["UretimYil"].ToString() });
                    else
                    if (akuMu)
                        list.Add(new ValueModel { Id = (int)item[idField], Value = item[valueField].ToString(), Boy = (int)item["Boy"], En = (int)item["En"], Yukseklik = (int)item["Yukseklik"] });
                    else
                        list.Add(new ValueModel { Id = (int)item[idField], Value = item[valueField].ToString() });
                }
                return list;
            }
        }

        public List<ValueModel> MarkalariGetir()
        {
            var sql = "Select Id, Marka FROM Markalar Order By Marka";
            var dt = GetData(sql, "Id", "Marka");
            return dt;
        }

        public List<ValueModel> ModelleriGetir(int markaId)
        {
            var sql = $"Select Id, Model FROM Modeller Where MarkaId = {markaId} Order By Model";
            var dt = GetData(sql, "Id", "Model");
            return dt;
        }

        public List<ValueModel> AltModelleriGetir(int modelId, int yil)
        {
            var sql = $"Select Id, AltModel, En, Boy, Yukseklik, convert(nvarchar, MinYil) + '-' +convert(nvarchar, MaxYil) as UretimYil FROM AltModeller Where ModelId = {modelId} AND MinYil <= {yil} AND MaxYil >= {yil} Order By AltModel";
            var dt = GetData(sql, "Id", "AltModel", true);
            return dt;
        }
        public List<ValueModel> AltModelleriGetir(int modelId)
        {
            var sql = $"Select  Id, AltModel, En, Boy, Yukseklik, convert(nvarchar, MinYil) + '-' +convert(nvarchar, MaxYil) as UretimYil FROM AltModeller Where ModelId = {modelId} Order By AltModel";
            var dt = GetData(sql, "Id", "AltModel", true);
            return dt;
        }
        public List<ValueModel> AkuleriGetir()
        {
            var sql = $"Select  Id, GenelAd, En, Boy, Yukseklik FROM Akuler Order By GenelAd";
            var dt = GetData(sql, "Id", "GenelAd", akuMu: true);
            return dt;
        }

        public string AkuBul(int en, int boy, int yukseklik)
        {
            var sql = $"Select Id, GenelAd FROM Akuler Where En = {en} AND Boy = {boy} AND Yukseklik = {yukseklik}";
            var dt = GetData(sql, "Id", "GenelAd");
            return dt.FirstOrDefault()?.Value ?? "Aradığınız akü bulunamadı";
        }

        public void MarkaEkle(string marka)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                new SqlCommand($"Insert Into Markalar (Marka) Values ('{marka}')", conn).ExecuteNonQuery();
            }
        }
        public void MarkaGuncelle(int id, string marka)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                new SqlCommand($"Update Markalar set Marka='{marka}' Where Id ={id}", conn).ExecuteNonQuery();
            }
        }
        public void MarkaSil(int id)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                new SqlCommand($"Delete from AltModeller where ModelId in (select Id from Modeller where MarkaId ={id})",conn).ExecuteNonQuery();
                new SqlCommand($"Delete From Modeller Where MarkaId = {id}", conn).ExecuteNonQuery();
                new SqlCommand($"Delete From Markalar Where Id = {id}", conn).ExecuteNonQuery();
            }
        }
        public void ModelEkle(string model, int markaId)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                new SqlCommand($"Insert Into Modeller (Model, MarkaId) Values ('{model}', {markaId})", conn).ExecuteNonQuery();
            }
        }
        public void ModelGuncelle(int id, string model)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                new SqlCommand($"Update Modeller set Model='{model}' Where Id ={id}", conn).ExecuteNonQuery();
            }
        }
        public void ModelSil(int id)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                new SqlCommand($"Delete From AltModeller Where ModelId = {id}", conn).ExecuteNonQuery();
                new SqlCommand($"Delete From Modeller Where Id = {id}", conn).ExecuteNonQuery();
            }
        }
        public void AltGroupEkle(string altGroup, int modelId, int en, int boy, int yukseklik, int minYil, int maxYil)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                new SqlCommand($"Insert Into AltModeller (AltModel, ModelId, En, Boy, Yukseklik, MinYil, MaxYil) Values ('{altGroup}', {modelId}, {en}, {boy}, {yukseklik}, {minYil}, {maxYil})", conn).ExecuteNonQuery();
            }
        }
        public void AltGroupGuncelle(int id, string altGroup, int en, int boy, int yukseklik, int minYil, int maxYil)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                new SqlCommand($"Update AltModeller SET AltModel = '{altGroup}', En = {en}, Boy = {boy}, Yukseklik = {yukseklik}, MinYil = {minYil}, MaxYil = {maxYil} WHERE Id = {id}", conn).ExecuteNonQuery();
            }
        }
        public void AltGroupSil(int id)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                new SqlCommand($"Delete From AltModeller Where Id = {id}", conn).ExecuteNonQuery();
            }
        }
        public void AkuEkle(string aku, int en, int boy, int yukseklik)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                new SqlCommand($"Insert Into Akuler (GenelAd, En, Boy, Yukseklik) Values ('{aku}', {en}, {boy}, {yukseklik})", conn).ExecuteNonQuery();
            }
        }
        public void AkuGuncelle(int id, string aku, int en, int boy, int yukseklik)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                new SqlCommand($"Update Akuler set GenelAd='{aku}', En={en}, Boy={boy}, Yukseklik={yukseklik} Where Id ={id}", conn).ExecuteNonQuery();
            }
        }
        public void AkuSil(int id)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                new SqlCommand($"Delete From Akuler Where Id = {id}", conn).ExecuteNonQuery();
            }
        }
    }
}
