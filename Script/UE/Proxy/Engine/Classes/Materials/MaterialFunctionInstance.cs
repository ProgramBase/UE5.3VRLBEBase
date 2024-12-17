using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialFunctionInstance")]
	public partial class UMaterialFunctionInstance : UMaterialFunctionInterface, IStaticClass
	{
		public UMaterialFunctionInterface Parent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Parent, __ReturnBuffer);

					return *(UMaterialFunctionInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Parent, __InBuffer);
				}
			}
		}

		public UMaterialFunctionInterface Base
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Base, __ReturnBuffer);

					return *(UMaterialFunctionInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Base, __InBuffer);
				}
			}
		}

		public TArray<FScalarParameterValue> ScalarParameterValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScalarParameterValues, __ReturnBuffer);

					return *(TArray<FScalarParameterValue>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScalarParameterValues, __InBuffer);
				}
			}
		}

		public TArray<FVectorParameterValue> VectorParameterValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VectorParameterValues, __ReturnBuffer);

					return *(TArray<FVectorParameterValue>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VectorParameterValues, __InBuffer);
				}
			}
		}

		public TArray<FDoubleVectorParameterValue> DoubleVectorParameterValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DoubleVectorParameterValues, __ReturnBuffer);

					return *(TArray<FDoubleVectorParameterValue>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DoubleVectorParameterValues, __InBuffer);
				}
			}
		}

		public TArray<FTextureParameterValue> TextureParameterValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureParameterValues, __ReturnBuffer);

					return *(TArray<FTextureParameterValue>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureParameterValues, __InBuffer);
				}
			}
		}

		public TArray<FFontParameterValue> FontParameterValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FontParameterValues, __ReturnBuffer);

					return *(TArray<FFontParameterValue>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FontParameterValues, __InBuffer);
				}
			}
		}

		public TArray<FStaticSwitchParameter> StaticSwitchParameterValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticSwitchParameterValues, __ReturnBuffer);

					return *(TArray<FStaticSwitchParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticSwitchParameterValues, __InBuffer);
				}
			}
		}

		public TArray<FStaticComponentMaskParameter> StaticComponentMaskParameterValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticComponentMaskParameterValues, __ReturnBuffer);

					return *(TArray<FStaticComponentMaskParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticComponentMaskParameterValues, __InBuffer);
				}
			}
		}

		public TArray<FRuntimeVirtualTextureParameterValue> RuntimeVirtualTextureParameterValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RuntimeVirtualTextureParameterValues, __ReturnBuffer);

					return *(TArray<FRuntimeVirtualTextureParameterValue>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RuntimeVirtualTextureParameterValues, __InBuffer);
				}
			}
		}

		public TArray<FSparseVolumeTextureParameterValue> SparseVolumeTextureParameterValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SparseVolumeTextureParameterValues, __ReturnBuffer);

					return *(TArray<FSparseVolumeTextureParameterValue>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SparseVolumeTextureParameterValues, __InBuffer);
				}
			}
		}

		public UMaterialInstanceConstant PreviewMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMaterial, __ReturnBuffer);

					return *(UMaterialInstanceConstant*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMaterial, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialFunctionInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Parent = 0;

		private static uint __Base = 0;

		private static uint __ScalarParameterValues = 0;

		private static uint __VectorParameterValues = 0;

		private static uint __DoubleVectorParameterValues = 0;

		private static uint __TextureParameterValues = 0;

		private static uint __FontParameterValues = 0;

		private static uint __StaticSwitchParameterValues = 0;

		private static uint __StaticComponentMaskParameterValues = 0;

		private static uint __RuntimeVirtualTextureParameterValues = 0;

		private static uint __SparseVolumeTextureParameterValues = 0;

		private static uint __PreviewMaterial = 0;
	}
}