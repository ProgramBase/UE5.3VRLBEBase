using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnListEntryReleasedDynamic__PythonCallable.OnListEntryReleasedDynamic__PythonCallable")]
	public partial class OnListEntryReleasedDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnListEntryReleasedDynamic__PythonCallable.OnListEntryReleasedDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}