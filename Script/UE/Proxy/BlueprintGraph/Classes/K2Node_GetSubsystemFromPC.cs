using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_GetSubsystemFromPC")]
	public partial class UK2Node_GetSubsystemFromPC : UK2Node_GetSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_GetSubsystemFromPC");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}