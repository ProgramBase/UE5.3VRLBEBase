using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.AnimationBlueprintLibrary
{
	[PathName("/Script/AnimationBlueprintLibrary.K2Node_BaseAttributeActionNode")]
	public partial class UK2Node_BaseAttributeActionNode : UK2Node_CallFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationBlueprintLibrary.K2Node_BaseAttributeActionNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}