using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.DynamicMeshCommitter")]
	public partial class UDynamicMeshCommitter : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.DynamicMeshCommitter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/ModelingComponents.DynamicMeshCommitter")]
	public interface IDynamicMeshCommitter : IInterface
	{
	}
}