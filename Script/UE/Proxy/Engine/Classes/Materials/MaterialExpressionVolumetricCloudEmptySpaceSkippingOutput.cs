using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionVolumetricCloudEmptySpaceSkippingOutput")]
	public partial class UMaterialExpressionVolumetricCloudEmptySpaceSkippingOutput : UMaterialExpressionCustomOutput, IStaticClass
	{
		public FExpressionInput ContainsMatter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ContainsMatter, __ReturnBuffer);

					return *(FExpressionInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ContainsMatter, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionVolumetricCloudEmptySpaceSkippingOutput");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ContainsMatter = 0;
	}
}