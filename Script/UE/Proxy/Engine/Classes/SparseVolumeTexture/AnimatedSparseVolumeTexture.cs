using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimatedSparseVolumeTexture")]
	public partial class UAnimatedSparseVolumeTexture : UStreamableSparseVolumeTexture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimatedSparseVolumeTexture");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}