using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.BoundarySelectionMechanic")]
	public partial class UBoundarySelectionMechanic : UMeshTopologySelectionMechanic, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.BoundarySelectionMechanic");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}