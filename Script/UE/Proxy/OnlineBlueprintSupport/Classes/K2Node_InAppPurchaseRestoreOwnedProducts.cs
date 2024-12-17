using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.OnlineBlueprintSupport
{
	[PathName("/Script/OnlineBlueprintSupport.K2Node_InAppPurchaseRestoreOwnedProducts")]
	public partial class UK2Node_InAppPurchaseRestoreOwnedProducts : UK2Node_BaseAsyncTask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineBlueprintSupport.K2Node_InAppPurchaseRestoreOwnedProducts");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}