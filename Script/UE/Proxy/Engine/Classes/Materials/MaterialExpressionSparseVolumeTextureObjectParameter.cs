using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionSparseVolumeTextureObjectParameter")]
	public partial class UMaterialExpressionSparseVolumeTextureObjectParameter : UMaterialExpressionSparseVolumeTextureSampleParameter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionSparseVolumeTextureObjectParameter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}