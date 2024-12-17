using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ToolMenuDynamicExecuteAction__PythonCallable.ToolMenuDynamicExecuteAction__PythonCallable")]
	public partial class ToolMenuDynamicExecuteAction__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ToolMenuDynamicExecuteAction__PythonCallable.ToolMenuDynamicExecuteAction__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}