using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnlineShowLoginUIResult__PythonCallable.OnlineShowLoginUIResult__PythonCallable")]
	public partial class OnlineShowLoginUIResult__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnlineShowLoginUIResult__PythonCallable.OnlineShowLoginUIResult__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}