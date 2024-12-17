using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnlineLogoutResult__PythonCallable.OnlineLogoutResult__PythonCallable")]
	public partial class OnlineLogoutResult__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnlineLogoutResult__PythonCallable.OnlineLogoutResult__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}