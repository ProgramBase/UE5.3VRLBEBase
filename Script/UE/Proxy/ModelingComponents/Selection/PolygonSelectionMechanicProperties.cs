using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.PolygonSelectionMechanicProperties")]
	public partial class UDEPRECATED_PolygonSelectionMechanicProperties : UMeshTopologySelectionMechanicProperties, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.PolygonSelectionMechanicProperties");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}