using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionSparseVolumeTextureObject")]
	public partial class UMaterialExpressionSparseVolumeTextureObject : UMaterialExpressionSparseVolumeTextureBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionSparseVolumeTextureObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}