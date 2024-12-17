using Script.CoreUObject;
using Script.Library;

namespace Script.ClothingSystemRuntimeCommon
{
	[PathName("/Script/ClothingSystemRuntimeCommon.ClothSharedConfigCommon")]
	public partial class UClothSharedConfigCommon : UClothConfigCommon, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothingSystemRuntimeCommon.ClothSharedConfigCommon");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}