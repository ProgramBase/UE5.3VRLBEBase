using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.AppleImageUtilsBlueprintSupport
{
	[PathName("/Script/AppleImageUtilsBlueprintSupport.K2Node_ConvertToJPEG")]
	public partial class UK2Node_ConvertToJPEG : UK2Node_BaseAsyncTask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AppleImageUtilsBlueprintSupport.K2Node_ConvertToJPEG");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}