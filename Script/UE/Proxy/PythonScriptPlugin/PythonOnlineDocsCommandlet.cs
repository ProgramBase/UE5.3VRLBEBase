using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PythonOnlineDocsCommandlet")]
	public partial class UPythonOnlineDocsCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PythonOnlineDocsCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}