using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.CubeGridToolBuilder")]
	public partial class UCubeGridToolBuilder : UInteractiveToolWithToolTargetsBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.CubeGridToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}