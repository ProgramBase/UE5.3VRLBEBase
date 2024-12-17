using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAsyncHandleSaveGame__PythonCallable.OnAsyncHandleSaveGame__PythonCallable")]
	public partial class OnAsyncHandleSaveGame__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAsyncHandleSaveGame__PythonCallable.OnAsyncHandleSaveGame__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}