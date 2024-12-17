using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.MaterialExpressionLandscapePhysicalMaterialOutput")]
	public partial class UMaterialExpressionLandscapePhysicalMaterialOutput : UMaterialExpressionCustomOutput, IStaticClass
	{
		public TArray<FPhysicalMaterialInput> Inputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Inputs, __ReturnBuffer);

					return *(TArray<FPhysicalMaterialInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Inputs, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.MaterialExpressionLandscapePhysicalMaterialOutput");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Inputs = 0;
	}
}