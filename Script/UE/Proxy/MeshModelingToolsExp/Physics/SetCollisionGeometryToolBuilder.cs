using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.SetCollisionGeometryToolBuilder")]
	public partial class USetCollisionGeometryToolBuilder : UMultiSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.SetCollisionGeometryToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}