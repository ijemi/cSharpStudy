using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_Excel操作
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "2015091716085856.xls";
            string cnnectionString = "Provider=Micsoft.Jet.OLEDB.4.0;"+"Data Sourse="+fileName+";"+";Extended Properties=\"Excel8.0;HDR=YES;IMEX=1\"";
            //创建链接到数据源的对象
            OleDbConnection connection = new OleDbConnection(cnnectionString);

            //打开链接
            connection.Open();
            string sql = "select * from [Sheet1$]";//查询命令
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql,connection);
            DataSet dataSet = new DataSet();//用来存放数据 用来存放DataTable

            adapter.Fill(dataSet);//把查询结果（datatable）放到（填充）dataset里面

            connection.Close();//释放链接资源

            //取数据
            DataTableCollection tableCollection= dataSet.Tables;//获取当前集合中所有的表格
            DataTable table= tableCollection[0];//因为我们只往dataset中放置了一张表格所有这里取得索引0的表格就是我们刚刚查询到的表格

            //取得表格中数据
            //取得table中所有的行
            DataRowCollection rowCollection= table.Rows;//返回了一个行的集合

            //遍历行的集合，取得每一个行的datarow对象
            foreach(DataRow row in rowCollection)
            {
                //取得row中前4列数据 索引【0--3】
                for(int i = 0; i < 4; i++)
                {
                    Console.Write(row[i] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
