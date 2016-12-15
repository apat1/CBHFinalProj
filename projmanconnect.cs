using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class projmanconnect
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

	public projmanconnect()
	{
        Initialize();
	}
    private void Initialize()
    {
        server = "localhost";
        database = "ProjMgmtFinaldb";
        uid = "root";
        password = "SharkDucks2013";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }
    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            //When handling errors, you can your application's response based 
            //on the error number.
            //The two most common error numbers when connecting are as follows:
            //0: Cannot connect to server.
            //1045: Invalid user name and/or password.
            switch (ex.Number)
            {
                case 0:
                    break;

                case 1045:
                    break;
            }
            return false;
        }
    }

    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            return false;
        }
    }

    public void belfioreFill(string strFileName)
    {
        OpenConnection();
        String query = String.Format("LOAD DATA INFILE '{0}' INTO TABLE bel_phx FIELDS TERMINATED BY ','", strFileName);
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = query;
        cmd.Connection = connection;
        cmd.ExecuteNonQuery();
        CloseConnection();
    }

    public void aggreementOptionFill(TextBox tb0, TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4, TextBox tb5, TextBox tb6, TextBox tb7, TextBox tb8, TextBox tb9, TextBox tb10, TextBox tb11, TextBox tb12)
    {
        OpenConnection();
        string FN,OR,ON,IR,RP,OD,P,OP,OTP,OC,APF,OBF,OBP;
        FN = tb0.Text;
        OR = tb1.Text;
        ON = tb2.Text;
        IR = tb3.Text;
        RP = tb4.Text;
        OD = tb5.Text;
         P = tb6.Text;
        OP = tb7.Text;
        OTP = tb8.Text;
        OC = tb9.Text;
        APF = tb10.Text;
        OBF = tb11.Text;
        OBP = tb12.Text;
        String query = String.Format("SET FOREIGN_KEY_CHECKS=0; INSERT INTO `Agreement - Option` VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}','{8}', '{9}', '{10}', '{11}', '{12}')", FN, OR, ON, IR,RP,OD,P,OP, OTP, OC,APF, OBF, OBP);
        String setCheck = String.Format("SET FOREIGN_KEY_CHECKS=1;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd2 = new MySqlCommand(setCheck, connection); 
        cmd.CommandText = query;
        cmd.Connection = connection;
        cmd.ExecuteNonQuery();
        cmd2.ExecuteNonQuery();
        CloseConnection();
    }//Agreement Option Table filled in

    public void aggreementPurchaseFill(TextBox tb0, TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4, TextBox tb5, TextBox tb6, TextBox tb7, TextBox tb8, TextBox tb9, TextBox tb10, TextBox tb11, TextBox tb12, 
        TextBox tb13,TextBox tb14, TextBox tb15,TextBox tb16,TextBox tb17,TextBox tb18,TextBox tb19, TextBox tb20,TextBox tb21,TextBox tb22,TextBox tb23,TextBox tb24,TextBox tb25,TextBox tb26,TextBox tb27,TextBox tb28,TextBox tb29,TextBox tb30
        ,TextBox tb31, TextBox tb32, TextBox tb33, TextBox tb34, TextBox tb35)
    {
        OpenConnection();
        string FN,PC,SE,SET,BE,BET,OD,CD,ES,R,A,PP,CPP,EC,EA,EA2,ECI,ESt,EZ,EP,EF,BC, 
            CA,CA2,CC,CS,CZ,CP,B,BA,BA2,BCi,BS,BZ,PCm,DDF;
        FN = tb0.Text;
        PC = tb1.Text;
        SE = tb2.Text;
        SET = tb3.Text;
        BE = tb4.Text;
        BET = tb5.Text;
        OD = tb6.Text;
        CD = tb7.Text;
        ES = tb8.Text;
        R = tb9.Text;
        A = tb10.Text;
        PP = tb11.Text;
        CPP = tb12.Text;
        EC = tb13.Text;
        EA = tb14.Text;
        EA2 = tb15.Text;
        ECI = tb16.Text;
        ESt = tb17.Text;
        EZ = tb18.Text;
        EP = tb19.Text;
        EF = tb20.Text;
        BC = tb21.Text;
        CA = tb22.Text;
        CA2 = tb23.Text;
        CC = tb24.Text;
        CS = tb25.Text;
        CZ = tb26.Text;
        CP = tb27.Text;
        B = tb28.Text;
        BA = tb29.Text;
        BA2 = tb30.Text;
        BCi = tb31.Text;
        BS = tb32.Text;
        BZ = tb33.Text;
        PCm = tb34.Text;
        DDF = tb35.Text;

        String query = String.Format("SET FOREIGN_KEY_CHECKS=0; INSERT INTO `Agreement - Purchase` VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}','{8}', '{9}', '{10}', '{11}', '{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}','{32}','{33}','{34}','{35}')", FN, PC, SE, SET, BE, BET, OD, CD, ES, R, A, PP, CPP, EC, EA, EA2, ECI, ESt, EZ, EP, EF, BC, 
            CA,CA2,CC,CS,CZ,CP,B,BA,BA2,BCi,BS,BZ,PCm,DDF);
        String setCheck = String.Format("SET FOREIGN_KEY_CHECKS=1;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd2 = new MySqlCommand(setCheck, connection);
        cmd.CommandText = query;
        cmd.Connection = connection;
        cmd.ExecuteNonQuery();
        cmd2.ExecuteNonQuery();
        CloseConnection();
    }//Agreement Purchase Table filled in

    public void aggreementConstructionFill(TextBox tb0, TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4, TextBox tb5, TextBox tb6, TextBox tb7, TextBox tb8, TextBox tb9, TextBox tb10, TextBox tb11)
    {
        OpenConnection();
        string FN, ON, CN, IR, CS, CCS, CC, DDF, AOF, IDF, DDF1, DDF2;
        FN = tb0.Text;
        ON = tb1.Text;
        CN = tb2.Text;
        IR = tb3.Text;
        CS = tb4.Text;
        CCS = tb5.Text;
        CC = tb6.Text;
        DDF = tb7.Text;
        AOF = tb8.Text;
        IDF = tb9.Text;
        DDF1 = tb10.Text;
        DDF2 = tb11.Text;
        String query = String.Format("SET FOREIGN_KEY_CHECKS=0; INSERT INTO `Agreement - Construction` VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}','{8}', '{9}', '{10}', '{11}')", FN, ON, CN, IR, CS, CCS, CC, DDF, AOF, IDF, DDF1, DDF2);
        String setCheck = String.Format("SET FOREIGN_KEY_CHECKS=1;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd2 = new MySqlCommand(setCheck, connection);
        cmd.CommandText = query;
        cmd.Connection = connection;
        cmd.ExecuteNonQuery();
        cmd2.ExecuteNonQuery();
        CloseConnection();
    }//agreement purchase filled

    public void builderFill(TextBox tb0, TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4, TextBox tb5, TextBox tb6, TextBox tb7, TextBox tb8, TextBox tb9, TextBox tb10, TextBox tb11, TextBox tb12,
        TextBox tb13, TextBox tb14, TextBox tb15, TextBox tb16, TextBox tb17, TextBox tb18, TextBox tb19, TextBox tb20, TextBox tb21, TextBox tb22, TextBox tb23, TextBox tb24, TextBox tb25, TextBox tb26, TextBox tb27)
    {
        OpenConnection();
        string FN, BID,BN,ON,CN,BA,BA2,BC,BS,BZ,BP,BF,
            BE,BW,CMN,TRL,TRG,TRC,TRF,TRP,TRFL,CL,CLA,PL,PLA,APF,APD, DDF;
        FN = tb0.Text;
        BID = tb1.Text;
        BN = tb2.Text;
        ON = tb3.Text;
        CN = tb4.Text;
        BA = tb5.Text;
        BA2 = tb6.Text;
        BC = tb7.Text;
        BS = tb8.Text;
        BZ = tb9.Text;
        BP = tb10.Text;
        BF = tb11.Text;
        BE = tb12.Text;
        BW = tb13.Text;
        CMN = tb14.Text;
        TRL = tb15.Text;
        TRG = tb16.Text;
        TRC = tb17.Text;
        TRF = tb18.Text;
        TRP = tb19.Text;
        TRFL = tb20.Text;
        CL = tb21.Text;
        CLA = tb22.Text;
        PL = tb23.Text;
        PLA = tb24.Text;
        APF = tb25.Text;
        APD = tb26.Text;
        DDF = tb27.Text;
        

        String query = String.Format("SET FOREIGN_KEY_CHECKS=0; INSERT INTO `builder` VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}','{8}', '{9}', '{10}', '{11}', '{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}')",  FN, BID,BN,ON,CN,BA,BA2,BC,BS,BZ,BP,BF,
            BE,BW,CMN,TRL,TRG,TRC,TRF,TRP,TRFL,CL,CLA,PL,PLA,APF,APD, DDF);
        String setCheck = String.Format("SET FOREIGN_KEY_CHECKS=1;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd2 = new MySqlCommand(setCheck, connection);
        cmd.CommandText = query;
        cmd.Connection = connection;
        cmd.ExecuteNonQuery();
        cmd2.ExecuteNonQuery();
        CloseConnection();
    }//Builder Table filled in

    public void distTablefill(TextBox textbox0, TextBox textbox1, TextBox textbox2, TextBox textbox3, TextBox textbox4, TextBox textbox5)
    {
        OpenConnection();
        string FN, DB,DN,AB,DA,AA;
        FN = textbox0.Text;
        DB = textbox1.Text;
        DN = textbox2.Text;
        AB = textbox3.Text;
        DA = textbox4.Text;
        AA = textbox5.Text;
        String query = String.Format("INSERT INTO `distribution table` VALUES('{0}', '{1}', '{2}', '{3}', '{4}','{5}')", FN,DB,DN,AB,DA,AA);
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = query;
        cmd.Connection = connection;
        cmd.ExecuteNonQuery();
        CloseConnection();
    } //Option Current table filled
 [System.Web.Services.WebMethod]
    public void optionCurrentfill(TextBox textbox0, TextBox textbox1, TextBox textbox2, TextBox textbox3, TextBox textbox4)
    {
        OpenConnection();
        string FN,CRP,OLR,COD,MF;
            FN = textbox0.Text;
            CRP = textbox1.Text;
            OLR = textbox2.Text;
            COD = textbox3.Text;
            MF = textbox4.Text;
            String query = String.Format("INSERT INTO optioncurrent VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",FN, CRP, OLR, COD, MF);
            String output = string.Format("SELECT * FROM optioncurrent;");
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            CloseConnection();
            

            
    } //Option Current table filled
}
