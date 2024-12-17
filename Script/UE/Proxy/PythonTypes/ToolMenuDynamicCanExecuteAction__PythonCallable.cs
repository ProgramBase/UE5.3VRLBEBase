using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ToolMenuDynamicCanExecuteAction__PythonCallable.ToolMenuDynamicCanExecuteAction__PythonCallable")]
	public partial class ToolMenuDynamicCanExecuteAction__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ToolMenuDynamicCanExecuteAction__PythonCallable.ToolMenuDynamicCanExecuteAction__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}