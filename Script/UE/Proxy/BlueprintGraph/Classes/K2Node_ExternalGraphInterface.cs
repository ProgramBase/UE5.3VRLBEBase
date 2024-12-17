using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_ExternalGraphInterface")]
	public partial class UK2Node_ExternalGraphInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_ExternalGraphInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/BlueprintGraph.K2Node_ExternalGraphInterface")]
	public interface IK2Node_ExternalGraphInterface : IInterface
	{
	}
}