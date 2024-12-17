using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PythonScriptCommandlet")]
	public partial class UPythonScriptCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PythonScriptCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}