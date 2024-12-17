using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.OnlineBlueprintSupport
{
	[PathName("/Script/OnlineBlueprintSupport.K2Node_InAppPurchaseCheckout")]
	public partial class UK2Node_InAppPurchaseCheckout : UK2Node_BaseAsyncTask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineBlueprintSupport.K2Node_InAppPurchaseCheckout");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}