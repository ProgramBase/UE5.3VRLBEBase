using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.AppleImageUtilsBlueprintSupport
{
	[PathName("/Script/AppleImageUtilsBlueprintSupport.K2Node_ConvertToTIFF")]
	public partial class UK2Node_ConvertToTIFF : UK2Node_BaseAsyncTask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AppleImageUtilsBlueprintSupport.K2Node_ConvertToTIFF");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}