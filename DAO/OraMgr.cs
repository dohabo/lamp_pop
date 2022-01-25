using Car_Head_Lamp.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Head_Lamp.DAO
{
    class OraMgr
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleCommand cmd;
        static OraMgr instance;

        public static OraMgr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OraMgr();
                }
                return instance;
            }
        }

        // 생성자
        public OraMgr()
        {
            Console.WriteLine("오라클 객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
        }

        // 소멸자
        ~OraMgr()
        {
            closeDB();
            Console.WriteLine("오라클 객체 소멸");
        }

        public void connectDB()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 오류: " + e.Message);
                Environment.Exit(0);
            }
        }

        public void closeDB()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 접속 해제");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류: " + e.Message);
            }
        }

        public void insertDB(string itemNum)
        {
            try
            {
                string sql = string.Format("insert work values (" +
                    "work_seq.nextval, '{0}', 100)",
                    itemNum);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public void insertAutoOrderDB(string itemNum)
        {
            try
            {
                string sql = string.Format("insert into work " +
                    "(orderNum, itemNum, orderQuan, createmethod)" +
                    " values (work_seq.nextval, '{0}', 100, 'auto')",
                    itemNum);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public void insertProcess1DB(int orderNum, int process1_PassQuan)
        {
            string startTime = DateTime.Now.ToString("yyyy년MM월dd일 HH:mm:ss");
            try
            {
                string sql = string.Format("insert into process1_t values (" +
                    "{0}, '{1}', {2}, {3}, process1_t_seq.nextval)",
                    orderNum, startTime, process1_PassQuan, 100-process1_PassQuan);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("process1 데이터 추가 오류: " + e.Message);
            }
        }
        public void insertProcess2DB(int orderNum, int process2_PassQuan, int passNum)
        {
            string startTime = DateTime.Now.ToString("yyyy년MM월dd일 HH:mm:ss");
            try
            {
                string sql = string.Format("insert into process2_t values (" +
                    "{0}, '{1}', {2}, {3}, process2_t_seq.nextval)",
                    orderNum, startTime, process2_PassQuan, passNum - process2_PassQuan);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("process2 데이터 추가 오류: " + e.Message);
            }
        }
        public void insertProcess3DB(int orderNum, int process3_PassQuan, int passNum)
        {
            string startTime = DateTime.Now.ToString("yyyy년MM월dd일 HH:mm:ss");
            try
            {
                string sql = string.Format("insert into process3_t values (" +
                    "{0}, '{1}', {2}, {3}, process3_t_seq.nextval)",
                    orderNum, startTime, process3_PassQuan, passNum - process3_PassQuan);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("process3 데이터 추가 오류: " + e.Message);
            }
        }
        public void insertProcess4DB(int orderNum, int process4_PassQuan, int passNum)
        {
            string startTime = DateTime.Now.ToString("yyyy년MM월dd일 HH:mm:ss");
            try
            {
                string sql = string.Format("insert into process4_t values (" +
                    "{0}, '{1}', {2}, {3}, process4_t_seq.nextval)",
                    orderNum, startTime, process4_PassQuan, passNum - process4_PassQuan);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("process4 데이터 추가 오류: " + e.Message);
            }
        }
        public void insertProcess5DB(int orderNum, int process5_PassQuan, int passNum)
        {
            string startTime = DateTime.Now.ToString("yyyy년MM월dd일 HH:mm:ss");
            try
            {
                string sql = string.Format("insert into process5_t values (" +
                    "{0}, '{1}', {2}, {3}, process5_t_seq.nextval)",
                    orderNum, startTime, process5_PassQuan, passNum - process5_PassQuan);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("process5 데이터 추가 오류: " + e.Message);
            }
        }

        public void commitDB()
        {
            try
            {
                string sql = "commit";

                Console.WriteLine("sql : " + sql);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("commit 오류: " + e.Message);
            }
        }

        public void UpdateWork1DB(int orderNum)
        {
            try
            {
                string sql = string.Format("update work"+
                    " set accumpassquan = "+
                    "(select process1_t.passquan"+
                    " from work, process1_t " +
                    " where work.ordernum = process1_t.ordernum " +
                    " and process1_t.ordernum = {0}), " +
                    " state = '1공정완료'," +
                    " accumfailquan = (select process1_t.failquan" +
                    " from work, process1_t " +
                    " where work.ordernum = process1_t.ordernum " +
                    " and process1_t.ordernum = {0})" +
                    " where ordernum = {0}",orderNum);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("process1업데이트 오류: " + e.Message);
            }
        }
        public void UpdateWork2DB(int orderNum, int passNum)
        {
            try
            {
                string sql = string.Format("update work" +
                    " set accumpassquan = " +
                    "(select process2_t.passquan" +
                    " from work, process2_t " +
                    " where work.ordernum = process2_t.ordernum " +
                    " and process2_t.ordernum = {0}), " +
                    " state = '2공정완료'," +
                    " accumfailquan = (select process2_t.failquan" +
                    " from work, process2_t " +
                    " where work.ordernum = process2_t.ordernum " +
                    " and process2_t.ordernum = {0})" +
                    " where ordernum = {0}", orderNum);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("process2업데이트 오류: " + e.Message);
            }
        }
        public void UpdateWork3DB(int orderNum)
        {
            try
            {
                string sql = string.Format("update work" +
                    " set accumpassquan = " +
                    "(select process3_t.passquan" +
                    " from work, process3_t " +
                    " where work.ordernum = process3_t.ordernum " +
                    " and process3_t.ordernum = {0}), " +
                    " state = '3공정완료'," +
                    " accumfailquan = (select process3_t.failquan" +
                    " from work, process3_t " +
                    " where work.ordernum = process3_t.ordernum " +
                    " and process3_t.ordernum = {0})" +
                    " where ordernum = {0}", orderNum);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("process3업데이트 오류: " + e.Message);
            }
        }
        public void UpdateWork4DB(int orderNum)
        {
            try
            {
                string sql = string.Format("update work" +
                    " set accumpassquan = " +
                    "(select process4_t.passquan" +
                    " from work, process4_t " +
                    " where work.ordernum = process4_t.ordernum " +
                    " and process4_t.ordernum = {0}), " +
                    " state = '4공정완료'," +
                    " accumfailquan = (select process4_t.failquan" +
                    " from work, process4_t " +
                    " where work.ordernum = process4_t.ordernum " +
                    " and process4_t.ordernum = {0})" +
                    " where ordernum = {0}", orderNum);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("process4업데이트 오류: " + e.Message);
            }
        }
        public void UpdateWork5DB(int orderNum)
        {
            try
            {
                string sql = string.Format("update work" +
                    " set accumpassquan = " +
                    "(select process5_t.passquan" +
                    " from work, process5_t " +
                    " where work.ordernum = process5_t.ordernum " +
                    " and process5_t.ordernum = {0}), " +
                    " state = '5공정완료'," +
                    " accumfailquan = (select process5_t.failquan" +
                    " from work, process5_t " +
                    " where work.ordernum = process5_t.ordernum " +
                    " and process5_t.ordernum = {0})" +
                    " where ordernum = {0}", orderNum);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("process5업데이트 오류: " + e.Message);
            }
        }

        public void insertWork(string itemNum, int orderQuan)
        {
            try
            {
                string sql = string.Format("insert into work (ordernum, itemnum, orderQuan)" +
                    "values (work_seq.nextval, '{0}', {1})",
                    itemNum, orderQuan);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public void insertProcess(string tableName, string ordernum, string startTime,
            string finishTime, int passQuan, int orderQuan)
        {
            try
            {
                string sql = string.Format("insert {0} values (" +
                    "'{1}', '{2}', '{3}', {4}, {5}, process1_t_seq)",
                    tableName, ordernum, startTime, finishTime, 
                    passQuan, passQuan-orderQuan);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                string message = string.Format("{0} 데이터 추가 오류", tableName);
                Console.WriteLine(message + e.Message);
            }
        }
        public void insertProcess2(string itemNum)
        {
            try
            {
                string sql = string.Format("insert work values (" +
                    "work_seq.nextval, '{0}', 100)",
                    itemNum);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public void insertProcess3(string itemNum)
        {
            try
            {
                string sql = string.Format("insert work values (" +
                    "work_seq.nextval, '{0}', 100)",
                    itemNum);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public void insertProcess4(string itemNum)
        {
            try
            {
                string sql = string.Format("insert work values (" +
                    "work_seq.nextval, '{0}', 100)",
                    itemNum);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public void insertProcess5(string itemNum)
        {
            try
            {
                string sql = string.Format("insert work values (" +
                    "work_seq.nextval, '{0}', 100)",
                    itemNum);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }



        public string getOrderNum( )
        {
            string sql = string.Format("select ordernum " +
                " from (select row_number()over(order by orderNum) as 번호," +
                " ordernum from work where state is null) where 번호 = 1");
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            string orderNum = string.Empty;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    orderNum = rd["ordernum"].ToString();
                }
            }
            else
            {
                Console.WriteLine("OrderNumber 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return orderNum;
        }
        public int getAutoOrderNum()
        {
            string sql = string.Format("select ordernum " +
                " from (select row_number()over(order by orderNum) as 번호," +
                " ordernum from work " +
                " where createmethod = 'auto' and state = '작업대기') where 번호 = 1");
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            int orderNum = 0;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    orderNum = int.Parse(rd["ordernum"].ToString());
                }
            }
            else
            {
                Console.WriteLine("OrderNumber 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return orderNum;
        }
        public int getAutoOrderNum(string state)
        {
            string sql = string.Format("select ordernum " +
                " from (select row_number()over(order by orderNum) as 번호," +
                " ordernum from work " +
                " where createmethod = 'auto' and state = '{0}') where 번호 = 1", state);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            int orderNum = 0;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    orderNum = int.Parse(rd["ordernum"].ToString());
                }
            }
            else
            {
                Console.WriteLine("OrderNumber 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return orderNum;
        }

        public int getProcess1PassNum(int orderNum)
        {
            string sql = string.Format("select passQuan from process1_t" +
                " where ordernum = {0}", orderNum);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            int passQuan = 0;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    passQuan = int.Parse(rd["passQuan"].ToString());
                }
            }
            else
            {
                Console.WriteLine("OrderNumber 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return passQuan;
        }
        public int getProcess2PassNum(int orderNum)
        {
            string sql = string.Format("select passQuan from process2_t" +
                " where ordernum = {0}", orderNum);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            int passQuan = 0;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    passQuan = int.Parse(rd["passQuan"].ToString());
                }
            }
            else
            {
                Console.WriteLine("OrderNumber 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return passQuan;
        }
        public int getProcess3PassNum(int orderNum)
        {
            string sql = string.Format("select passQuan from process3_t" +
                " where ordernum = {0}", orderNum);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            int passQuan = 0;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    passQuan = int.Parse(rd["passQuan"].ToString());
                }
            }
            else
            {
                Console.WriteLine("OrderNumber 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return passQuan;
        }
        public int getProcess4PassNum(int orderNum)
        {
            string sql = string.Format("select passQuan from process4_t" +
                " where ordernum = {0}", orderNum);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            int passQuan = 0;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    passQuan = int.Parse(rd["passQuan"].ToString());
                }
            }
            else
            {
                Console.WriteLine("OrderNumber 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return passQuan;
        }
        public int getProcess5PassNum(int orderNum)
        {
            string sql = string.Format("select passQuan from process5_t" +
                " where ordernum = {0}", orderNum);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            int passQuan = 0;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    passQuan = int.Parse(rd["passQuan"].ToString());
                }
            }
            else
            {
                Console.WriteLine("OrderNumber 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return passQuan;
        }

        public string getOrderQuan()
        {
            string sql = string.Format("select orderQuan" +
                "from(select row_number()over(order by orderNum) as 번호," +
                "orderquan from work where state is null) where 번호 = 1");

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            string orderNum = string.Empty;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    orderNum = rd["ordernum"].ToString();
                }
            }
            else
            {
                Console.WriteLine("OrderNumber 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return orderNum;
        }
                
        public List<Work> getWorkInfo()
        {
            string sql = string.Format("select ordernum, itemnum, orderquan,"+
                "case when state is null then '작업대기' else state end as 상태,"+
                "case when accumpassquan is null then 0 " +
                "else accumpassquan end as 누적양품수량,"+
                "case when accumfailquan is null then 0 "+
                "else accumfailquan end as 누적불량수량"+
                " from work order by ordernum"
                );
            Console.WriteLine("확인용SQL:" + sql);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<Work> list = new List<Work>();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Work work = new Work(
                        int.Parse(rd["ordernum"].ToString()),
                        rd["itemnum"].ToString(),
                        int.Parse(rd["orderquan"].ToString()),
                        rd["상태"].ToString(),
                        int.Parse(rd["누적양품수량"].ToString()),
                        int.Parse(rd["누적불량수량"].ToString()));
                    list.Add(work);
                }
            }
            else
            {
                Console.WriteLine("OrderNumber 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public List<Item> getItem()
        {
            string sql = "select itemnum from item";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<Item> list = new List<Item>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Item item = new Item(
                        rd["itemnum"].ToString());
                    list.Add(item);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public string getRanItem(int num)
        {
            string sql = string.Format("select * " +
                " from(select row_number()over(order by itemnum) as NUM," +
                " itemnum, itemname" +
                " from item) where NUM = {0}",num);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            string itemNum = string.Empty;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    itemNum = rd["itemnum"].ToString();
                }
            }
            else
            {
                Console.WriteLine("ITEM 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return itemNum;
        }

        public List<Work> getProcess1()
        {
            string sql = string.Format("select ordernum, itemnum, orderquan," +
                " case when state is null then '작업대기' else state end as 상태" +
                " from(select * from work order by ordernum)" +
                " where rownum = 1 and state = '작업대기'");

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<Work> list = new List<Work>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Work work = new Work(
                        int.Parse(rd["ordernum"].ToString()),
                        rd["itemnum"].ToString(),
                        int.Parse(rd["orderquan"].ToString()),
                        rd["상태"].ToString()
                        );
                        list.Add(work);
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();

            return list;
        }
        public List<Work> getProcess2()
        {
            string sql = string.Format("select ordernum, itemnum, orderquan, accumpassQuan, state as 상태" +
                " from(select * from work where state = '1공정완료' order by ordernum )" +
                " where rownum = 1");

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Work> list = new List<Work>();
            
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Work work = new Work(
                        int.Parse(rd["ordernum"].ToString()),
                        rd["itemnum"].ToString(),
                        int.Parse(rd["accumpassQuan"].ToString()),
                        rd["상태"].ToString()
                        );
                    list.Add(work);
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            Console.WriteLine("process2list.Count" + list.Count);
            return list;
        }
        public List<Work> getProcess3()
        {
            string sql = string.Format("select ordernum, itemnum, orderquan, accumpassQuan, state as 상태" +
                " from(select * from work where state = '2공정완료' order by ordernum )" +
                " where rownum = 1");

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Work> list = new List<Work>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Work work = new Work(
                        int.Parse(rd["ordernum"].ToString()),
                        rd["itemnum"].ToString(),
                        int.Parse(rd["accumpassQuan"].ToString()),
                        rd["상태"].ToString()
                        );
                    list.Add(work);
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public List<Work> getProcess4()
        {
            string sql = string.Format("select ordernum, itemnum, orderquan,accumpassQuan, state as 상태" +
                " from(select * from work where state = '3공정완료' order by ordernum )" +
                " where rownum = 1");

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Work> list = new List<Work>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Work work = new Work(
                        int.Parse(rd["ordernum"].ToString()),
                        rd["itemnum"].ToString(),
                        int.Parse(rd["accumpassQuan"].ToString()),
                        rd["상태"].ToString()
                        );
                    list.Add(work);
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public List<Work> getProcess5()
        {
            string sql = string.Format("select ordernum, itemnum, orderquan,accumpassQuan, state as 상태" +
                " from(select * from work where state = '4공정완료' order by ordernum )" +
                " where rownum = 1");

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Work> list = new List<Work>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Work work = new Work(
                        int.Parse(rd["ordernum"].ToString()),
                        rd["itemnum"].ToString(),
                        int.Parse(rd["accumpassQuan"].ToString()),
                        rd["상태"].ToString()
                        );
                    list.Add(work);
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public string getProcess1PassNum()
        {
            string sql = "select ordernum, passquan, failquan " +
                " from (select * from process1_t order by ordernum desc)";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            Console.WriteLine("sql: " + sql);

            string passQuan = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    passQuan = rd["passquan"].ToString();
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return passQuan;
        }
        public string getProcess2PassNum()
        {
            string sql = "select ordernum, passquan, failquan " +
                " from (select * from process2_t order by ordernum desc)";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            string passQuan = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    passQuan = rd["passquan"].ToString();
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return passQuan;
        }
        public string getProcess3PassNum()
        {
            string sql = "select ordernum, passquan, failquan " +
                " from (select * from process3_t order by ordernum desc)";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            string passQuan = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    passQuan = rd["passquan"].ToString();
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return passQuan;
        }
        public string getProcess4PassNum()
        {
            string sql = "select ordernum, passquan, failquan " +
                " from (select * from process4_t order by ordernum desc)";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            string passQuan = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    passQuan = rd["passquan"].ToString();
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return passQuan;
        }
        public string getProcess5PassNum()
        {
            string sql = "select ordernum, passquan, failquan " +
                " from (select * from process5_t order by ordernum desc)";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            string passQuan = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    passQuan = rd["passquan"].ToString();
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return passQuan;
        }
        public string getProcess1FailNum()
        {
            string sql = "select ordernum, passquan, failquan " +
                " from (select * from process1_t order by ordernum desc)";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            Console.WriteLine("sql: " + sql);

            string failQuan = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    failQuan = rd["failquan"].ToString();
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return failQuan;
        }
        public string getProcess2FailNum()
        {
            string sql = "select ordernum, passquan, failquan " +
                " from (select * from process2_t order by ordernum desc)";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            string failQuan = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    failQuan = rd["failquan"].ToString();
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return failQuan;
        }
        public string getProcess3FailNum()
        {
            string sql = "select ordernum, passquan, failquan " +
                " from (select * from process3_t order by ordernum desc)";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            string failQuan = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    failQuan = rd["failquan"].ToString();
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return failQuan;
        }
        public string getProcess4FailNum()
        {
            string sql = "select ordernum, passquan, failquan " +
                " from (select * from process4_t order by ordernum desc)";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            string failQuan = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    failQuan = rd["failquan"].ToString();
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return failQuan;
        }
        public string getProcess5FailNum()
        {
            string sql = "select ordernum, passquan, failquan " +
                " from (select * from process5_t order by ordernum desc)";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            string failQuan = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    failQuan = rd["failquan"].ToString();
                }
            }
            else
            {
                Console.WriteLine("작업오더 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return failQuan;
        }


        public void DeleteWorkDB(string orderNum)
        {
            try
            {
                string sql = string.Format("Delete From work " +
                    "where ordernum = '{0}'", orderNum);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);
            }
        }
    }
}
