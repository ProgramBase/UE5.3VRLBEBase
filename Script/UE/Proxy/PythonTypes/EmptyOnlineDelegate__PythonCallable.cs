using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/EmptyOnlineDelegate__PythonCallable.EmptyOnlineDelegate__PythonCallable")]
	public partial class EmptyOnlineDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/EmptyOnlineDelegate__PythonCallable.EmptyOnlineDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}