using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionSparseVolumeTextureBase")]
	public partial class UMaterialExpressionSparseVolumeTextureBase : UMaterialExpression, IStaticClass
	{
		public USparseVolumeTexture SparseVolumeTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SparseVolumeTexture, __ReturnBuffer);

					return *(USparseVolumeTexture*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SparseVolumeTexture, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionSparseVolumeTextureBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SparseVolumeTexture = 0;
	}
}