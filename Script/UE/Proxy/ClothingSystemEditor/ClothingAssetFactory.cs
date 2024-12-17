using Script.CoreUObject;
using Script.ClothingSystemEditorInterface;
using Script.Library;

namespace Script.ClothingSystemEditor
{
	[PathName("/Script/ClothingSystemEditor.ClothingAssetFactory")]
	public partial class UClothingAssetFactory : UClothingAssetFactoryBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothingSystemEditor.ClothingAssetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}