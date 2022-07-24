using BaseLib.Tools;
using System;
using System.Linq;
using System.Reflection;

namespace DLLClientLink.Tool
{
    public class CheckDll 
    {
		private string dllFilePath;
		public CheckDll()
		{
		}

		public CheckDll(string vDllFilePath)
		{
			dllFilePath = vDllFilePath;
		}

		public void SetDllFilePath(string vDllFilePath)
		{
			dllFilePath = vDllFilePath;
		}

		public ReturnResults Exec()
		{
			ReturnResults executionResult = new ReturnResults();
			executionResult.Status = false;
			string text = dllFilePath.Substring(dllFilePath.LastIndexOf('\\') + 1);
			string[] array = text.Split('.');
			if (array.AsQueryable().Last().ToUpper() == "DLL")
			{
			    Assembly assembly = Assembly.LoadFile(dllFilePath); // Assembly.LoadFile只载入相应的dll文件;Assembly.LoadFrom 会载入dll文件及其引用的其他dll 
				string text2 = array[0] + $".{GlobalData.TypeName}";
				Type type = assembly.GetType(text2);
				if (type != null)
				{
					executionResult.Message = "OK";
					executionResult.Anything = array[0].ToString();
					executionResult.Status = true;
				}
				else
				{
					executionResult.Message = "Assembly content is not acceptable. It must be named " + text2;
				}
			}
			else
			{
				executionResult.Message = "File name is not acceptable " + text;
			}
			return executionResult;
		}
	}
}
