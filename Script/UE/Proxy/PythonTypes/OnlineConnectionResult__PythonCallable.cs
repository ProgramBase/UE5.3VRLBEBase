using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnlineConnectionResult__PythonCallable.OnlineConnectionResult__PythonCallable")]
	public partial class OnlineConnectionResult__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnlineConnectionResult__PythonCallable.OnlineConnectionResult__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}