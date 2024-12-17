using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnListEntryInitializedDynamic__PythonCallable.OnListEntryInitializedDynamic__PythonCallable")]
	public partial class OnListEntryInitializedDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnListEntryInitializedDynamic__PythonCallable.OnListEntryInitializedDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}