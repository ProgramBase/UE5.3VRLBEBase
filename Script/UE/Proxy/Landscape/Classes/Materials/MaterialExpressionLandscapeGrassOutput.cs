using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.MaterialExpressionLandscapeGrassOutput")]
	public partial class UMaterialExpressionLandscapeGrassOutput : UMaterialExpressionCustomOutput, IStaticClass
	{
		public TArray<FGrassInput> GrassTypes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GrassTypes, __ReturnBuffer);

					return *(TArray<FGrassInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GrassTypes, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.MaterialExpressionLandscapeGrassOutput");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GrassTypes = 0;
	}
}