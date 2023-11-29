using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Configuration;


/// <summary>
/// 数据库文件一定要放在bin/Debug下！！！！
/// </summary>
namespace WindowsFormsApp1
{
    class SQLite
    {
        //数据库连接字符串(web.config来配置)，可以动态更改connectionString支持多数据库.		
        //如果要更换数据库，直接修改app.config；如果已经配置好了，可直接修改ConfigurationManager.AppSettings["SQLiteDB"]
        public static string connectionString = "data source=" + System.Environment.CurrentDirectory + "\\" + ConfigurationManager.AppSettings["SQLiteDB"] + ";version=3;";

        //创建存储过程
        public DataSet GetDataSetByPage(string keywords, int startIndex, int endIndex)
        {
            DataSet ds = new DataSet();
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();

            //查询符合条件的总数目
            string sqlCount = "select COUNT(*) from patient_detail where @keywords = '' or PatientName like '%' || @keywords || '%'";
            // 
            //Student1表："select COUNT(*) from Student1 where @keywords = '' or Name like '%' || @keywords || '%'";


            using (SQLiteCommand cmdCount = new SQLiteCommand(sqlCount, conn))
            {
                cmdCount.Parameters.AddWithValue("@keywords", keywords);

                SQLiteDataAdapter countDataAdapter = new SQLiteDataAdapter(cmdCount);

                countDataAdapter.Fill(ds, "TotalCount");
            }

            //查询序号在startIndex到endIndex中间的数据
            string sqlData = "select * from ( select ROW_NUMBER() over (order by PatientID asc) as Number,* " +
                             "from patient_detail where (@keywords = '' or PatientName like '%' || @keywords || '%')) " +
                             "where Number >= @startIndex and Number <= @endIndex";

            /*
             Student1表： "select * from ( select ROW_NUMBER() over (order by StudentID asc) as Number,* " +
                             "from Student1 where (@keywords = '' or Name like '%' || @keywords || '%')) " +
                             "where Number >= @startIndex and Number <= @endIndex";

             */
            //"select ROW_NUMBER() over (order by PatientID asc) as Number,*"表示以PatientID的顺序生成从1开始的升序序列，并查找表中所有列。
            //"(@keywords = '' or PatientName like '%' || @keywords || '%')"不为空就检索包含keywords的所有内容
            using (SQLiteCommand cmdData = new SQLiteCommand(sqlData, conn))
            {
                cmdData.Parameters.AddWithValue("@keywords", keywords);
                cmdData.Parameters.AddWithValue("@startIndex", startIndex);
                cmdData.Parameters.AddWithValue("@endIndex", endIndex);


                SQLiteDataAdapter dataDataAdapter = new SQLiteDataAdapter(cmdData);

                dataDataAdapter.Fill(ds, "StudentData");
            }

            conn.Close();

            return ds;
        }



        public static SQLiteConnection conn = null;
        public static SQLiteDataAdapter adp = null;
        #region
        public static void OpenConn()
        {
            if (conn == null)
            {
                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            if (conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }
        #endregion
        #region 执行sql前准备
        public static void PrepareSql(string sql)
        {
            OpenConn(); //打开数据库连接
            adp = new SQLiteDataAdapter(sql, conn);
        }
        #endregion
        #region 设置和获取sql语句的参数
        /// <summary>
        /// 设置传入参数
        /// </summary>
        /// <param name="parameterName">参数名称</param>
        /// <param name="parameterValue">参数值</param>
        public static void SetParameter(string parameterName, object parameterValue)
        {
            parameterName = "@" + parameterName.Trim();
            if (parameterValue == null)
                parameterValue = DBNull.Value;
            adp.SelectCommand.Parameters.Add(new SQLiteParameter(parameterName, parameterValue));
        }
        #endregion
        #region 执行SQL语句
        /// <summary>
        /// 执行非查询SQL语句
        /// </summary>
        /// <returns>受影响行数</returns>
        public static int ExecNonQuery()
        {
            int result = adp.SelectCommand.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        /// <summary>
        /// 执行查询SQL语句
        /// </summary>
        /// <returns>DataTable类型查询结果</returns>
        public static DataTable ExecQuery()
        {
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();
            return dt;
        }
        /// <summary>
        /// 执行查询SQL语句
        /// </summary>
        /// <returns>SqlDataReader类型查询结果,SqlDataReader需要手动关闭</returns>
        public static SQLiteDataReader ExecDataReader()
        {
            return adp.SelectCommand.ExecuteReader(CommandBehavior.CloseConnection);
        }
        /// <summary>
        /// 执行查询SQL语句
        /// </summary>
        /// <returns>查询结果第一行第一列</returns>
        public static object ExecScalar()
        {
            object obj = adp.SelectCommand.ExecuteScalar();
            conn.Close();
            return obj;
        }
        #endregion


    }

}
