using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADODB;
namespace latihan2
{
    internal class Class1
    {
        public static ADODB.Recordset JalankanSQL(String SQL)
        {
            ADODB.Connection AC = new ADODB.Connection();
            if (AC.State.Equals(ObjectStateEnum.adStateOpen))
            {
                AC.Close();
                AC = null;
            }
            AC.CursorLocation = CursorLocationEnum.adUseClient;
            AC.Properties.Refresh();

            AC.Open("DSN=DSNLOGIN");

            object obj = Type.Missing;

            ADODB.Recordset AR = new ADODB.Recordset();
            AR = AC.Execute(SQL,out obj);

            return AR;
        }
    }
}
