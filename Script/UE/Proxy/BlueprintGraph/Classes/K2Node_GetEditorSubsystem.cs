using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_GetEditorSubsystem")]
	public partial class UK2Node_GetEditorSubsystem : UK2Node_GetSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_GetEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}