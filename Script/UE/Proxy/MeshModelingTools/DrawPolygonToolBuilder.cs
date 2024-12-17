using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.DrawPolygonToolBuilder")]
	public partial class UDrawPolygonToolBuilder : UInteractiveToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.DrawPolygonToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}