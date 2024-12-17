using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StaticSparseVolumeTexture")]
	public partial class UStaticSparseVolumeTexture : UStreamableSparseVolumeTexture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.StaticSparseVolumeTexture");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}