using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.SparseVolumeTexture
{
	[PathName("/Script/SparseVolumeTexture.SparseVolumeTextureFactory")]
	public partial class USparseVolumeTextureFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SparseVolumeTexture.SparseVolumeTextureFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}