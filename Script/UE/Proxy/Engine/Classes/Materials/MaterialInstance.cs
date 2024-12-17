using Script.CoreUObject;
using Script.PhysicsCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialInstance")]
	public partial class UMaterialInstance : UMaterialInterface, IStaticClass
	{
		public UPhysicalMaterial PhysMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysMaterial, __ReturnBuffer);

					return *(UPhysicalMaterial*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysMaterial, __InBuffer);
				}
			}
		}

		public UPhysicalMaterial PhysicalMaterialMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicalMaterialMap, __ReturnBuffer);

					return *(UPhysicalMaterial*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicalMaterialMap, __InBuffer);
				}
			}
		}

		public UMaterialInterface Parent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Parent, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
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

		public FMaterialOverrideNanite NaniteOverrideMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NaniteOverrideMaterial, __ReturnBuffer);

					return *(FMaterialOverrideNanite*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NaniteOverrideMaterial, __InBuffer);
				}
			}
		}

		public bool bHasStaticPermutationResource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasStaticPermutationResource, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasStaticPermutationResource, __InBuffer);
				}
			}
		}

		public bool bOverrideSubsurfaceProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideSubsurfaceProfile, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideSubsurfaceProfile, __InBuffer);
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

		public FMaterialInstanceBasePropertyOverrides BasePropertyOverrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BasePropertyOverrides, __ReturnBuffer);

					return *(FMaterialInstanceBasePropertyOverrides*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BasePropertyOverrides, __InBuffer);
				}
			}
		}

		public FStaticParameterSetRuntimeData StaticParametersRuntime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticParametersRuntime, __ReturnBuffer);

					return *(FStaticParameterSetRuntimeData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticParametersRuntime, __InBuffer);
				}
			}
		}

		public TArray<FGuid> ReferencedTextureGuids
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReferencedTextureGuids, __ReturnBuffer);

					return *(TArray<FGuid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReferencedTextureGuids, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PhysMaterial = 0;

		private static uint __PhysicalMaterialMap = 0;

		private static uint __Parent = 0;

		private static uint __NaniteOverrideMaterial = 0;

		private static uint __bHasStaticPermutationResource = 0;

		private static uint __bOverrideSubsurfaceProfile = 0;

		private static uint __ScalarParameterValues = 0;

		private static uint __VectorParameterValues = 0;

		private static uint __DoubleVectorParameterValues = 0;

		private static uint __TextureParameterValues = 0;

		private static uint __RuntimeVirtualTextureParameterValues = 0;

		private static uint __SparseVolumeTextureParameterValues = 0;

		private static uint __FontParameterValues = 0;

		private static uint __BasePropertyOverrides = 0;

		private static uint __StaticParametersRuntime = 0;

		private static uint __ReferencedTextureGuids = 0;
	}
}