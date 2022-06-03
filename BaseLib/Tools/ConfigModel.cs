//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BaseLib.Tools
//{
//    public class ConfigModel
//    {
//		private static string path;

//		private static string dllPath;

//		private static string clientLanguage;

//		private static string loginUser;

//		private static string loginDB;

//		private static bool checkDomain;

//		private static bool loadInMemoryField;

//		private static LoginType LoginTypeField;

//		private static string ConnectionTypeField;

//		public static string PATH => pathField;

//		public static bool Exists => new FileInfo(PATH).Exists;

//		public static bool CheckDomain => checkDomainField;

//		public static bool LoadInMemory => loadInMemoryField;

//		public static string DllPath => dllPathField;

//		public static string ClientLanguage => clientLanguageField;

//		public static string LoginUser
//		{
//			get
//			{
//				return loginUserField;
//			}
//			set
//			{
//				loginUserField = value;
//				SaveConfig("login_info/emp_no", loginUserField);
//			}
//		}

//		public static string LoginDB
//		{
//			get
//			{
//				return loginDBField;
//			}
//			set
//			{
//				loginDBField = value;
//				SaveConfig("login_info/login_db", loginDBField);
//			}
//		}

//		public static string Line
//		{
//			get
//			{
//				return lineField;
//			}
//			set
//			{
//				lineField = value;
//				SaveConfig("mes_info/line", lineField);
//			}
//		}

//		public static string Section
//		{
//			get
//			{
//				return sectionField;
//			}
//			set
//			{
//				sectionField = value;
//				SaveConfig("mes_info/section", sectionField);
//			}
//		}

//		public static string Station
//		{
//			get
//			{
//				return stationField;
//			}
//			set
//			{
//				stationField = value;
//				SaveConfig("mes_info/station", stationField);
//			}
//		}

//		public static LoginType Logintype
//		{
//			get
//			{
//				return LoginTypeField;
//			}
//			set
//			{
//				LoginTypeField = value;
//			}
//		}

//		public static string ConnectionType => ConnectionTypeField;

