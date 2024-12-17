using Script.CoreUObject;
using Script.Engine;
using Script.PhysicsCore;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeProxy")]
	public partial class ALandscapeProxy : APartitionActor, IStaticClass, ILandscapeSplineInterface
	{
		public ULandscapeSplinesComponent SplineComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SplineComponent, __ReturnBuffer);

					return *(ULandscapeSplinesComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SplineComponent, __InBuffer);
				}
			}
		}

		public FGuid LandscapeGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeGuid, __InBuffer);
				}
			}
		}

		public bool bEnableNanite
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableNanite, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableNanite, __InBuffer);
				}
			}
		}

		public TArray<FLandscapePerLODMaterialOverride> PerLODOverrideMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerLODOverrideMaterials, __ReturnBuffer);

					return *(TArray<FLandscapePerLODMaterialOverride>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerLODOverrideMaterials, __InBuffer);
				}
			}
		}

		public TArray<FLandscapePerLODMaterialOverride> PreEditPerLODOverrideMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreEditPerLODOverrideMaterials, __ReturnBuffer);

					return *(TArray<FLandscapePerLODMaterialOverride>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreEditPerLODOverrideMaterials, __InBuffer);
				}
			}
		}

		public int NaniteLODIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NaniteLODIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NaniteLODIndex, __InBuffer);
				}
			}
		}

		public bool bNaniteSkirtEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNaniteSkirtEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNaniteSkirtEnabled, __InBuffer);
				}
			}
		}

		public float NaniteSkirtDepth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NaniteSkirtDepth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NaniteSkirtDepth, __InBuffer);
				}
			}
		}

		public FIntPoint LandscapeSectionOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeSectionOffset, __ReturnBuffer);

					return *(FIntPoint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeSectionOffset, __InBuffer);
				}
			}
		}

		public int MaxLODLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxLODLevel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxLODLevel, __InBuffer);
				}
			}
		}

		public float ComponentScreenSizeToUseSubSections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentScreenSizeToUseSubSections, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentScreenSizeToUseSubSections, __InBuffer);
				}
			}
		}

		public float LOD0ScreenSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LOD0ScreenSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LOD0ScreenSize, __InBuffer);
				}
			}
		}

		public uint LODGroupKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODGroupKey, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODGroupKey, __InBuffer);
				}
			}
		}

		public float LOD0DistributionSetting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LOD0DistributionSetting, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LOD0DistributionSetting, __InBuffer);
				}
			}
		}

		public float LODDistributionSetting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODDistributionSetting, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODDistributionSetting, __InBuffer);
				}
			}
		}

		public int ExportLOD
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExportLOD, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExportLOD, __InBuffer);
				}
			}
		}

		public TArray<FName> TargetDisplayOrderList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetDisplayOrderList, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetDisplayOrderList, __InBuffer);
				}
			}
		}

		public ELandscapeLayerDisplayMode TargetDisplayOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetDisplayOrder, __ReturnBuffer);

					return *(ELandscapeLayerDisplayMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetDisplayOrder, __InBuffer);
				}
			}
		}

		public int StaticLightingLOD
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticLightingLOD, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticLightingLOD, __InBuffer);
				}
			}
		}

		public UPhysicalMaterial DefaultPhysMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultPhysMaterial, __ReturnBuffer);

					return *(UPhysicalMaterial*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultPhysMaterial, __InBuffer);
				}
			}
		}

		public float StreamingDistanceMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingDistanceMultiplier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingDistanceMultiplier, __InBuffer);
				}
			}
		}

		public UMaterialInterface LandscapeMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeMaterial, __InBuffer);
				}
			}
		}

		public UMaterialInterface LandscapeHoleMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeHoleMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeHoleMaterial, __InBuffer);
				}
			}
		}

		public UMaterialInterface PreEditLandscapeMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreEditLandscapeMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreEditLandscapeMaterial, __InBuffer);
				}
			}
		}

		public UMaterialInterface PreEditLandscapeHoleMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreEditLandscapeHoleMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreEditLandscapeHoleMaterial, __InBuffer);
				}
			}
		}

		public bool bIsPerformingInteractiveActionOnLandscapeMaterialOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsPerformingInteractiveActionOnLandscapeMaterialOverride, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsPerformingInteractiveActionOnLandscapeMaterialOverride, __InBuffer);
				}
			}
		}

		public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RuntimeVirtualTextures, __ReturnBuffer);

					return *(TArray<URuntimeVirtualTexture>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RuntimeVirtualTextures, __InBuffer);
				}
			}
		}

		public bool bSetCreateRuntimeVirtualTextureVolumes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSetCreateRuntimeVirtualTextureVolumes, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSetCreateRuntimeVirtualTextureVolumes, __InBuffer);
				}
			}
		}

		public bool bVirtualTextureRenderWithQuad
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bVirtualTextureRenderWithQuad, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bVirtualTextureRenderWithQuad, __InBuffer);
				}
			}
		}

		public bool bVirtualTextureRenderWithQuadHQ
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bVirtualTextureRenderWithQuadHQ, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bVirtualTextureRenderWithQuadHQ, __InBuffer);
				}
			}
		}

		public int VirtualTextureNumLods
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureNumLods, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureNumLods, __InBuffer);
				}
			}
		}

		public int VirtualTextureLodBias
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureLodBias, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureLodBias, __InBuffer);
				}
			}
		}

		public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureRenderPassType, __ReturnBuffer);

					return *(ERuntimeVirtualTextureMainPassType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureRenderPassType, __InBuffer);
				}
			}
		}

		public float NegativeZBoundsExtension
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NegativeZBoundsExtension, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NegativeZBoundsExtension, __InBuffer);
				}
			}
		}

		public float PositiveZBoundsExtension
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PositiveZBoundsExtension, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PositiveZBoundsExtension, __InBuffer);
				}
			}
		}

		public TArray<ULandscapeComponent> LandscapeComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeComponents, __ReturnBuffer);

					return *(TArray<ULandscapeComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeComponents, __InBuffer);
				}
			}
		}

		public TArray<ULandscapeHeightfieldCollisionComponent> CollisionComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionComponents, __ReturnBuffer);

					return *(TArray<ULandscapeHeightfieldCollisionComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionComponents, __InBuffer);
				}
			}
		}

		public TArray<UHierarchicalInstancedStaticMeshComponent> FoliageComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageComponents, __ReturnBuffer);

					return *(TArray<UHierarchicalInstancedStaticMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageComponents, __InBuffer);
				}
			}
		}

		public TArray<ULandscapeNaniteComponent> NaniteComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NaniteComponents, __ReturnBuffer);

					return *(TArray<ULandscapeNaniteComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NaniteComponents, __InBuffer);
				}
			}
		}

		public bool bHasLandscapeGrass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasLandscapeGrass, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasLandscapeGrass, __InBuffer);
				}
			}
		}

		public float StaticLightingResolution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticLightingResolution, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticLightingResolution, __InBuffer);
				}
			}
		}

		public bool CastShadow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CastShadow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CastShadow, __InBuffer);
				}
			}
		}

		public bool bCastDynamicShadow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCastDynamicShadow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCastDynamicShadow, __InBuffer);
				}
			}
		}

		public bool bCastStaticShadow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCastStaticShadow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCastStaticShadow, __InBuffer);
				}
			}
		}

		public EShadowCacheInvalidationBehavior ShadowCacheInvalidationBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowCacheInvalidationBehavior, __ReturnBuffer);

					return *(EShadowCacheInvalidationBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowCacheInvalidationBehavior, __InBuffer);
				}
			}
		}

		public bool bCastContactShadow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCastContactShadow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCastContactShadow, __InBuffer);
				}
			}
		}

		public bool bCastFarShadow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCastFarShadow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCastFarShadow, __InBuffer);
				}
			}
		}

		public bool bCastHiddenShadow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCastHiddenShadow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCastHiddenShadow, __InBuffer);
				}
			}
		}

		public bool bCastShadowAsTwoSided
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCastShadowAsTwoSided, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCastShadowAsTwoSided, __InBuffer);
				}
			}
		}

		public bool bAffectDistanceFieldLighting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAffectDistanceFieldLighting, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAffectDistanceFieldLighting, __InBuffer);
				}
			}
		}

		public FLightingChannels LightingChannels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightingChannels, __ReturnBuffer);

					return *(FLightingChannels*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightingChannels, __InBuffer);
				}
			}
		}

		public bool bUseMaterialPositionOffsetInStaticLighting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseMaterialPositionOffsetInStaticLighting, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseMaterialPositionOffsetInStaticLighting, __InBuffer);
				}
			}
		}

		public bool bRenderCustomDepth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRenderCustomDepth, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRenderCustomDepth, __InBuffer);
				}
			}
		}

		public ERendererStencilMask CustomDepthStencilWriteMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomDepthStencilWriteMask, __ReturnBuffer);

					return *(ERendererStencilMask*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomDepthStencilWriteMask, __InBuffer);
				}
			}
		}

		public int CustomDepthStencilValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomDepthStencilValue, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomDepthStencilValue, __InBuffer);
				}
			}
		}

		public float LDMaxDrawDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LDMaxDrawDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LDMaxDrawDistance, __InBuffer);
				}
			}
		}

		public FLightmassPrimitiveSettings LightmassSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightmassSettings, __ReturnBuffer);

					return *(FLightmassPrimitiveSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightmassSettings, __InBuffer);
				}
			}
		}

		public int CollisionMipLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionMipLevel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionMipLevel, __InBuffer);
				}
			}
		}

		public int SimpleCollisionMipLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SimpleCollisionMipLevel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SimpleCollisionMipLevel, __InBuffer);
				}
			}
		}

		public FBodyInstance BodyInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BodyInstance, __ReturnBuffer);

					return *(FBodyInstance*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BodyInstance, __InBuffer);
				}
			}
		}

		public bool bGenerateOverlapEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bGenerateOverlapEvents, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bGenerateOverlapEvents, __InBuffer);
				}
			}
		}

		public bool bBakeMaterialPositionOffsetIntoCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bBakeMaterialPositionOffsetIntoCollision, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bBakeMaterialPositionOffsetIntoCollision, __InBuffer);
				}
			}
		}

		public FString ReimportHeightmapFilePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReimportHeightmapFilePath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReimportHeightmapFilePath, __InBuffer);
				}
			}
		}

		public FGuid ReimportDestinationLayerGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReimportDestinationLayerGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReimportDestinationLayerGuid, __InBuffer);
				}
			}
		}

		public TArray<FLandscapeEditorLayerSettings> EditorLayerSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorLayerSettings, __ReturnBuffer);

					return *(TArray<FLandscapeEditorLayerSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorLayerSettings, __InBuffer);
				}
			}
		}

		public TMap<UTexture2D, ULandscapeWeightmapUsage> WeightmapUsageMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WeightmapUsageMap, __ReturnBuffer);

					return *(TMap<UTexture2D, ULandscapeWeightmapUsage>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WeightmapUsageMap, __InBuffer);
				}
			}
		}

		public int ComponentSizeQuads
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentSizeQuads, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentSizeQuads, __InBuffer);
				}
			}
		}

		public int SubsectionSizeQuads
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubsectionSizeQuads, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubsectionSizeQuads, __InBuffer);
				}
			}
		}

		public int NumSubsections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumSubsections, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumSubsections, __InBuffer);
				}
			}
		}

		public bool bUsedForNavigation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUsedForNavigation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUsedForNavigation, __InBuffer);
				}
			}
		}

		public bool bFillCollisionUnderLandscapeForNavmesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFillCollisionUnderLandscapeForNavmesh, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFillCollisionUnderLandscapeForNavmesh, __InBuffer);
				}
			}
		}

		public ENavDataGatheringMode NavigationGeometryGatheringMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavigationGeometryGatheringMode, __ReturnBuffer);

					return *(ENavDataGatheringMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavigationGeometryGatheringMode, __InBuffer);
				}
			}
		}

		public bool bUseDynamicMaterialInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseDynamicMaterialInstance, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseDynamicMaterialInstance, __InBuffer);
				}
			}
		}

		public int MaxPaintedLayersPerComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxPaintedLayersPerComponent, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxPaintedLayersPerComponent, __InBuffer);
				}
			}
		}

		public bool bUseLandscapeForCullingInvisibleHLODVertices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseLandscapeForCullingInvisibleHLODVertices, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseLandscapeForCullingInvisibleHLODVertices, __InBuffer);
				}
			}
		}

		public bool bHasLayersContent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasLayersContent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasLayersContent, __InBuffer);
				}
			}
		}

		public bool bUseCompressedHeightmapStorage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseCompressedHeightmapStorage, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseCompressedHeightmapStorage, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.LandscapeProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void SetVirtualTextureRenderPassType(ERuntimeVirtualTextureMainPassType InType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVirtualTextureRenderPassType, __InBuffer);
			}
		}

		public virtual void SetLandscapeMaterialVectorParameterValue(FName ParameterName, FLinearColor Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLandscapeMaterialVectorParameterValue, __InBuffer);
			}
		}

		public virtual void SetLandscapeMaterialTextureParameterValue(FName ParameterName, UTexture Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLandscapeMaterialTextureParameterValue, __InBuffer);
			}
		}

		public virtual void SetLandscapeMaterialScalarParameterValue(FName ParameterName, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLandscapeMaterialScalarParameterValue, __InBuffer);
			}
		}

		public virtual bool LandscapeImportWeightmapFromRenderTarget(UTextureRenderTarget2D InRenderTarget, FName InLayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InLayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __LandscapeImportWeightmapFromRenderTarget, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InRenderTarget">
		/// - Valid render target with a format of RTF_RGBA16f, RTF_RGBA32f or RTF_RGBA8
		/// </param>
		/// <param name="InImportHeightFromRGChannel">
		/// - Only relevant when using format RTF_RGBA16f or RTF_RGBA32f, and will tell us if we should import the height data from the R channel only of the Render target or from R & G. 
		/// Note that using RTF_RGBA16f with InImportHeightFromRGChannel == false, could have precision loss
		/// Only works in the editor
		/// </param>
		public virtual bool LandscapeImportHeightmapFromRenderTarget(UTextureRenderTarget2D InRenderTarget, bool InImportHeightFromRGChannel = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = InImportHeightFromRGChannel;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __LandscapeImportHeightmapFromRenderTarget, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool LandscapeExportWeightmapToRenderTarget(UTextureRenderTarget2D InRenderTarget, FName InLayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InLayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __LandscapeExportWeightmapToRenderTarget, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InRenderTarget">
		/// - Valid render target with a format of RTF_RGBA16f, RTF_RGBA32f or RTF_RGBA8
		/// </param>
		/// <param name="InExportHeightIntoRGChannel">
		/// - Tell us if we should export the height that is internally stored as R & G (for 16 bits) to a single R channel of the render target (the format need to be RTF_RGBA16f or RTF_RGBA32f)
		/// Note that using RTF_RGBA16f with InExportHeightIntoRGChannel == false, could have precision loss.
		/// </param>
		/// <param name="InExportLandscapeProxies">
		/// - Option to also export components of all proxies of Landscape actor (if LandscapeProxy is the Landscape Actor)
		/// </param>
		public virtual bool LandscapeExportHeightmapToRenderTarget(UTextureRenderTarget2D InRenderTarget, bool InExportHeightIntoRGChannel = false, bool InExportLandscapeProxies = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = InExportHeightIntoRGChannel;

				*(bool*)(__InBuffer + 9) = InExportLandscapeProxies;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __LandscapeExportHeightmapToRenderTarget, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual ALandscape GetLandscapeActor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLandscapeActor, __ReturnBuffer);

				return *(ALandscape*)__ReturnBuffer;
			}
		}

		public virtual void EditorSetLandscapeMaterial(UMaterialInterface NewLandscapeMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewLandscapeMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EditorSetLandscapeMaterial, __InBuffer);
			}
		}

		/// <param name="InSplineComponent">
		/// - The component containing the spline data
		/// </param>
		/// <param name="StartWidth">
		/// - Width of the spline at the start node, in Spline Component local space
		/// </param>
		/// <param name="EndWidth">
		/// - Width of the spline at the end node, in Spline Component local space
		/// </param>
		/// <param name="StartSideFalloff">
		/// - Width of the falloff at either side of the spline at the start node, in Spline Component local space
		/// </param>
		/// <param name="EndSideFalloff">
		/// - Width of the falloff at either side of the spline at the end node, in Spline Component local space
		/// </param>
		/// <param name="StartRoll">
		/// - Roll applied to the spline at the start node, in degrees. 0 is flat
		/// </param>
		/// <param name="EndRoll">
		/// - Roll applied to the spline at the end node, in degrees. 0 is flat
		/// </param>
		/// <param name="NumSubdivisions">
		/// - Number of triangles to place along the spline when applying it to the landscape. Higher numbers give better results, but setting it too high will be slow and may cause artifacts
		/// </param>
		/// <param name="bRaiseHeights">
		/// - Allow the landscape to be raised up to the level of the spline. If both bRaiseHeights and bLowerHeights are false, no height modification of the landscape will be performed
		/// </param>
		/// <param name="bLowerHeights">
		/// - Allow the landscape to be lowered down to the level of the spline. If both bRaiseHeights and bLowerHeights are false, no height modification of the landscape will be performed
		/// </param>
		/// <param name="PaintLayer">
		/// - LayerInfo to paint, or none to skip painting. The landscape must be configured with the same layer info in one of its layers or this will do nothing!
		/// </param>
		/// <param name="EditLayerName">
		/// - Name of the landscape edition layer to affect (in Edit Layers mode)
		/// </param>
		public virtual void EditorApplySpline(USplineComponent InSplineComponent, float StartWidth = 200.000000f, float EndWidth = 200.000000f, float StartSideFalloff = 200.000000f, float EndSideFalloff = 200.000000f, float StartRoll = 0.000000f, float EndRoll = 0.000000f, int NumSubdivisions = 20, bool bRaiseHeights = true, bool bLowerHeights = true, ULandscapeLayerInfoObject PaintLayer = null, FName EditLayerName = null)
		{
			unsafe
			{
				EditLayerName ??= new FName("");

				var __InBuffer = stackalloc byte[54];

				*(nint*)(__InBuffer) = InSplineComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StartWidth;

				*(float*)(__InBuffer + 12) = EndWidth;

				*(float*)(__InBuffer + 16) = StartSideFalloff;

				*(float*)(__InBuffer + 20) = EndSideFalloff;

				*(float*)(__InBuffer + 24) = StartRoll;

				*(float*)(__InBuffer + 28) = EndRoll;

				*(int*)(__InBuffer + 32) = NumSubdivisions;

				*(bool*)(__InBuffer + 36) = bRaiseHeights;

				*(bool*)(__InBuffer + 37) = bLowerHeights;

				*(nint*)(__InBuffer + 38) = PaintLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 46) = EditLayerName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EditorApplySpline, __InBuffer);
			}
		}

		public virtual void ChangeLODDistanceFactor(float InLODDistanceFactor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InLODDistanceFactor;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ChangeLODDistanceFactor, __InBuffer);
			}
		}

		public virtual void ChangeComponentScreenSizeToUseSubSections(float InComponentScreenSizeToUseSubSections)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InComponentScreenSizeToUseSubSections;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ChangeComponentScreenSizeToUseSubSections, __InBuffer);
			}
		}

		private static uint __SplineComponent = 0;

		private static uint __LandscapeGuid = 0;

		private static uint __bEnableNanite = 0;

		private static uint __PerLODOverrideMaterials = 0;

		private static uint __PreEditPerLODOverrideMaterials = 0;

		private static uint __NaniteLODIndex = 0;

		private static uint __bNaniteSkirtEnabled = 0;

		private static uint __NaniteSkirtDepth = 0;

		private static uint __LandscapeSectionOffset = 0;

		private static uint __MaxLODLevel = 0;

		private static uint __ComponentScreenSizeToUseSubSections = 0;

		private static uint __LOD0ScreenSize = 0;

		private static uint __LODGroupKey = 0;

		private static uint __LOD0DistributionSetting = 0;

		private static uint __LODDistributionSetting = 0;

		private static uint __ExportLOD = 0;

		private static uint __TargetDisplayOrderList = 0;

		private static uint __TargetDisplayOrder = 0;

		private static uint __StaticLightingLOD = 0;

		private static uint __DefaultPhysMaterial = 0;

		private static uint __StreamingDistanceMultiplier = 0;

		private static uint __LandscapeMaterial = 0;

		private static uint __LandscapeHoleMaterial = 0;

		private static uint __PreEditLandscapeMaterial = 0;

		private static uint __PreEditLandscapeHoleMaterial = 0;

		private static uint __bIsPerformingInteractiveActionOnLandscapeMaterialOverride = 0;

		private static uint __RuntimeVirtualTextures = 0;

		private static uint __bSetCreateRuntimeVirtualTextureVolumes = 0;

		private static uint __bVirtualTextureRenderWithQuad = 0;

		private static uint __bVirtualTextureRenderWithQuadHQ = 0;

		private static uint __VirtualTextureNumLods = 0;

		private static uint __VirtualTextureLodBias = 0;

		private static uint __VirtualTextureRenderPassType = 0;

		private static uint __NegativeZBoundsExtension = 0;

		private static uint __PositiveZBoundsExtension = 0;

		private static uint __LandscapeComponents = 0;

		private static uint __CollisionComponents = 0;

		private static uint __FoliageComponents = 0;

		private static uint __NaniteComponents = 0;

		private static uint __bHasLandscapeGrass = 0;

		private static uint __StaticLightingResolution = 0;

		private static uint __CastShadow = 0;

		private static uint __bCastDynamicShadow = 0;

		private static uint __bCastStaticShadow = 0;

		private static uint __ShadowCacheInvalidationBehavior = 0;

		private static uint __bCastContactShadow = 0;

		private static uint __bCastFarShadow = 0;

		private static uint __bCastHiddenShadow = 0;

		private static uint __bCastShadowAsTwoSided = 0;

		private static uint __bAffectDistanceFieldLighting = 0;

		private static uint __LightingChannels = 0;

		private static uint __bUseMaterialPositionOffsetInStaticLighting = 0;

		private static uint __bRenderCustomDepth = 0;

		private static uint __CustomDepthStencilWriteMask = 0;

		private static uint __CustomDepthStencilValue = 0;

		private static uint __LDMaxDrawDistance = 0;

		private static uint __LightmassSettings = 0;

		private static uint __CollisionMipLevel = 0;

		private static uint __SimpleCollisionMipLevel = 0;

		private static uint __BodyInstance = 0;

		private static uint __bGenerateOverlapEvents = 0;

		private static uint __bBakeMaterialPositionOffsetIntoCollision = 0;

		private static uint __ReimportHeightmapFilePath = 0;

		private static uint __ReimportDestinationLayerGuid = 0;

		private static uint __EditorLayerSettings = 0;

		private static uint __WeightmapUsageMap = 0;

		private static uint __ComponentSizeQuads = 0;

		private static uint __SubsectionSizeQuads = 0;

		private static uint __NumSubsections = 0;

		private static uint __bUsedForNavigation = 0;

		private static uint __bFillCollisionUnderLandscapeForNavmesh = 0;

		private static uint __NavigationGeometryGatheringMode = 0;

		private static uint __bUseDynamicMaterialInstance = 0;

		private static uint __MaxPaintedLayersPerComponent = 0;

		private static uint __bUseLandscapeForCullingInvisibleHLODVertices = 0;

		private static uint __bHasLayersContent = 0;

		private static uint __bUseCompressedHeightmapStorage = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetVirtualTextureRenderPassType = 0;

		private static uint __SetLandscapeMaterialVectorParameterValue = 0;

		private static uint __SetLandscapeMaterialTextureParameterValue = 0;

		private static uint __SetLandscapeMaterialScalarParameterValue = 0;

		private static uint __LandscapeImportWeightmapFromRenderTarget = 0;

		private static uint __LandscapeImportHeightmapFromRenderTarget = 0;

		private static uint __LandscapeExportWeightmapToRenderTarget = 0;

		private static uint __LandscapeExportHeightmapToRenderTarget = 0;

		private static uint __GetLandscapeActor = 0;

		private static uint __EditorSetLandscapeMaterial = 0;

		private static uint __EditorApplySpline = 0;

		private static uint __ChangeLODDistanceFactor = 0;

		private static uint __ChangeComponentScreenSizeToUseSubSections = 0;
	}
}