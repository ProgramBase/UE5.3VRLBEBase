using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.PolyEditPreviewMesh")]
	public partial class UPolyEditPreviewMesh : UPreviewMesh, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.PolyEditPreviewMesh");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}