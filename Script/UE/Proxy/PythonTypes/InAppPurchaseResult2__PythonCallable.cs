using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InAppPurchaseResult2__PythonCallable.InAppPurchaseResult2__PythonCallable")]
	public partial class InAppPurchaseResult2__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InAppPurchaseResult2__PythonCallable.InAppPurchaseResult2__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}