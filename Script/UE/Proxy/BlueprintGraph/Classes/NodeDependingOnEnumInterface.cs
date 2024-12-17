using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.NodeDependingOnEnumInterface")]
	public partial class UNodeDependingOnEnumInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.NodeDependingOnEnumInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/BlueprintGraph.NodeDependingOnEnumInterface")]
	public interface INodeDependingOnEnumInterface : IInterface
	{
	}
}