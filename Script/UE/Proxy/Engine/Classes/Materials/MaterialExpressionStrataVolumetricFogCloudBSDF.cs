using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionStrataVolumetricFogCloudBSDF")]
	public partial class UMaterialExpressionStrataVolumetricFogCloudBSDF : UMaterialExpressionStrataBSDF, IStaticClass
	{
		public FExpressionInput Albedo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Albedo, __ReturnBuffer);

					return *(FExpressionInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Albedo, __InBuffer);
				}
			}
		}

		public FExpressionInput Extinction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Extinction, __ReturnBuffer);

					return *(FExpressionInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Extinction, __InBuffer);
				}
			}
		}

		public FExpressionInput EmissiveColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EmissiveColor, __ReturnBuffer);

					return *(FExpressionInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EmissiveColor, __InBuffer);
				}
			}
		}

		public FExpressionInput AmbientOcclusion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AmbientOcclusion, __ReturnBuffer);

					return *(FExpressionInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AmbientOcclusion, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionStrataVolumetricFogCloudBSDF");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Albedo = 0;

		private static uint __Extinction = 0;

		private static uint __EmissiveColor = 0;

		private static uint __AmbientOcclusion = 0;
	}
}