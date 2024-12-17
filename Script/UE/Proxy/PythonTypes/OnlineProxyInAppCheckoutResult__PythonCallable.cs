using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnlineProxyInAppCheckoutResult__PythonCallable.OnlineProxyInAppCheckoutResult__PythonCallable")]
	public partial class OnlineProxyInAppCheckoutResult__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnlineProxyInAppCheckoutResult__PythonCallable.OnlineProxyInAppCheckoutResult__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}