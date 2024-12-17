using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationBlueprintLibrary
{
	[PathName("/Script/AnimationBlueprintLibrary.K2Node_SetAttributeKeyGeneric")]
	public partial class UK2Node_SetAttributeKeyGeneric : UK2Node_BaseAttributeActionNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationBlueprintLibrary.K2Node_SetAttributeKeyGeneric");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}