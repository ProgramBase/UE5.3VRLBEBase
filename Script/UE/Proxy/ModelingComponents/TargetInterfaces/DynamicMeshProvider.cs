using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.DynamicMeshProvider")]
	public partial class UDynamicMeshProvider : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.DynamicMeshProvider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/ModelingComponents.DynamicMeshProvider")]
	public interface IDynamicMeshProvider : IInterface
	{
	}
}