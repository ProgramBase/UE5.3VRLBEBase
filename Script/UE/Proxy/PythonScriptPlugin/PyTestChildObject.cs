using Script.CoreUObject;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PyTestChildObject")]
	public partial class UPyTestChildObject : UPyTestObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PyTestChildObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}