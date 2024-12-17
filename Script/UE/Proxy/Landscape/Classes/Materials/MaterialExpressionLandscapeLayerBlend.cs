using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.MaterialExpressionLandscapeLayerBlend")]
	public partial class UMaterialExpressionLandscapeLayerBlend : UMaterialExpression, IStaticClass
	{
		public TArray<FLayerBlendInput> Layers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Layers, __ReturnBuffer);

					return *(TArray<FLayerBlendInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Layers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.MaterialExpressionLandscapeLayerBlend");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Layers = 0;
	}
}