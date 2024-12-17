using Script.CoreUObject;
using Script.Library;

namespace Script.ClothPainter
{
	[PathName("/Script/ClothPainter.ClothingAssetExporter")]
	public partial class UClothingAssetExporter : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothPainter.ClothingAssetExporter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}