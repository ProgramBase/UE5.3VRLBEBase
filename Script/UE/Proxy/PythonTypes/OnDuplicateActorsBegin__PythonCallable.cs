using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnDuplicateActorsBegin__PythonCallable.OnDuplicateActorsBegin__PythonCallable")]
	public partial class OnDuplicateActorsBegin__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnDuplicateActorsBegin__PythonCallable.OnDuplicateActorsBegin__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}