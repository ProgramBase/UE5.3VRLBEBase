using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_EventNodeInterface")]
	public partial class UK2Node_EventNodeInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_EventNodeInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/BlueprintGraph.K2Node_EventNodeInterface")]
	public interface IK2Node_EventNodeInterface : IInterface
	{
	}
}