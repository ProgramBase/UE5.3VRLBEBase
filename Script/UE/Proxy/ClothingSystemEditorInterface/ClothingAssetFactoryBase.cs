using Script.CoreUObject;
using Script.Library;

namespace Script.ClothingSystemEditorInterface
{
	[PathName("/Script/ClothingSystemEditorInterface.ClothingAssetFactoryBase")]
	public partial class UClothingAssetFactoryBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothingSystemEditorInterface.ClothingAssetFactoryBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}