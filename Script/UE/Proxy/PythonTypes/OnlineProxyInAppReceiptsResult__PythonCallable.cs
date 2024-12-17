using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnlineProxyInAppReceiptsResult__PythonCallable.OnlineProxyInAppReceiptsResult__PythonCallable")]
	public partial class OnlineProxyInAppReceiptsResult__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnlineProxyInAppReceiptsResult__PythonCallable.OnlineProxyInAppReceiptsResult__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}