using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InAppPurchaseQuery2Result__PythonCallable.InAppPurchaseQuery2Result__PythonCallable")]
	public partial class InAppPurchaseQuery2Result__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InAppPurchaseQuery2Result__PythonCallable.InAppPurchaseQuery2Result__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}