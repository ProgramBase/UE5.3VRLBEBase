using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnEditorUtilityPIEEvent__PythonCallable.OnEditorUtilityPIEEvent__PythonCallable")]
	public partial class OnEditorUtilityPIEEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnEditorUtilityPIEEvent__PythonCallable.OnEditorUtilityPIEEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}