using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.TexturePaintToolset")]
	public partial class UTexturePaintToolset : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaintingToolset.TexturePaintToolset");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}