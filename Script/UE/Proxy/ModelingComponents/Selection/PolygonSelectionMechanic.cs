using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.PolygonSelectionMechanic")]
	public partial class UPolygonSelectionMechanic : UMeshTopologySelectionMechanic, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.PolygonSelectionMechanic");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}