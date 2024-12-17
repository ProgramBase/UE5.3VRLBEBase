using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/SimpleListItemEventDynamic__PythonCallable.SimpleListItemEventDynamic__PythonCallable")]
	public partial class SimpleListItemEventDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/SimpleListItemEventDynamic__PythonCallable.SimpleListItemEventDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}