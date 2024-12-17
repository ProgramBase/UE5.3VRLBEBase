using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnEditorUtilityTaskDynamicDelegate__PythonCallable.OnEditorUtilityTaskDynamicDelegate__PythonCallable")]
	public partial class OnEditorUtilityTaskDynamicDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnEditorUtilityTaskDynamicDelegate__PythonCallable.OnEditorUtilityTaskDynamicDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}