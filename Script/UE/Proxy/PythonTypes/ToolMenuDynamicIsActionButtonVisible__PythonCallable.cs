using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ToolMenuDynamicIsActionButtonVisible__PythonCallable.ToolMenuDynamicIsActionButtonVisible__PythonCallable")]
	public partial class ToolMenuDynamicIsActionButtonVisible__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ToolMenuDynamicIsActionButtonVisible__PythonCallable.ToolMenuDynamicIsActionButtonVisible__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}