//		public static void LoadConfig()
//		{
//			XmlDocument xmlDocument = new XmlDocument();
//			MESLog mESLog = new MESLog("Compal.MESComponent.ClientEnvConfig");
//			try
//			{
//				SetPath();
//				XmlNode newChild;
//				if (!Exists)
//				{
//					XmlNode xmlNode = xmlDocument.CreateElement("environment");
//					XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("client");
//					xmlAttribute.Value = "client";
//					xmlNode.Attributes.Append(xmlAttribute);
//					XmlNode xmlNode2 = xmlDocument.CreateElement("login_info");
//					newChild = xmlDocument.CreateElement("emp_no");
//					xmlNode2.AppendChild(newChild);
//					newChild = xmlDocument.CreateElement("login_db");
//					xmlNode2.AppendChild(newChild);
//					xmlNode.AppendChild(xmlNode2);
//					xmlNode2 = xmlDocument.CreateElement("mes_info");
//					newChild = xmlDocument.CreateElement("line");
//					xmlNode2.AppendChild(newChild);
//					newChild = xmlDocument.CreateElement("section");
//					xmlNode2.AppendChild(newChild);
//					newChild = xmlDocument.CreateElement("group");
//					xmlNode2.AppendChild(newChild);
//					newChild = xmlDocument.CreateElement("station");
//					xmlNode2.AppendChild(newChild);
//					xmlNode.AppendChild(xmlNode2);
//					xmlNode2 = xmlDocument.CreateElement("dll_path");
//					xmlNode.AppendChild(xmlNode2);
//					xmlNode2 = xmlDocument.CreateElement("client_language");
//					xmlNode2.InnerText = Thread.CurrentThread.CurrentUICulture.Name;
//					xmlNode.AppendChild(xmlNode2);
//					xmlNode2 = xmlDocument.CreateElement("client_parameter");
//					newChild = xmlDocument.CreateElement("check_domain");
//					newChild.InnerText = "true";
//					xmlNode2.AppendChild(newChild);
//					newChild = xmlDocument.CreateElement("load_in_memory");
//					newChild.InnerText = "true";
//					xmlNode2.AppendChild(newChild);
//					newChild = xmlDocument.CreateElement("connection_type");
//					newChild.InnerText = "APS";
//					xmlNode2.AppendChild(newChild);
//					newChild = xmlDocument.CreateElement("login_type");
//					newChild.InnerText = "Login";
//					xmlNode2.AppendChild(newChild);
//					xmlNode.AppendChild(xmlNode2);
//					xmlNode2 = xmlDocument.CreateElement("db_links");
//					XmlNode xmlNode3 = xmlDocument.CreateElement("db");
//					newChild = xmlDocument.CreateElement("name");
//					xmlNode3.AppendChild(newChild);
//					newChild = xmlDocument.CreateElement("host");
//					xmlNode3.AppendChild(newChild);
//					newChild = xmlDocument.CreateElement("port");
//					xmlNode3.AppendChild(newChild);
//					newChild = xmlDocument.CreateElement("user");
//					xmlNode3.AppendChild(newChild);
//					newChild = xmlDocument.CreateElement("password");
//					xmlNode3.AppendChild(newChild);
//					newChild = xmlDocument.CreateElement("sid");
//					xmlNode3.AppendChild(newChild);
//					xmlNode2.AppendChild(xmlNode3);
//					xmlNode.AppendChild(xmlNode2);
//					XmlDeclaration newChild2 = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", "yes");
//					xmlDocument.AppendChild(newChild2);
//					xmlDocument.AppendChild(xmlNode);
//					xmlDocument.Save(PATH);
//				}
//				xmlDocument.Load(PATH);
//				newChild = xmlDocument.SelectSingleNode("environment/dll_path");
//				dllPathField = newChild.InnerText;
//				newChild = xmlDocument.SelectSingleNode("environment/client_language");
//				clientLanguageField = newChild.InnerText;
//				newChild = xmlDocument.SelectSingleNode("environment/client_parameter/check_domain");
//				checkDomainField = Convert.ToBoolean(newChild.InnerText);
//				newChild = xmlDocument.SelectSingleNode("environment/client_parameter/connection_type");
//				ConnectionTypeField = newChild.InnerText;
//				newChild = xmlDocument.SelectSingleNode("environment/client_parameter/login_type");
//				string text = newChild.InnerText.ToUpper();
//				if (!(text == "LOGIN"))
//				{
//					if (text == "NOLOG")
//					{
//						LoginTypeField = LoginType.NoLog;
//					}
//					else
//					{
//						LoginTypeField = LoginType.None;
//					}
//				}
//				else
//				{
//					LoginTypeField = LoginType.Login;
//				}
//				newChild = xmlDocument.SelectSingleNode("environment/client_parameter/load_in_memory");
//				loadInMemoryField = Convert.ToBoolean(newChild.InnerText);
//				newChild = xmlDocument.SelectSingleNode("environment/mes_info/line");
//				lineField = newChild.InnerText;
//				newChild = xmlDocument.SelectSingleNode("environment/mes_info/section");
//				sectionField = newChild.InnerText;
//				newChild = xmlDocument.SelectSingleNode("environment/mes_info/station");
//				stationField = newChild.InnerText;
//				newChild = xmlDocument.SelectSingleNode("environment/login_info/emp_no");
//				loginUserField = newChild.InnerText;
//				newChild = xmlDocument.SelectSingleNode("environment/login_info/login_db");
//				loginDBField = newChild.InnerText;
//			}
//			catch (Exception ex)
//			{
//				if (mESLog.IsErrorEnabled)
//				{
//					mESLog.Error(ex.Message);
//					mESLog.Error(ex.StackTrace);
//				}
//			}
//		}

//		private static void SetPath()
//		{
//			if (CliUtils.fClientSystem == "Web")
//			{
//				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\infolight\\eep.net");
//				pathField = (string)registryKey.GetValue("WebClient Path");
//				if (pathField[pathField.Length - 1].ToString() != "\\")
//				{
//					pathField += "\\";
//				}
//			}
//			else
//			{
//				string fileName = Process.GetCurrentProcess().MainModule.FileName;
//				fileName = fileName.Substring(0, fileName.LastIndexOf("\\"));
//				pathField = fileName + "\\";
//			}
//			pathField += "ClientEnv.config";
//		}

//		private static void SaveConfig(string nodeName, string nodeValue)
//		{
//			XmlDocument xmlDocument = new XmlDocument();
//			MESLog mESLog = new MESLog("Compal.MESComponent.ClientEnvConfig");
//			try
//			{
//				xmlDocument.Load(PATH);
//				XmlNode xmlNode = xmlDocument.SelectSingleNode("environment/" + nodeName);
//				xmlNode.InnerText = nodeValue;
//				xmlDocument.Save(PATH);
//			}
//			catch (Exception ex)
//			{
//				if (mESLog.IsErrorEnabled)
//				{
//					mESLog.Error(ex.Message);
//				}
//			}
//		}
//	}
//}
