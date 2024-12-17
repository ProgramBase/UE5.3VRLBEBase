using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationBlueprintLibrary
{
	[PathName("/Script/AnimationBlueprintLibrary.K2Node_SetAttributeKeysGeneric")]
	public partial class UK2Node_SetAttributeKeysGeneric : UK2Node_BaseAttributeActionNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationBlueprintLibrary.K2Node_SetAttributeKeysGeneric");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}