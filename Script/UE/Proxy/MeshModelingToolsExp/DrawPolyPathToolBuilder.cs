using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.DrawPolyPathToolBuilder")]
	public partial class UDrawPolyPathToolBuilder : UMeshSurfacePointToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.DrawPolyPathToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}