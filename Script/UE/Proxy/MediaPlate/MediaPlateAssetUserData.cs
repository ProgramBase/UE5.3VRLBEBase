using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MediaPlate
{
	[PathName("/Script/MediaPlate.MediaPlateAssetUserData")]
	public partial class UMediaPlateAssetUserData : UAssetUserData, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaPlate.MediaPlateAssetUserData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}