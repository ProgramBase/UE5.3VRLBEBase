using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.AppleImageUtilsBlueprintSupport
{
	[PathName("/Script/AppleImageUtilsBlueprintSupport.K2Node_ConvertToPNG")]
	public partial class UK2Node_ConvertToPNG : UK2Node_BaseAsyncTask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AppleImageUtilsBlueprintSupport.K2Node_ConvertToPNG");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}