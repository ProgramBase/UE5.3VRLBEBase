using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ToolMenuDynamicIsActionChecked__PythonCallable.ToolMenuDynamicIsActionChecked__PythonCallable")]
	public partial class ToolMenuDynamicIsActionChecked__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ToolMenuDynamicIsActionChecked__PythonCallable.ToolMenuDynamicIsActionChecked__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}