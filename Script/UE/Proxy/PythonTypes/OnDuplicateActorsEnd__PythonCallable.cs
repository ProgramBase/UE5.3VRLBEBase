using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnDuplicateActorsEnd__PythonCallable.OnDuplicateActorsEnd__PythonCallable")]
	public partial class OnDuplicateActorsEnd__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnDuplicateActorsEnd__PythonCallable.OnDuplicateActorsEnd__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}