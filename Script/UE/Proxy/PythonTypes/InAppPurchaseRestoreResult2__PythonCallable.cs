using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InAppPurchaseRestoreResult2__PythonCallable.InAppPurchaseRestoreResult2__PythonCallable")]
	public partial class InAppPurchaseRestoreResult2__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InAppPurchaseRestoreResult2__PythonCallable.InAppPurchaseRestoreResult2__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}