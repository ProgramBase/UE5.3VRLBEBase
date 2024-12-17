using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/AsyncEditorWaitForGameWorldEvent__PythonCallable.AsyncEditorWaitForGameWorldEvent__PythonCallable")]
	public partial class AsyncEditorWaitForGameWorldEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/AsyncEditorWaitForGameWorldEvent__PythonCallable.AsyncEditorWaitForGameWorldEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}