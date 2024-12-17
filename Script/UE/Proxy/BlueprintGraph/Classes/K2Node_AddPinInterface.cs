using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_AddPinInterface")]
	public partial class UK2Node_AddPinInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_AddPinInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/BlueprintGraph.K2Node_AddPinInterface")]
	public interface IK2Node_AddPinInterface : IInterface
	{
	}
}