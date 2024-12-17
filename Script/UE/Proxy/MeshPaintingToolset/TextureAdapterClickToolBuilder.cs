using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.TextureAdapterClickToolBuilder")]
	public partial class UTextureAdapterClickToolBuilder : USingleClickToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaintingToolset.TextureAdapterClickToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}