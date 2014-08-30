/*
 * Created by SharpDevelop.
 * User: Alle
 * Date: 30.01.2006
 * Time: 23:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Globalization;

namespace LoksimUtil
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class LoksimHelper
	{

		public const int KEY_SIFA              = 1;
		public const int KEY_INDUSI            = 2;
		public const int KEY_FREIINDUSI        = 3;
		public const int KEY_LZB               = 4;
		public const int KEY_LICHT             = 5;
		public const int KEY_FERNLICHT         = 6;
		public const int KEY_HAUPTSCHALTER     = 7;
		public const int KEY_PFIFF             = 8;
		public const int KEY_GLOCKE            = 9;
		public const int KEY_AFBVZIELANZEIGEN  = 10;
		public const int KEY_TUEREN            = 11;
		public const int KEY_SANDEN            = 12;
		public const int KEY_AFB               = 13;
		public const int KEY_STUP              = 14;
		public const int KEY_STDOWN            = 15;
		public const int KEY_STLEFT            = 16;
		public const int KEY_STRIGHT           = 17;
		public const int KEY_BREMSEN0          = 18;
		public const int KEY_BREMSEN1          = 19;
		public const int KEY_BREMSEN2          = 20;
		public const int KEY_BREMSEN3          = 21;
		public const int KEY_BREMSEN4          = 22;
		public const int KEY_BREMSEN5          = 23;
		public const int KEY_BREMSEN6          = 24;
		public const int KEY_BREMSEN7          = 25;
		public const int KEY_BREMSEN8          = 26;
		public const int KEY_BREMSEN9          = 27;
		public const int KEY_SPEICHERBREMSE    = 28;
		public const int KEY_STNULLSTELLUNG    = 29;
		public const int KEY_ZUGKRAFTSTELLER   = 30;
		public const int KEY_BEFEHLINDUSI      = 31;
		public const int KEY_HALTANSAGE        = 32;
		public const int KEY_BUEGEL            = 33;
        public const int KEY_FAHRTENSCHREIBER  = 34; 
        public const int KEY_BUCHFAHRPLAN      = 35; 
        public const int KEY_BREMSZETTEL       = 36; 
        public const int KEY_FAHRZEITENHEFT    = 37; 
        public const int KEY_LOKINFO           = 38; 
        public const int KEY_LUEFTER           = 39; 
        public const int KEY_FREIWACHSAM       = 40; 
        public const int KEY_VSOLLAFBLZB       = 41; 
        public const int KEY_MAGNETBREMSE      = 42; 
        public const int KEY_RICHTUNGSWALZE    = 43; 
        public const int KEY_SONDSOUND1        = 44; 
        public const int KEY_SONDSOUND2        = 45; 
        public const int KEY_RICHTUNGSWALZE_V  = 46; 
        public const int KEY_RICHTUNGSWALZE_N  = 47; 
        public const int KEY_RICHTUNGSWALZE_R  = 48;
        public const int KEY_STOERSCHALTER_INDUSI = 49; 
        public const int KEY_WEGMESSUNG         = 50; 


		//OleParameter
		public const char cParamSeparator = '|';
		public const char cKeyValueSeparator = '=';
		
		
		
		//Float
		public const string cLOK_COMMON_ACTSPEED = "LOK.COMMON.ACTSPEED";
		public const string cLOK_COMMON_MAXSPEED = "LOK.COMMON.MAXSPEED";
        public const string cLOK_COMMON_ZUGSICHERUNG = "LOK.COMMON.ZUGSICHERUNGSSYSTEME";

        public const string cLOK_SYSTEM_INDUSIHZ1000 = "LOK.SYSTEM.1000HZUEBERWACHUNG";
        public const string cLOK_SYSTEM_INDUSIHZ500 = "LOK.SYSTEM.500HZUEBERWACHUNG";
		
		//Bool Variablen
		public const string cLOK_ANZEIGE_SCHLEUDERN = "LOK.ANZEIGE.SCHLEUDERN";
		public const string cLOK_ANZEIGE_SANDEN = "LOK.ANZEIGE.SANDEN";
		public const string cLOK_ANZEIGE_HAUPTSCHALTER = "LOK.ANZEIGE.HAUPTSCHALTER";
		public const string cLOK_ANZEIGE_SIFA = "LOK.ANZEIGE.SIFA";
		public const string cLOK_ANZEIGE_INDUSIHZ1000 = "LOK.ANZEIGE.INDUSIHZ1000";
        public const string cLOK_ANZEIGE_INDUSIHZ500 = "LOK.ANZEIGE.INDUSIHZ500";
		public const string cLOK_ANZEIGE_INDUSI95 = "LOK.ANZEIGE.INDUSI95";
		public const string cLOK_ANZEIGE_INDUSI75 = "LOK.ANZEIGE.INDUSI75";
		public const string cLOK_ANZEIGE_INDUSI60 = "LOK.ANZEIGE.INDUSI60";
        public const string cLOK_ANZEIGE_INDUSIWECHSELBLINKEN = "LOK.ANZEIGE.WECHSELBLINKEN";
		public const string cLOK_ANZEIGE_INDUSIBEFEHL = "LOK.ANZEIGE.INDUSIBEFEHL";
		public const string cLOK_ANZEIGE_LZBBETRIEB = "LOK.ANZEIGE.LZBBETRIEB";
		public const string cLOK_ANZEIGE_LZBG = "LOK.ANZEIGE.LZBG";
		public const string cLOK_ANZEIGE_LZBU = "LOK.ANZEIGE.LZBU";
		public const string cLOK_ANZEIGE_LZBENDE = "LOK.ANZEIGE.LZBENDE";
		public const string cLOK_ANZEIGE_SCHNELLBREMSUNG = "LOK.ANZEIGE.SCHNELLBREMSUNG";
		public const string cLOK_ANZEIGE_MAGNETBREMSE = "LOK.ANZEIGE.MAGNETBREMSE";
		public const string cLOK_ANZEIGE_HOHEABBREMSUNGVORH = "LOK.ANZEIGE.HOHEABBREMSUNGVORH";
		public const string cLOK_ANZEIGE_TUER1 = "LOK.ANZEIGE.TUER1";
		public const string cLOK_ANZEIGE_TUER2 = "LOK.ANZEIGE.TUER2";
		public const string cLOK_ANZEIGE_TUERVERRIEGELUNG = "LOK.ANZEIGE.TUERVERRIEGELUNG";
		public const string cLOK_ANZEIGE_LICHT = "LOK.ANZEIGE.LICHT";
		public const string cLOK_ANZEIGE_MESS = "LOK.ANZEIGE.MESS";
		public const string cLOK_ANZEIGE_AFB = "LOK.ANZEIGE.AFB";
		public const string cLOK_ANZEIGE_TRAKTIONGESPERRT = "LOK.ANZEIGE.TRAKTIONGESPERRT";
		public const string cLOK_ANZEIGE_FEDERSPEICHERBREMSE = "LOK.ANZEIGE.FEDERSPEICHERBREMSE";
		public const string cLOK_ANZEIGE_ZUGKRAFTSTELLERAKTIV = "LOK.ANZEIGE.ZUGKRAFTSTELLERAKTIV";
		public const string cLOK_ANZEIGE_BUEGELPANTO = "LOK.ANZEIGE.BUEGELPANTO";
		
		//Float Variablen
		public const string cLOK_INSTRUMENT_TACHO = "LOK.INSTRUMENT.TACHO";
		public const string cLOK_INSTRUMENT_LZBVZIEL = "LOK.INSTRUMENT.LZBVZIEL";
		public const string cLOK_INSTRUMENT_LZBVZIELABSTANDDIGITAL = "LOK.INSTRUMENT.LZBVZIELABSTANDDIGITAL";
		public const string cLOK_INSTRUMENT_LZBVZIELABSTANDBALKEN = "LOK.INSTRUMENT.LZBVZIELABSTANDBALKEN";
		public const string cLOK_INSTRUMENT_AFB = "LOK.INSTRUMENT.AFB";
		public const string cLOK_INSTRUMENT_BREMSDRUCK = "LOK.INSTRUMENT.BREMSDRUCK";
		public const string cLOK_INSTRUMENT_BREMSZYLINDERDRUCK = "LOK.INSTRUMENT.BREMSZYLINDERDRUCK";
		public const string cLOK_INSTRUMENT_2BREMSZYLINDERDR = "LOK.INSTRUMENT.2BREMSZYLINDERDR";
		public const string cLOK_INSTRUMENT_DYNBREMSSTUFE = "LOK.INSTRUMENT.DYNBREMSSTUFE";
		public const string cLOK_INSTRUMENT_ISTSTUFE = "LOK.INSTRUMENT.ISTSTUFE";
		public const string cLOK_INSTRUMENT_SOLLSTUFE = "LOK.INSTRUMENT.SOLLSTUFE";
		public const string cLOK_INSTRUMENT_MOTORSTROM = "LOK.INSTRUMENT.MOTORSTROM";
		public const string cLOK_INSTRUMENT_OBERSTROM = "LOK.INSTRUMENT.OBERSTROM";
		public const string cLOK_INSTRUMENT_KRAFT = "LOK.INSTRUMENT.KRAFT";
		public const string cLOK_INSTRUMENT_ZUGKRAFTSTELLER = "LOK.INSTRUMENT.ZUGKRAFTSTELLER";
		public const string cLOK_INSTRUMENT_VSOLLSTELLER = "LOK.INSTRUMENT.VSOLLSTELLER";
		public const string cLOK_INSTRUMENT_FAHRSPANNUNG = "LOK.INSTRUMENT.FAHRSPANNUNG";
		
		//Float
		public const string cSIM_COMMON_SIMTIME = "SIM.COMMON.SIMTIME"; //Zeit die in der Simulation vergangen ist in Sekunden
		
		public static void AddParam( ref string ParamString, string ParamName)
		{
			if( ParamString != "")
			{
				ParamString = ParamString + cParamSeparator;
			}
			ParamString = ParamString + ParamName;
		}
		
		public static string GetParamRawString( string CodedParamString, string ParamName)
		{
			string Result = "";
			string ParamPlusSep = ParamName + cKeyValueSeparator;
			int PosStart = CodedParamString.IndexOf( ParamPlusSep);
			if( PosStart >= 0)
			{
				Result = CodedParamString.Substring( PosStart + ParamPlusSep.Length);
				int PosEnd = Result.IndexOf( cParamSeparator);
				if( PosEnd >= 0)
				{
					Result = Result.Substring( 0, PosEnd);  					
				}
			}
			
			return Result;
		}
		
				
		public static bool GetParamBool( string CodedParamString, string ParamName)
		{
			string Ret = GetParamRawString( CodedParamString, ParamName);
			if( Ret == "TRUE")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
			
		public static double GetParamFloat( string CodedParamString, string ParamName)
		{
			string Ret = GetParamRawString( CodedParamString, ParamName);

			double Value;
			try
			{
				NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;
				// Displays the same value with a blank as the separator.
				nfi.NumberDecimalSeparator = ".";
				Value = Double.Parse( Ret, nfi);
			}
			catch
			{
				Value = 0.0;
			}
			return Value;
		}

        public static string GetParamString(string CodedParamString, string ParamName)
        {
            return GetParamRawString(CodedParamString, ParamName);
        }

		public LoksimHelper()
		{
	
		}
	}
}
