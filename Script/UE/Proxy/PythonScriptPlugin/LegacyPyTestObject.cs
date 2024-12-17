using Script.CoreUObject;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.LegacyPyTestObject")]
	public partial class UDEPRECATED_LegacyPyTestObject : UPyTestObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.LegacyPyTestObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}