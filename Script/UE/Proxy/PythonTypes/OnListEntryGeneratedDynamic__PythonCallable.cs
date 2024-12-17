using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnListEntryGeneratedDynamic__PythonCallable.OnListEntryGeneratedDynamic__PythonCallable")]
	public partial class OnListEntryGeneratedDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnListEntryGeneratedDynamic__PythonCallable.OnListEntryGeneratedDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}