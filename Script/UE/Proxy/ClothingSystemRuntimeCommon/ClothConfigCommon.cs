using Script.CoreUObject;
using Script.ClothingSystemRuntimeInterface;
using Script.Library;

namespace Script.ClothingSystemRuntimeCommon
{
	[PathName("/Script/ClothingSystemRuntimeCommon.ClothConfigCommon")]
	public partial class UClothConfigCommon : UClothConfigBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothingSystemRuntimeCommon.ClothConfigCommon");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}