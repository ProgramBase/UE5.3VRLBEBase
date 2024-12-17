using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.VirtualTexturingEditor
{
	[PathName("/Script/VirtualTexturingEditor.VirtualTextureBuilderThumbnailRenderer")]
	public partial class UVirtualTextureBuilderThumbnailRenderer : UTextureThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VirtualTexturingEditor.VirtualTextureBuilderThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}