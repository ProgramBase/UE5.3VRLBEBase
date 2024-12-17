using Script.CoreUObject;
using Script.Library;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.TextureAdapterClickTool")]
	public partial class UTextureAdapterClickTool : UMeshClickTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaintingToolset.TextureAdapterClickTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}