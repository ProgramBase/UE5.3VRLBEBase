﻿using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.OnlineBlueprintSupport
{
	[PathName("/Script/OnlineBlueprintSupport.K2Node_InAppPurchaseGetKnownReceipts")]
	public partial class UK2Node_InAppPurchaseGetKnownReceipts : UK2Node_BaseAsyncTask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineBlueprintSupport.K2Node_InAppPurchaseGetKnownReceipts");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}