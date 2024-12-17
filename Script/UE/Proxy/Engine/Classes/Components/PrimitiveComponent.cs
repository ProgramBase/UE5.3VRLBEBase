using Script.CoreUObject;
using Script.PhysicsCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PrimitiveComponent")]
	public partial class UPrimitiveComponent : USceneComponent, IStaticClass, INavRelevantInterface, IInterface_AsyncCompilation, IPhysicsComponent
	{
		public float MinDrawDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinDrawDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinDrawDistance, __InBuffer);
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

		public float CachedMaxDrawDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedMaxDrawDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedMaxDrawDistance, __InBuffer);
				}
			}
		}

		public ESceneDepthPriorityGroup DepthPriorityGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DepthPriorityGroup, __ReturnBuffer);

					return *(ESceneDepthPriorityGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DepthPriorityGroup, __InBuffer);
				}
			}
		}

		public ESceneDepthPriorityGroup ViewOwnerDepthPriorityGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewOwnerDepthPriorityGroup, __ReturnBuffer);

					return *(ESceneDepthPriorityGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewOwnerDepthPriorityGroup, __InBuffer);
				}
			}
		}

		public EIndirectLightingCacheQuality IndirectLightingCacheQuality
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IndirectLightingCacheQuality, __ReturnBuffer);

					return *(EIndirectLightingCacheQuality*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IndirectLightingCacheQuality, __InBuffer);
				}
			}
		}

		public ELightmapType LightmapType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightmapType, __ReturnBuffer);

					return *(ELightmapType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightmapType, __InBuffer);
				}
			}
		}

		public EHLODBatchingPolicy HLODBatchingPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HLODBatchingPolicy, __ReturnBuffer);

					return *(EHLODBatchingPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HLODBatchingPolicy, __InBuffer);
				}
			}
		}

		public bool bEnableAutoLODGeneration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableAutoLODGeneration, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableAutoLODGeneration, __InBuffer);
				}
			}
		}

		public bool bIsActorTextureStreamingBuiltData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsActorTextureStreamingBuiltData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsActorTextureStreamingBuiltData, __InBuffer);
				}
			}
		}

		public bool bIsValidTextureStreamingBuiltData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsValidTextureStreamingBuiltData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsValidTextureStreamingBuiltData, __InBuffer);
				}
			}
		}

		public bool bNeverDistanceCull
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNeverDistanceCull, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNeverDistanceCull, __InBuffer);
				}
			}
		}

		public bool bAlwaysCreatePhysicsState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysCreatePhysicsState, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysCreatePhysicsState, __InBuffer);
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

		public bool bMultiBodyOverlap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bMultiBodyOverlap, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bMultiBodyOverlap, __InBuffer);
				}
			}
		}

		public bool bTraceComplexOnMove
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bTraceComplexOnMove, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bTraceComplexOnMove, __InBuffer);
				}
			}
		}

		public bool bReturnMaterialOnMove
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReturnMaterialOnMove, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReturnMaterialOnMove, __InBuffer);
				}
			}
		}

		public bool bUseViewOwnerDepthPriorityGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseViewOwnerDepthPriorityGroup, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseViewOwnerDepthPriorityGroup, __InBuffer);
				}
			}
		}

		public bool bAllowCullDistanceVolume
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowCullDistanceVolume, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowCullDistanceVolume, __InBuffer);
				}
			}
		}

		public bool bVisibleInReflectionCaptures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bVisibleInReflectionCaptures, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bVisibleInReflectionCaptures, __InBuffer);
				}
			}
		}

		public bool bVisibleInRealTimeSkyCaptures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bVisibleInRealTimeSkyCaptures, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bVisibleInRealTimeSkyCaptures, __InBuffer);
				}
			}
		}

		public bool bVisibleInRayTracing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bVisibleInRayTracing, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bVisibleInRayTracing, __InBuffer);
				}
			}
		}

		public bool bRenderInMainPass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRenderInMainPass, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRenderInMainPass, __InBuffer);
				}
			}
		}

		public bool bRenderInDepthPass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRenderInDepthPass, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRenderInDepthPass, __InBuffer);
				}
			}
		}

		public bool bReceivesDecals
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReceivesDecals, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReceivesDecals, __InBuffer);
				}
			}
		}

		public bool bHoldout
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHoldout, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHoldout, __InBuffer);
				}
			}
		}

		public bool bOwnerNoSee
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOwnerNoSee, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOwnerNoSee, __InBuffer);
				}
			}
		}

		public bool bOnlyOwnerSee
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlyOwnerSee, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlyOwnerSee, __InBuffer);
				}
			}
		}

		public bool bTreatAsBackgroundForOcclusion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bTreatAsBackgroundForOcclusion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bTreatAsBackgroundForOcclusion, __InBuffer);
				}
			}
		}

		public bool bUseAsOccluder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseAsOccluder, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseAsOccluder, __InBuffer);
				}
			}
		}

		public bool bSelectable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSelectable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSelectable, __InBuffer);
				}
			}
		}

		public bool bConsiderForActorPlacementWhenHidden
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bConsiderForActorPlacementWhenHidden, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bConsiderForActorPlacementWhenHidden, __InBuffer);
				}
			}
		}

		public bool bForceMipStreaming
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceMipStreaming, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceMipStreaming, __InBuffer);
				}
			}
		}

		public bool bHasPerInstanceHitProxies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasPerInstanceHitProxies, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasPerInstanceHitProxies, __InBuffer);
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

		public bool bEmissiveLightSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEmissiveLightSource, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEmissiveLightSource, __InBuffer);
				}
			}
		}

		public bool bAffectDynamicIndirectLighting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAffectDynamicIndirectLighting, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAffectDynamicIndirectLighting, __InBuffer);
				}
			}
		}

		public bool bAffectIndirectLightingWhileHidden
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAffectIndirectLightingWhileHidden, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAffectIndirectLightingWhileHidden, __InBuffer);
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

		public bool bCastVolumetricTranslucentShadow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCastVolumetricTranslucentShadow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCastVolumetricTranslucentShadow, __InBuffer);
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

		public bool bSelfShadowOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSelfShadowOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSelfShadowOnly, __InBuffer);
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

		public bool bCastInsetShadow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCastInsetShadow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCastInsetShadow, __InBuffer);
				}
			}
		}

		public bool bCastCinematicShadow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCastCinematicShadow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCastCinematicShadow, __InBuffer);
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

		public bool bLightAttachmentsAsGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLightAttachmentsAsGroup, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLightAttachmentsAsGroup, __InBuffer);
				}
			}
		}

		public bool bExcludeFromLightAttachmentGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bExcludeFromLightAttachmentGroup, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bExcludeFromLightAttachmentGroup, __InBuffer);
				}
			}
		}

		public bool bReceiveMobileCSMShadows
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReceiveMobileCSMShadows, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReceiveMobileCSMShadows, __InBuffer);
				}
			}
		}

		public bool bSingleSampleShadowFromStationaryLights
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSingleSampleShadowFromStationaryLights, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSingleSampleShadowFromStationaryLights, __InBuffer);
				}
			}
		}

		public bool bIgnoreRadialImpulse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreRadialImpulse, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreRadialImpulse, __InBuffer);
				}
			}
		}

		public bool bIgnoreRadialForce
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreRadialForce, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreRadialForce, __InBuffer);
				}
			}
		}

		public bool bApplyImpulseOnDamage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bApplyImpulseOnDamage, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bApplyImpulseOnDamage, __InBuffer);
				}
			}
		}

		public bool bReplicatePhysicsToAutonomousProxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReplicatePhysicsToAutonomousProxy, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReplicatePhysicsToAutonomousProxy, __InBuffer);
				}
			}
		}

		public bool bFillCollisionUnderneathForNavmesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFillCollisionUnderneathForNavmesh, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFillCollisionUnderneathForNavmesh, __InBuffer);
				}
			}
		}

		public bool AlwaysLoadOnClient
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AlwaysLoadOnClient, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AlwaysLoadOnClient, __InBuffer);
				}
			}
		}

		public bool AlwaysLoadOnServer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AlwaysLoadOnServer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AlwaysLoadOnServer, __InBuffer);
				}
			}
		}

		public bool bUseEditorCompositing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseEditorCompositing, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseEditorCompositing, __InBuffer);
				}
			}
		}

		public bool bIsBeingMovedByEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsBeingMovedByEditor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsBeingMovedByEditor, __InBuffer);
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

		public bool bVisibleInSceneCaptureOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bVisibleInSceneCaptureOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bVisibleInSceneCaptureOnly, __InBuffer);
				}
			}
		}

		public bool bHiddenInSceneCapture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenInSceneCapture, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenInSceneCapture, __InBuffer);
				}
			}
		}

		public bool bRayTracingFarField
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRayTracingFarField, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRayTracingFarField, __InBuffer);
				}
			}
		}

		public bool bHasNoStreamableTextures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasNoStreamableTextures, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasNoStreamableTextures, __InBuffer);
				}
			}
		}

		public bool bStaticWhenNotMoveable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStaticWhenNotMoveable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStaticWhenNotMoveable, __InBuffer);
				}
			}
		}

		public EHasCustomNavigableGeometry bHasCustomNavigableGeometry
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasCustomNavigableGeometry, __ReturnBuffer);

					return *(EHasCustomNavigableGeometry*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasCustomNavigableGeometry, __InBuffer);
				}
			}
		}

		public EHitProxyPriority HitProxyPriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HitProxyPriority, __ReturnBuffer);

					return *(EHitProxyPriority*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HitProxyPriority, __InBuffer);
				}
			}
		}

		public ECanBeCharacterBase CanCharacterStepUpOn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CanCharacterStepUpOn, __ReturnBuffer);

					return *(ECanBeCharacterBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CanCharacterStepUpOn, __InBuffer);
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

		public int RayTracingGroupId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RayTracingGroupId, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RayTracingGroupId, __InBuffer);
				}
			}
		}

		public int VisibilityId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VisibilityId, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VisibilityId, __InBuffer);
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

		public FCustomPrimitiveData CustomPrimitiveData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomPrimitiveData, __ReturnBuffer);

					return *(FCustomPrimitiveData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomPrimitiveData, __InBuffer);
				}
			}
		}

		public FCustomPrimitiveData CustomPrimitiveDataInternal
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomPrimitiveDataInternal, __ReturnBuffer);

					return *(FCustomPrimitiveData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomPrimitiveDataInternal, __InBuffer);
				}
			}
		}

		public int TranslucencySortPriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TranslucencySortPriority, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TranslucencySortPriority, __InBuffer);
				}
			}
		}

		public float TranslucencySortDistanceOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TranslucencySortDistanceOffset, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TranslucencySortDistanceOffset, __InBuffer);
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

		public sbyte VirtualTextureLodBias
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureLodBias, __ReturnBuffer);

					return *(sbyte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(sbyte*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureLodBias, __InBuffer);
				}
			}
		}

		public sbyte VirtualTextureCullMips
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureCullMips, __ReturnBuffer);

					return *(sbyte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(sbyte*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureCullMips, __InBuffer);
				}
			}
		}

		public sbyte VirtualTextureMinCoverage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureMinCoverage, __ReturnBuffer);

					return *(sbyte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(sbyte*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureMinCoverage, __InBuffer);
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

		public float BoundsScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoundsScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoundsScale, __InBuffer);
				}
			}
		}

		public TArray<AActor> MoveIgnoreActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MoveIgnoreActors, __ReturnBuffer);

					return *(TArray<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MoveIgnoreActors, __InBuffer);
				}
			}
		}

		public TArray<UPrimitiveComponent> MoveIgnoreComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MoveIgnoreComponents, __ReturnBuffer);

					return *(TArray<UPrimitiveComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MoveIgnoreComponents, __InBuffer);
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

		public FComponentHitSignature OnComponentHit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentHit, __ReturnBuffer);

					return *(FComponentHitSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentHit, __InBuffer);
				}
			}
		}

		public FComponentBeginOverlapSignature OnComponentBeginOverlap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentBeginOverlap, __ReturnBuffer);

					return *(FComponentBeginOverlapSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentBeginOverlap, __InBuffer);
				}
			}
		}

		public FComponentEndOverlapSignature OnComponentEndOverlap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentEndOverlap, __ReturnBuffer);

					return *(FComponentEndOverlapSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentEndOverlap, __InBuffer);
				}
			}
		}

		public FComponentWakeSignature OnComponentWake
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentWake, __ReturnBuffer);

					return *(FComponentWakeSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentWake, __InBuffer);
				}
			}
		}

		public FComponentSleepSignature OnComponentSleep
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentSleep, __ReturnBuffer);

					return *(FComponentSleepSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentSleep, __InBuffer);
				}
			}
		}

		public FComponentPhysicsStateChanged OnComponentPhysicsStateChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentPhysicsStateChanged, __ReturnBuffer);

					return *(FComponentPhysicsStateChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentPhysicsStateChanged, __InBuffer);
				}
			}
		}

		public FComponentBeginCursorOverSignature OnBeginCursorOver
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnBeginCursorOver, __ReturnBuffer);

					return *(FComponentBeginCursorOverSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnBeginCursorOver, __InBuffer);
				}
			}
		}

		public FComponentEndCursorOverSignature OnEndCursorOver
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEndCursorOver, __ReturnBuffer);

					return *(FComponentEndCursorOverSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEndCursorOver, __InBuffer);
				}
			}
		}

		public FComponentOnClickedSignature OnClicked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnClicked, __ReturnBuffer);

					return *(FComponentOnClickedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnClicked, __InBuffer);
				}
			}
		}

		public FComponentOnReleasedSignature OnReleased
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnReleased, __ReturnBuffer);

					return *(FComponentOnReleasedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnReleased, __InBuffer);
				}
			}
		}

		public FComponentOnInputTouchBeginSignature OnInputTouchBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchBegin, __ReturnBuffer);

					return *(FComponentOnInputTouchBeginSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchBegin, __InBuffer);
				}
			}
		}

		public FComponentOnInputTouchEndSignature OnInputTouchEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchEnd, __ReturnBuffer);

					return *(FComponentOnInputTouchEndSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchEnd, __InBuffer);
				}
			}
		}

		public FComponentBeginTouchOverSignature OnInputTouchEnter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchEnter, __ReturnBuffer);

					return *(FComponentBeginTouchOverSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchEnter, __InBuffer);
				}
			}
		}

		public FComponentEndTouchOverSignature OnInputTouchLeave
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchLeave, __ReturnBuffer);

					return *(FComponentEndTouchOverSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchLeave, __InBuffer);
				}
			}
		}

		public ERayTracingGroupCullingPriority RayTracingGroupCullingPriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RayTracingGroupCullingPriority, __ReturnBuffer);

					return *(ERayTracingGroupCullingPriority*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RayTracingGroupCullingPriority, __InBuffer);
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

		public byte ExcludeFromHLODLevels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludeFromHLODLevels, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludeFromHLODLevels, __InBuffer);
				}
			}
		}

		public UPrimitiveComponent LODParentPrimitive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODParentPrimitive, __ReturnBuffer);

					return *(UPrimitiveComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODParentPrimitive, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PrimitiveComponent");
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

		/// <param name="Tolerance">
		/// How many seconds ago the actor last render time can be and still count as having been "recently" rendered.
		/// </param>
		/// <returns>
		/// Whether this actor was recently rendered.
		/// </returns>
		public virtual bool WasRecentlyRendered(float Tolerance = 0.200000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasRecentlyRendered, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to wake. 'None' indicates root body.
		/// </param>
		public virtual void WakeRigidBody(FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WakeRigidBody, __InBuffer);
			}
		}

		public virtual void WakeAllRigidBodies()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __WakeAllRigidBodies);
			}
		}

		public virtual void SetWalkableSlopeOverride(FWalkableSlopeOverride NewOverride)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewOverride?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWalkableSlopeOverride, __InBuffer);
			}
		}

		public virtual void SetVisibleInSceneCaptureOnly(bool bValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVisibleInSceneCaptureOnly, __InBuffer);
			}
		}

		public virtual void SetVisibleInRayTracing(bool bNewVisibleInRayTracing)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewVisibleInRayTracing;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVisibleInRayTracing, __InBuffer);
			}
		}

		/// <param name="ParameterName">
		/// The parameter name of the custom primitive
		/// </param>
		/// <param name="Value">
		/// The new value of the custom primitive
		/// </param>
		public virtual void SetVectorParameterForDefaultCustomPrimitiveData(FName ParameterName, FVector4 Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVectorParameterForDefaultCustomPrimitiveData, __InBuffer);
			}
		}

		/// <param name="ParameterName">
		/// The parameter name of the custom primitive
		/// </param>
		/// <param name="Value">
		/// The new value of the custom primitive
		/// </param>
		public virtual void SetVectorParameterForCustomPrimitiveData(FName ParameterName, FVector4 Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVectorParameterForCustomPrimitiveData, __InBuffer);
			}
		}

		public virtual void SetUseCCD(bool InUseCCD, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = InUseCCD;

				*(nint*)(__InBuffer + 1) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUseCCD, __InBuffer);
			}
		}

		public virtual void SetTranslucentSortPriority(int NewTranslucentSortPriority)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NewTranslucentSortPriority;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTranslucentSortPriority, __InBuffer);
			}
		}

		public virtual void SetTranslucencySortDistanceOffset(float NewTranslucencySortDistanceOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewTranslucencySortDistanceOffset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTranslucencySortDistanceOffset, __InBuffer);
			}
		}

		public virtual void SetStaticWhenNotMoveable(bool bInStaticWhenNotMoveable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInStaticWhenNotMoveable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStaticWhenNotMoveable, __InBuffer);
			}
		}

		public virtual void SetSingleSampleShadowFromStationaryLights(bool bNewSingleSampleShadowFromStationaryLights)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewSingleSampleShadowFromStationaryLights;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSingleSampleShadowFromStationaryLights, __InBuffer);
			}
		}

		/// <param name="bSimulate">
		/// New simulation state for single body
		/// </param>
		public virtual void SetSimulatePhysics(bool bSimulate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSimulate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSimulatePhysics, __InBuffer);
			}
		}

		/// <param name="ParameterName">
		/// The parameter name of the custom primitive
		/// </param>
		/// <param name="Value">
		/// The new value of the custom primitive
		/// </param>
		public virtual void SetScalarParameterForDefaultCustomPrimitiveData(FName ParameterName, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScalarParameterForDefaultCustomPrimitiveData, __InBuffer);
			}
		}

		/// <param name="ParameterName">
		/// The parameter name of the custom primitive
		/// </param>
		/// <param name="Value">
		/// The new value of the custom primitive
		/// </param>
		public virtual void SetScalarParameterForCustomPrimitiveData(FName ParameterName, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScalarParameterForCustomPrimitiveData, __InBuffer);
			}
		}

		public virtual void SetRenderInMainPass(bool bValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRenderInMainPass, __InBuffer);
			}
		}

		public virtual void SetRenderInDepthPass(bool bValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRenderInDepthPass, __InBuffer);
			}
		}

		public virtual void SetRenderCustomDepth(bool bValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRenderCustomDepth, __InBuffer);
			}
		}

		public virtual void SetReceivesDecals(bool bNewReceivesDecals)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewReceivesDecals;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReceivesDecals, __InBuffer);
			}
		}

		public virtual void SetPhysMaterialOverride(UPhysicalMaterial NewPhysMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPhysMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPhysMaterialOverride, __InBuffer);
			}
		}

		/// <param name="NewMaxAngVel">
		/// New maximum angular velocity to apply to body, in radians per second.
		/// </param>
		/// <param name="bAddToCurrent">
		/// If true, NewMaxAngVel is added to the existing maximum angular velocity of the body.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body.
		/// </param>
		public virtual void SetPhysicsMaxAngularVelocityInRadians(float NewMaxAngVel, bool bAddToCurrent = false, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[13];

				*(float*)(__InBuffer) = NewMaxAngVel;

				*(bool*)(__InBuffer + 4) = bAddToCurrent;

				*(nint*)(__InBuffer + 5) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPhysicsMaxAngularVelocityInRadians, __InBuffer);
			}
		}

		/// <param name="NewMaxAngVel">
		/// New maximum angular velocity to apply to body, in degrees per second.
		/// </param>
		/// <param name="bAddToCurrent">
		/// If true, NewMaxAngVel is added to the existing maximum angular velocity of the body.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body.
		/// </param>
		public virtual void SetPhysicsMaxAngularVelocityInDegrees(float NewMaxAngVel, bool bAddToCurrent = false, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[13];

				*(float*)(__InBuffer) = NewMaxAngVel;

				*(bool*)(__InBuffer + 4) = bAddToCurrent;

				*(nint*)(__InBuffer + 5) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPhysicsMaxAngularVelocityInDegrees, __InBuffer);
			}
		}

		/// <param name="NewVel">
		/// New linear velocity to apply to physics.
		/// </param>
		/// <param name="bAddToCurrent">
		/// If true, NewVel is added to the existing velocity of the body.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to modify velocity of. 'None' indicates root body.
		/// </param>
		public virtual void SetPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent = false, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NewVel?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAddToCurrent;

				*(nint*)(__InBuffer + 9) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPhysicsLinearVelocity, __InBuffer);
			}
		}

		/// <param name="NewAngVel">
		/// New angular velocity to apply to body, in radians per second.
		/// </param>
		/// <param name="bAddToCurrent">
		/// If true, NewAngVel is added to the existing angular velocity of the body.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body.
		/// </param>
		public virtual void SetPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent = false, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NewAngVel?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAddToCurrent;

				*(nint*)(__InBuffer + 9) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPhysicsAngularVelocityInRadians, __InBuffer);
			}
		}

		/// <param name="NewAngVel">
		/// New angular velocity to apply to body, in degrees per second.
		/// </param>
		/// <param name="bAddToCurrent">
		/// If true, NewAngVel is added to the existing angular velocity of the body.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body.
		/// </param>
		public virtual void SetPhysicsAngularVelocityInDegrees(FVector NewAngVel, bool bAddToCurrent = false, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NewAngVel?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAddToCurrent;

				*(nint*)(__InBuffer + 9) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPhysicsAngularVelocityInDegrees, __InBuffer);
			}
		}

		public virtual void SetOwnerNoSee(bool bNewOwnerNoSee)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewOwnerNoSee;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOwnerNoSee, __InBuffer);
			}
		}

		public virtual void SetOnlyOwnerSee(bool bNewOnlyOwnerSee)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewOnlyOwnerSee;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOnlyOwnerSee, __InBuffer);
			}
		}

		public virtual void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewNotifyRigidBodyCollision;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNotifyRigidBodyCollision, __InBuffer);
			}
		}

		/// <param name="MaterialSlotName">
		/// - The slot name to access the material of.
		/// </param>
		/// <returns>
		/// the material used by the indexed element of this mesh.
		/// </returns>
		public virtual void SetMaterialByName(FName MaterialSlotName, UMaterialInterface Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MaterialSlotName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Material?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaterialByName, __InBuffer);
			}
		}

		/// <param name="ElementIndex">
		/// - The element to access the material of.
		/// </param>
		/// <returns>
		/// the material used by the indexed element of this mesh.
		/// </returns>
		public virtual void SetMaterial(int ElementIndex, UMaterialInterface Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = ElementIndex;

				*(nint*)(__InBuffer + 4) = Material?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaterial, __InBuffer);
			}
		}

		public virtual void SetMassScale(FName BoneName = null, float InMassScale = 1.000000f)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InMassScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMassScale, __InBuffer);
			}
		}

		public virtual void SetMassOverrideInKg(FName BoneName = null, float MassInKg = 1.000000f, bool bOverrideMass = true)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = MassInKg;

				*(bool*)(__InBuffer + 12) = bOverrideMass;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMassOverrideInKg, __InBuffer);
			}
		}

		public virtual void SetLinearDamping(float InDamping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDamping;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearDamping, __InBuffer);
			}
		}

		public virtual void SetLightingChannels(bool bChannel0, bool bChannel1, bool bChannel2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[3];

				*(bool*)(__InBuffer) = bChannel0;

				*(bool*)(__InBuffer + 1) = bChannel1;

				*(bool*)(__InBuffer + 2) = bChannel2;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLightingChannels, __InBuffer);
			}
		}

		public virtual void SetLightAttachmentsAsGroup(bool bInLightAttachmentsAsGroup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInLightAttachmentsAsGroup;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLightAttachmentsAsGroup, __InBuffer);
			}
		}

		public virtual void SetIgnoreBoundsForEditorFocus(bool bIgnore)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIgnore;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIgnoreBoundsForEditorFocus, __InBuffer);
			}
		}

		public virtual void SetHoldout(bool bNewHoldout)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewHoldout;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetHoldout, __InBuffer);
			}
		}

		public virtual void SetHiddenInSceneCapture(bool bValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetHiddenInSceneCapture, __InBuffer);
			}
		}

		public virtual void SetGenerateOverlapEvents(bool bInGenerateOverlapEvents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInGenerateOverlapEvents;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGenerateOverlapEvents, __InBuffer);
			}
		}

		public virtual void SetExcludeFromLightAttachmentGroup(bool bInExcludeFromLightAttachmentGroup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInExcludeFromLightAttachmentGroup;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetExcludeFromLightAttachmentGroup, __InBuffer);
			}
		}

		public virtual void SetExcludeForSpecificHLODLevels(TArray<int> InExcludeForSpecificHLODLevels)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InExcludeForSpecificHLODLevels?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetExcludeForSpecificHLODLevels, __InBuffer);
			}
		}

		public virtual void SetExcludedFromHLODLevel(EHLODLevelExclusion HLODLevel, bool bExcluded)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)HLODLevel;

				*(bool*)(__InBuffer + 1) = bExcluded;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetExcludedFromHLODLevel, __InBuffer);
			}
		}

		public virtual void SetEnableGravity(bool bGravityEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bGravityEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableGravity, __InBuffer);
			}
		}

		public virtual void SetEmissiveLightSource(bool NewEmissiveLightSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = NewEmissiveLightSource;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEmissiveLightSource, __InBuffer);
			}
		}

		public virtual void SetDefaultCustomPrimitiveDataVector4(int DataIndex, FVector4 Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = DataIndex;

				*(nint*)(__InBuffer + 4) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultCustomPrimitiveDataVector4, __InBuffer);
			}
		}

		public virtual void SetDefaultCustomPrimitiveDataVector3(int DataIndex, FVector Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = DataIndex;

				*(nint*)(__InBuffer + 4) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultCustomPrimitiveDataVector3, __InBuffer);
			}
		}

		public virtual void SetDefaultCustomPrimitiveDataVector2(int DataIndex, FVector2D Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = DataIndex;

				*(nint*)(__InBuffer + 4) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultCustomPrimitiveDataVector2, __InBuffer);
			}
		}

		public virtual void SetDefaultCustomPrimitiveDataFloat(int DataIndex, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = DataIndex;

				*(float*)(__InBuffer + 4) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultCustomPrimitiveDataFloat, __InBuffer);
			}
		}

		public virtual void SetCustomPrimitiveDataVector4(int DataIndex, FVector4 Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = DataIndex;

				*(nint*)(__InBuffer + 4) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCustomPrimitiveDataVector4, __InBuffer);
			}
		}

		public virtual void SetCustomPrimitiveDataVector3(int DataIndex, FVector Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = DataIndex;

				*(nint*)(__InBuffer + 4) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCustomPrimitiveDataVector3, __InBuffer);
			}
		}

		public virtual void SetCustomPrimitiveDataVector2(int DataIndex, FVector2D Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = DataIndex;

				*(nint*)(__InBuffer + 4) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCustomPrimitiveDataVector2, __InBuffer);
			}
		}

		public virtual void SetCustomPrimitiveDataFloat(int DataIndex, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = DataIndex;

				*(float*)(__InBuffer + 4) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCustomPrimitiveDataFloat, __InBuffer);
			}
		}

		public virtual void SetCustomDepthStencilWriteMask(ERendererStencilMask WriteMaskBit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)WriteMaskBit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCustomDepthStencilWriteMask, __InBuffer);
			}
		}

		public virtual void SetCustomDepthStencilValue(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCustomDepthStencilValue, __InBuffer);
			}
		}

		/// <param name="NewCullDistance">
		/// - The value to assign to CullDistance.
		/// </param>
		public virtual void SetCullDistance(float NewCullDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewCullDistance;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCullDistance, __InBuffer);
			}
		}

		/// <param name="ConstraintMode">
		/// The type of constraint to use.
		/// </param>
		public virtual void SetConstraintMode(EDOFMode ConstraintMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)ConstraintMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConstraintMode, __InBuffer);
			}
		}

		/// <param name="Channel">
		/// The channel to change the response of
		/// </param>
		/// <param name="NewResponse">
		/// What the new response should be to the supplied Channel
		/// </param>
		public virtual void SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)Channel;

				*(byte*)(__InBuffer + 1) = (byte)NewResponse;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCollisionResponseToChannel, __InBuffer);
			}
		}

		/// <param name="NewResponse">
		/// What the new response should be to the supplied Channel
		/// </param>
		public virtual void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewResponse;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCollisionResponseToAllChannels, __InBuffer);
			}
		}

		/// <param name="InCollisionProfileName">
		/// : New Profile Name
		/// </param>
		public virtual void SetCollisionProfileName(FName InCollisionProfileName, bool bUpdateOverlaps = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InCollisionProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateOverlaps;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCollisionProfileName, __InBuffer);
			}
		}

		/// <param name="Channel">
		/// The new channel for this component to use
		/// </param>
		public virtual void SetCollisionObjectType(ECollisionChannel Channel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Channel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCollisionObjectType, __InBuffer);
			}
		}

		public virtual void SetCollisionEnabled(ECollisionEnabled NewType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCollisionEnabled, __InBuffer);
			}
		}

		/// <param name="CenterOfMassOffset">
		/// User specified offset for the center of mass of this object, from the calculated location.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body.
		/// </param>
		public virtual void SetCenterOfMass(FVector CenterOfMassOffset, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = CenterOfMassOffset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCenterOfMass, __InBuffer);
			}
		}

		public virtual void SetCastShadow(bool NewCastShadow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = NewCastShadow;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCastShadow, __InBuffer);
			}
		}

		public virtual void SetCastInsetShadow(bool bInCastInsetShadow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInCastInsetShadow;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCastInsetShadow, __InBuffer);
			}
		}

		public virtual void SetCastHiddenShadow(bool NewCastHiddenShadow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = NewCastHiddenShadow;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCastHiddenShadow, __InBuffer);
			}
		}

		public virtual void SetCastContactShadow(bool bInCastContactShadow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInCastContactShadow;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCastContactShadow, __InBuffer);
			}
		}

		public virtual void SetBoundsScale(float NewBoundsScale = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewBoundsScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoundsScale, __InBuffer);
			}
		}

		public virtual void SetAngularDamping(float InDamping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDamping;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularDamping, __InBuffer);
			}
		}

		public virtual void SetAllUseCCD(bool InUseCCD)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InUseCCD;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllUseCCD, __InBuffer);
			}
		}

		/// <param name="NewVel">
		/// New linear velocity to apply to physics.
		/// </param>
		/// <param name="bAddToCurrent">
		/// If true, NewVel is added to the existing velocity of the body.
		/// </param>
		public virtual void SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NewVel?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAddToCurrent;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllPhysicsLinearVelocity, __InBuffer);
			}
		}

		/// <param name="NewAngVel">
		/// New angular velocity to apply to physics, in radians per second.
		/// </param>
		/// <param name="bAddToCurrent">
		/// If true, NewAngVel is added to the existing angular velocity of all bodies.
		/// </param>
		public virtual void SetAllPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NewAngVel?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAddToCurrent;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllPhysicsAngularVelocityInRadians, __InBuffer);
			}
		}

		/// <param name="NewAngVel">
		/// New angular velocity to apply to physics, in degrees per second.
		/// </param>
		/// <param name="bAddToCurrent">
		/// If true, NewAngVel is added to the existing angular velocity of all bodies.
		/// </param>
		public virtual void SetAllPhysicsAngularVelocityInDegrees(FVector NewAngVel, bool bAddToCurrent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NewAngVel?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAddToCurrent;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllPhysicsAngularVelocityInDegrees, __InBuffer);
			}
		}

		public virtual void SetAllMassScale(float InMassScale = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InMassScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllMassScale, __InBuffer);
			}
		}

		public virtual void SetAffectIndirectLightingWhileHidden(bool bNewAffectIndirectLightingWhileHidden)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewAffectIndirectLightingWhileHidden;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAffectIndirectLightingWhileHidden, __InBuffer);
			}
		}

		public virtual void SetAffectDynamicIndirectLighting(bool bNewAffectDynamicIndirectLighting)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewAffectDynamicIndirectLighting;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAffectDynamicIndirectLighting, __InBuffer);
			}
		}

		public virtual void SetAffectDistanceFieldLighting(bool NewAffectDistanceFieldLighting)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = NewAffectDistanceFieldLighting;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAffectDistanceFieldLighting, __InBuffer);
			}
		}

		public virtual FVector ScaleByMomentOfInertia(FVector InputVector, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InputVector?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ScaleByMomentOfInertia, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to put to sleep. 'None' indicates root body.
		/// </param>
		public virtual void PutRigidBodyToSleep(FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PutRigidBodyToSleep, __InBuffer);
			}
		}

		/// <param name="TraceStart">
		/// The start of the trace in world-space
		/// </param>
		/// <param name="TraceEnd">
		/// The end of the trace in world-space
		/// </param>
		/// <param name="SphereRadius">
		/// Radius of the sphere to trace against the component
		/// </param>
		/// <param name="bTraceComplex">
		/// Whether or not to trace the complex physics representation or just the simple representation
		/// </param>
		/// <param name="bShowTrace">
		/// Whether or not to draw the trace in the world (for debugging)
		/// </param>
		/// <param name="bPersistentShowTrace">
		/// Whether or not to make the debugging draw stay in the world permanently
		/// </param>
		public virtual bool K2_SphereTraceComponent(FVector TraceStart, FVector TraceEnd, float SphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, ref FHitResult OutHit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[55];

				*(nint*)(__InBuffer) = TraceStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TraceEnd?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = SphereRadius;

				*(bool*)(__InBuffer + 20) = bTraceComplex;

				*(bool*)(__InBuffer + 21) = bShowTrace;

				*(bool*)(__InBuffer + 22) = bPersistentShowTrace;

				*(nint*)(__InBuffer + 23) = HitLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 31) = HitNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 39) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 47) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[32];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __K2_SphereTraceComponent, __InBuffer, __OutBuffer, __ReturnBuffer);

				HitLocation = *(FVector*)(__OutBuffer);

				HitNormal = *(FVector*)(__OutBuffer + 8);

				BoneName = *(FName*)(__OutBuffer + 16);

				OutHit = *(FHitResult*)(__OutBuffer + 24);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InSphereCentre">
		/// The centre of the sphere to overlap with the component
		/// </param>
		/// <param name="InSphereRadius">
		/// The Radius of the sphere to overlap with the component
		/// </param>
		/// <param name="bTraceComplex">
		/// Whether or not to trace the complex physics representation or just the simple representation
		/// </param>
		/// <param name="bShowTrace">
		/// Whether or not to draw the trace in the world (for debugging)
		/// </param>
		/// <param name="bPersistentShowTrace">
		/// Whether or not to make the debugging draw stay in the world permanently
		/// </param>
		public virtual bool K2_SphereOverlapComponent(FVector InSphereCentre, float InSphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, ref FHitResult OutHit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[47];

				*(nint*)(__InBuffer) = InSphereCentre?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InSphereRadius;

				*(bool*)(__InBuffer + 12) = bTraceComplex;

				*(bool*)(__InBuffer + 13) = bShowTrace;

				*(bool*)(__InBuffer + 14) = bPersistentShowTrace;

				*(nint*)(__InBuffer + 15) = HitLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 23) = HitNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 31) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 39) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[32];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __K2_SphereOverlapComponent, __InBuffer, __OutBuffer, __ReturnBuffer);

				HitLocation = *(FVector*)(__OutBuffer);

				HitNormal = *(FVector*)(__OutBuffer + 8);

				BoneName = *(FName*)(__OutBuffer + 16);

				OutHit = *(FHitResult*)(__OutBuffer + 24);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TraceStart">
		/// The start of the trace in world-space
		/// </param>
		/// <param name="TraceEnd">
		/// The end of the trace in world-space
		/// </param>
		/// <param name="bTraceComplex">
		/// Whether or not to trace the complex physics representation or just the simple representation
		/// </param>
		/// <param name="bShowTrace">
		/// Whether or not to draw the trace in the world (for debugging)
		/// </param>
		/// <param name="bPersistentShowTrace">
		/// Whether or not to make the debugging draw stay in the world permanently
		/// </param>
		public virtual bool K2_LineTraceComponent(FVector TraceStart, FVector TraceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, ref FHitResult OutHit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[51];

				*(nint*)(__InBuffer) = TraceStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TraceEnd?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bTraceComplex;

				*(bool*)(__InBuffer + 17) = bShowTrace;

				*(bool*)(__InBuffer + 18) = bPersistentShowTrace;

				*(nint*)(__InBuffer + 19) = HitLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 27) = HitNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 35) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 43) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[32];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __K2_LineTraceComponent, __InBuffer, __OutBuffer, __ReturnBuffer);

				HitLocation = *(FVector*)(__OutBuffer);

				HitNormal = *(FVector*)(__OutBuffer + 8);

				BoneName = *(FName*)(__OutBuffer + 16);

				OutHit = *(FHitResult*)(__OutBuffer + 24);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool K2_IsQueryCollisionEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __K2_IsQueryCollisionEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool K2_IsPhysicsCollisionEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __K2_IsPhysicsCollisionEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool K2_IsCollisionEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __K2_IsCollisionEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InBoxCentre">
		/// The centre of the box to overlap with the component
		/// </param>
		/// <param name="InBox">
		/// Description of the box to use in the overlap
		/// </param>
		/// <param name="bTraceComplex">
		/// Whether or not to trace the complex physics representation or just the simple representation
		/// </param>
		/// <param name="bShowTrace">
		/// Whether or not to draw the trace in the world (for debugging)
		/// </param>
		/// <param name="bPersistentShowTrace">
		/// Whether or not to make the debugging draw stay in the world permanently
		/// </param>
		public virtual bool K2_BoxOverlapComponent(FVector InBoxCentre, FBox InBox, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, ref FHitResult OutHit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[51];

				*(nint*)(__InBuffer) = InBoxCentre?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBox?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bTraceComplex;

				*(bool*)(__InBuffer + 17) = bShowTrace;

				*(bool*)(__InBuffer + 18) = bPersistentShowTrace;

				*(nint*)(__InBuffer + 19) = HitLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 27) = HitNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 35) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 43) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[32];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __K2_BoxOverlapComponent, __InBuffer, __OutBuffer, __ReturnBuffer);

				HitLocation = *(FVector*)(__OutBuffer);

				HitNormal = *(FVector*)(__OutBuffer + 8);

				BoneName = *(FName*)(__OutBuffer + 16);

				OutHit = *(FHitResult*)(__OutBuffer + 24);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="OtherComp">
		/// Component to test this component against.
		/// </param>
		/// <returns>
		/// Whether this component is overlapping another component.
		/// </returns>
		public virtual bool IsOverlappingComponent(UPrimitiveComponent OtherComp)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OtherComp?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsOverlappingComponent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Other">
		/// Actor to test this component against.
		/// </param>
		/// <returns>
		/// Whether this component is overlapping any component of the given Actor.
		/// </returns>
		public virtual bool IsOverlappingActor(AActor Other)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Other?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsOverlappingActor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsGravityEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsGravityEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsExcludedFromHLODLevel(EHLODLevelExclusion HLODLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)HLODLevel;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsExcludedFromHLODLevel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsAnyRigidBodyAwake()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsAnyRigidBodyAwake, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void InvalidateLumenSurfaceCache()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __InvalidateLumenSurfaceCache);
			}
		}

		public virtual void IgnoreComponentWhenMoving(UPrimitiveComponent Component, bool bShouldIgnore)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldIgnore;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __IgnoreComponentWhenMoving, __InBuffer);
			}
		}

		public virtual void IgnoreActorWhenMoving(AActor Actor, bool bShouldIgnore)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldIgnore;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __IgnoreActorWhenMoving, __InBuffer);
			}
		}

		public virtual FWalkableSlopeOverride GetWalkableSlopeOverride()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetWalkableSlopeOverride, __ReturnBuffer);

				return *(FWalkableSlopeOverride*)__ReturnBuffer;
			}
		}

		public virtual bool GetStaticWhenNotMoveable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetStaticWhenNotMoveable, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Point">
		/// Point is specified in world space.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
		/// </param>
		public virtual FVector GetPhysicsLinearVelocityAtPoint(FVector Point, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPhysicsLinearVelocityAtPoint, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
		/// </param>
		public virtual FVector GetPhysicsLinearVelocity(FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPhysicsLinearVelocity, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
		/// </param>
		public virtual FVector GetPhysicsAngularVelocityInRadians(FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPhysicsAngularVelocityInRadians, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
		/// </param>
		public virtual FVector GetPhysicsAngularVelocityInDegrees(FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPhysicsAngularVelocityInDegrees, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual void GetOverlappingComponents(ref TArray<UPrimitiveComponent> OutOverlappingComponents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutOverlappingComponents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetOverlappingComponents, __InBuffer, __OutBuffer);

				OutOverlappingComponents = *(TArray<UPrimitiveComponent>*)(__OutBuffer);

			}
		}

		/// <param name="OverlappingActors">
		/// [out] Returned list of overlapping actors
		/// </param>
		/// <param name="ClassFilter">
		/// [optional] If set, only returns actors of this class or subclasses
		/// </param>
		public virtual void GetOverlappingActors(ref TArray<AActor> OverlappingActors, TSubclassOf<AActor> ClassFilter = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OverlappingActors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClassFilter?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetOverlappingActors, __InBuffer, __OutBuffer);

				OverlappingActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		public virtual int GetNumMaterials()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumMaterials, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="FaceIndex">
		/// Face index from hit result that was hit by a trace
		/// </param>
		/// <param name="SectionIndex">
		/// Section of the mesh that the face belongs to
		/// </param>
		/// <returns>
		/// Material applied to section that the hit face belongs to
		/// </returns>
		public virtual UMaterialInterface GetMaterialFromCollisionFaceIndex(int FaceIndex, ref int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = FaceIndex;

				*(int*)(__InBuffer + 4) = SectionIndex;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __GetMaterialFromCollisionFaceIndex, __InBuffer, __OutBuffer, __ReturnBuffer);

				SectionIndex = *(int*)(__OutBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		/// <param name="ElementIndex">
		/// - The element to access the material of.
		/// </param>
		/// <returns>
		/// the material used by the indexed element of this mesh.
		/// </returns>
		public virtual UMaterialInterface GetMaterial(int ElementIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ElementIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetMaterial, __InBuffer, __ReturnBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		public virtual float GetMassScale(FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetMassScale, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetMass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMass, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetLinearDamping()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetLinearDamping, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector GetInertiaTensor(FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetInertiaTensor, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual bool GetIgnoreBoundsForEditorFocus()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetIgnoreBoundsForEditorFocus, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// [Overlap Events](https://docs.unrealengine.com/InteractiveExperiences/Physics/Collision/Overview#overlapandgenerateoverlapevents)
		/// </see>
		/// <see>
		/// UpdateOverlaps(), BeginComponentOverlap(), EndComponentOverlap()
		/// </see>
		public virtual bool GetGenerateOverlapEvents()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetGenerateOverlapEvents, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<int> GetExcludeForSpecificHLODLevels()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetExcludeForSpecificHLODLevels, __ReturnBuffer);

				return *(TArray<int>*)__ReturnBuffer;
			}
		}

		/// <param name="ParameterName">
		/// The parameter name of the custom primitive
		/// </param>
		/// <returns>
		/// The index of the custom primitive, INDEX_NONE (-1) if not found
		/// </returns>
		public virtual int GetCustomPrimitiveDataIndexForVectorParameter(FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetCustomPrimitiveDataIndexForVectorParameter, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="ParameterName">
		/// The parameter name of the custom primitive
		/// </param>
		/// <returns>
		/// The index of the custom primitive, INDEX_NONE (-1) if not found
		/// </returns>
		public virtual int GetCustomPrimitiveDataIndexForScalarParameter(FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetCustomPrimitiveDataIndexForScalarParameter, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual ECollisionResponse GetCollisionResponseToChannel(ECollisionChannel Channel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Channel;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetCollisionResponseToChannel, __InBuffer, __ReturnBuffer);

				return *(ECollisionResponse*)__ReturnBuffer;
			}
		}

		public virtual FName GetCollisionProfileName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCollisionProfileName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual ECollisionChannel GetCollisionObjectType()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCollisionObjectType, __ReturnBuffer);

				return *(ECollisionChannel*)__ReturnBuffer;
			}
		}

		public virtual ECollisionEnabled GetCollisionEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCollisionEnabled, __ReturnBuffer);

				return *(ECollisionEnabled*)__ReturnBuffer;
			}
		}

		/// <param name="Point">
		/// World 3D vector
		/// </param>
		/// <param name="OutPointOnBody">
		/// Point on the surface of collision closest to Point
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body.
		/// </param>
		/// <returns>
		/// Success if returns > 0.f, if returns 0.f, it is either not convex or inside of the point
		/// If returns < 0.f, this primitive does not have collsion
		/// </returns>
		public virtual float GetClosestPointOnCollision(FVector Point, ref FVector OutPointOnBody, FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPointOnBody?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetClosestPointOnCollision, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPointOnBody = *(FVector*)(__OutBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to get center of mass of. 'None' indicates root body.
		/// </param>
		public virtual FVector GetCenterOfMass(FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetCenterOfMass, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Used to get body associated with specific bone. NAME_None automatically gets the root most body
		/// </param>
		/// <param name="bGetWelded">
		/// If the component has been welded to another component and bGetWelded is true we return the single welded BodyInstance that is used in the simulation
		/// </param>
		/// <param name="Index">
		/// Index used in Components with multiple body instances
		/// </param>
		/// <returns>
		/// Returns the BodyInstanceAsyncPhysicsTickHandle based on various states (does component have multiple bodies? Is the body welded to another body?)
		/// </returns>
		public virtual FBodyInstanceAsyncPhysicsTickHandle GetBodyInstanceAsyncPhysicsTickHandle(FName BoneName = null, bool bGetWelded = true, int Index = -1)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bGetWelded;

				*(int*)(__InBuffer + 9) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBodyInstanceAsyncPhysicsTickHandle, __InBuffer, __ReturnBuffer);

				return *(FBodyInstanceAsyncPhysicsTickHandle*)__ReturnBuffer;
			}
		}

		public virtual float GetAngularDamping()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAngularDamping, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="ElementIndex">
		/// - The index of the skin to replace the material for.  If invalid, the material is unchanged and NULL is returned.
		/// </param>
		public virtual UMaterialInstanceDynamic CreateDynamicMaterialInstance(int ElementIndex, UMaterialInterface SourceMaterial = null, FName OptionalName = null)
		{
			unsafe
			{
				OptionalName ??= new FName("None");

				var __InBuffer = stackalloc byte[20];

				*(int*)(__InBuffer) = ElementIndex;

				*(nint*)(__InBuffer + 4) = SourceMaterial?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = OptionalName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateDynamicMaterialInstance, __InBuffer, __ReturnBuffer);

				return *(UMaterialInstanceDynamic*)__ReturnBuffer;
			}
		}

		/// <param name="ElementIndex">
		/// - The index of the skin to replace the material for.  If invalid, the material is unchanged and NULL is returned.
		/// </param>
		public virtual UMaterialInstanceDynamic CreateAndSetMaterialInstanceDynamicFromMaterial(int ElementIndex, UMaterialInterface Parent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = ElementIndex;

				*(nint*)(__InBuffer + 4) = Parent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateAndSetMaterialInstanceDynamicFromMaterial, __InBuffer, __ReturnBuffer);

				return *(UMaterialInstanceDynamic*)__ReturnBuffer;
			}
		}

		/// <param name="ElementIndex">
		/// - The index of the skin to replace the material for.  If invalid, the material is unchanged and NULL is returned.
		/// </param>
		public virtual UMaterialInstanceDynamic CreateAndSetMaterialInstanceDynamic(int ElementIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ElementIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateAndSetMaterialInstanceDynamic, __InBuffer, __ReturnBuffer);

				return *(UMaterialInstanceDynamic*)__ReturnBuffer;
			}
		}

		public virtual TArray<UPrimitiveComponent> CopyArrayOfMoveIgnoreComponents()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __CopyArrayOfMoveIgnoreComponents, __ReturnBuffer);

				return *(TArray<UPrimitiveComponent>*)__ReturnBuffer;
			}
		}

		public virtual TArray<AActor> CopyArrayOfMoveIgnoreActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __CopyArrayOfMoveIgnoreActors, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		public virtual void ClearMoveIgnoreComponents()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearMoveIgnoreComponents);
			}
		}

		public virtual void ClearMoveIgnoreActors()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearMoveIgnoreActors);
			}
		}

		/// <param name="Pawn">
		/// the Pawn that wants to step onto this component.
		/// </param>
		/// <see>
		/// CanCharacterStepUpOn
		/// </see>
		public virtual bool CanCharacterStepUp(APawn Pawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Pawn?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanCharacterStepUp, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Impulse">
		/// Magnitude and direction of impulse to apply.
		/// </param>
		/// <param name="Location">
		/// Point in world space to apply impulse at.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of bone to apply impulse to. 'None' indicates root body.
		/// </param>
		public virtual void AddVelocityChangeImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Impulse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddVelocityChangeImpulseAtLocation, __InBuffer);
			}
		}

		/// <param name="Torque">
		/// Torque to apply. Direction is axis of rotation and magnitude is strength of torque.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body.
		/// </param>
		/// <param name="bAccelChange">
		/// If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no effect).
		/// </param>
		public virtual void AddTorqueInRadians(FVector Torque, FName BoneName = null, bool bAccelChange = false)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Torque?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAccelChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddTorqueInRadians, __InBuffer);
			}
		}

		/// <param name="Torque">
		/// Torque to apply. Direction is axis of rotation and magnitude is strength of torque.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body.
		/// </param>
		/// <param name="bAccelChange">
		/// If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no effect).
		/// </param>
		public virtual void AddTorqueInDegrees(FVector Torque, FName BoneName = null, bool bAccelChange = false)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Torque?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAccelChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddTorqueInDegrees, __InBuffer);
			}
		}

		/// <param name="Origin">
		/// Point of origin for the radial impulse blast, in world space
		/// </param>
		/// <param name="Radius">
		/// Size of radial impulse. Beyond this distance from Origin, there will be no affect.
		/// </param>
		/// <param name="Strength">
		/// Maximum strength of impulse applied to body.
		/// </param>
		/// <param name="Falloff">
		/// Allows you to control the strength of the impulse as a function of distance from Origin.
		/// </param>
		/// <param name="bVelChange">
		/// If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect).
		/// </param>
		public virtual void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Radius;

				*(float*)(__InBuffer + 12) = Strength;

				*(byte*)(__InBuffer + 16) = (byte)Falloff;

				*(bool*)(__InBuffer + 17) = bVelChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddRadialImpulse, __InBuffer);
			}
		}

		/// <param name="Origin">
		/// Origin of force in world space.
		/// </param>
		/// <param name="Radius">
		/// Radius within which to apply the force.
		/// </param>
		/// <param name="Strength">
		/// Strength of force to apply.
		/// </param>
		/// <param name="Falloff">
		/// Allows you to control the strength of the force as a function of distance from Origin.
		/// </param>
		/// <param name="bAccelChange">
		/// If true, Strength is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect).
		/// </param>
		public virtual void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Radius;

				*(float*)(__InBuffer + 12) = Strength;

				*(byte*)(__InBuffer + 16) = (byte)Falloff;

				*(bool*)(__InBuffer + 17) = bAccelChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddRadialForce, __InBuffer);
			}
		}

		/// <param name="Impulse">
		/// Magnitude and direction of impulse to apply.
		/// </param>
		/// <param name="Location">
		/// Point in world space to apply impulse at.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of bone to apply impulse to. 'None' indicates root body.
		/// </param>
		public virtual void AddImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Impulse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddImpulseAtLocation, __InBuffer);
			}
		}

		/// <param name="Impulse">
		/// Magnitude and direction of impulse to apply.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body.
		/// </param>
		/// <param name="bVelChange">
		/// If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect).
		/// </param>
		public virtual void AddImpulse(FVector Impulse, FName BoneName = null, bool bVelChange = false)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Impulse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bVelChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddImpulse, __InBuffer);
			}
		}

		/// <param name="Force">
		/// Force vector to apply. Magnitude indicates strength of force.
		/// </param>
		/// <param name="Location">
		/// Location to apply force, in component space.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
		/// </param>
		public virtual void AddForceAtLocationLocal(FVector Force, FVector Location, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Force?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddForceAtLocationLocal, __InBuffer);
			}
		}

		/// <param name="Force">
		/// Force vector to apply. Magnitude indicates strength of force.
		/// </param>
		/// <param name="Location">
		/// Location to apply force, in world space.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
		/// </param>
		public virtual void AddForceAtLocation(FVector Force, FVector Location, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Force?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddForceAtLocation, __InBuffer);
			}
		}

		/// <param name="Force">
		/// Force vector to apply. Magnitude indicates strength of force.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
		/// </param>
		/// <param name="bAccelChange">
		/// If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect).
		/// </param>
		public virtual void AddForce(FVector Force, FName BoneName = null, bool bAccelChange = false)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Force?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAccelChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddForce, __InBuffer);
			}
		}

		/// <param name="AngularImpulse">
		/// Magnitude and direction of impulse to apply. Direction is axis of rotation.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body.
		/// </param>
		/// <param name="bVelChange">
		/// If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect).
		/// </param>
		public virtual void AddAngularImpulseInRadians(FVector Impulse, FName BoneName = null, bool bVelChange = false)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Impulse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bVelChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddAngularImpulseInRadians, __InBuffer);
			}
		}

		/// <param name="AngularImpulse">
		/// Magnitude and direction of impulse to apply. Direction is axis of rotation.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body.
		/// </param>
		/// <param name="bVelChange">
		/// If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect).
		/// </param>
		public virtual void AddAngularImpulseInDegrees(FVector Impulse, FName BoneName = null, bool bVelChange = false)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Impulse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bVelChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddAngularImpulseInDegrees, __InBuffer);
			}
		}

		private static uint __MinDrawDistance = 0;

		private static uint __LDMaxDrawDistance = 0;

		private static uint __CachedMaxDrawDistance = 0;

		private static uint __DepthPriorityGroup = 0;

		private static uint __ViewOwnerDepthPriorityGroup = 0;

		private static uint __IndirectLightingCacheQuality = 0;

		private static uint __LightmapType = 0;

		private static uint __HLODBatchingPolicy = 0;

		private static uint __bEnableAutoLODGeneration = 0;

		private static uint __bIsActorTextureStreamingBuiltData = 0;

		private static uint __bIsValidTextureStreamingBuiltData = 0;

		private static uint __bNeverDistanceCull = 0;

		private static uint __bAlwaysCreatePhysicsState = 0;

		private static uint __bGenerateOverlapEvents = 0;

		private static uint __bMultiBodyOverlap = 0;

		private static uint __bTraceComplexOnMove = 0;

		private static uint __bReturnMaterialOnMove = 0;

		private static uint __bUseViewOwnerDepthPriorityGroup = 0;

		private static uint __bAllowCullDistanceVolume = 0;

		private static uint __bVisibleInReflectionCaptures = 0;

		private static uint __bVisibleInRealTimeSkyCaptures = 0;

		private static uint __bVisibleInRayTracing = 0;

		private static uint __bRenderInMainPass = 0;

		private static uint __bRenderInDepthPass = 0;

		private static uint __bReceivesDecals = 0;

		private static uint __bHoldout = 0;

		private static uint __bOwnerNoSee = 0;

		private static uint __bOnlyOwnerSee = 0;

		private static uint __bTreatAsBackgroundForOcclusion = 0;

		private static uint __bUseAsOccluder = 0;

		private static uint __bSelectable = 0;

		private static uint __bConsiderForActorPlacementWhenHidden = 0;

		private static uint __bForceMipStreaming = 0;

		private static uint __bHasPerInstanceHitProxies = 0;

		private static uint __CastShadow = 0;

		private static uint __bEmissiveLightSource = 0;

		private static uint __bAffectDynamicIndirectLighting = 0;

		private static uint __bAffectIndirectLightingWhileHidden = 0;

		private static uint __bAffectDistanceFieldLighting = 0;

		private static uint __bCastDynamicShadow = 0;

		private static uint __bCastStaticShadow = 0;

		private static uint __ShadowCacheInvalidationBehavior = 0;

		private static uint __bCastVolumetricTranslucentShadow = 0;

		private static uint __bCastContactShadow = 0;

		private static uint __bSelfShadowOnly = 0;

		private static uint __bCastFarShadow = 0;

		private static uint __bCastInsetShadow = 0;

		private static uint __bCastCinematicShadow = 0;

		private static uint __bCastHiddenShadow = 0;

		private static uint __bCastShadowAsTwoSided = 0;

		private static uint __bLightAttachmentsAsGroup = 0;

		private static uint __bExcludeFromLightAttachmentGroup = 0;

		private static uint __bReceiveMobileCSMShadows = 0;

		private static uint __bSingleSampleShadowFromStationaryLights = 0;

		private static uint __bIgnoreRadialImpulse = 0;

		private static uint __bIgnoreRadialForce = 0;

		private static uint __bApplyImpulseOnDamage = 0;

		private static uint __bReplicatePhysicsToAutonomousProxy = 0;

		private static uint __bFillCollisionUnderneathForNavmesh = 0;

		private static uint __AlwaysLoadOnClient = 0;

		private static uint __AlwaysLoadOnServer = 0;

		private static uint __bUseEditorCompositing = 0;

		private static uint __bIsBeingMovedByEditor = 0;

		private static uint __bRenderCustomDepth = 0;

		private static uint __bVisibleInSceneCaptureOnly = 0;

		private static uint __bHiddenInSceneCapture = 0;

		private static uint __bRayTracingFarField = 0;

		private static uint __bHasNoStreamableTextures = 0;

		private static uint __bStaticWhenNotMoveable = 0;

		private static uint __bHasCustomNavigableGeometry = 0;

		private static uint __HitProxyPriority = 0;

		private static uint __CanCharacterStepUpOn = 0;

		private static uint __LightingChannels = 0;

		private static uint __RayTracingGroupId = 0;

		private static uint __VisibilityId = 0;

		private static uint __CustomDepthStencilValue = 0;

		private static uint __CustomPrimitiveData = 0;

		private static uint __CustomPrimitiveDataInternal = 0;

		private static uint __TranslucencySortPriority = 0;

		private static uint __TranslucencySortDistanceOffset = 0;

		private static uint __RuntimeVirtualTextures = 0;

		private static uint __VirtualTextureLodBias = 0;

		private static uint __VirtualTextureCullMips = 0;

		private static uint __VirtualTextureMinCoverage = 0;

		private static uint __VirtualTextureRenderPassType = 0;

		private static uint __BoundsScale = 0;

		private static uint __MoveIgnoreActors = 0;

		private static uint __MoveIgnoreComponents = 0;

		private static uint __BodyInstance = 0;

		private static uint __OnComponentHit = 0;

		private static uint __OnComponentBeginOverlap = 0;

		private static uint __OnComponentEndOverlap = 0;

		private static uint __OnComponentWake = 0;

		private static uint __OnComponentSleep = 0;

		private static uint __OnComponentPhysicsStateChanged = 0;

		private static uint __OnBeginCursorOver = 0;

		private static uint __OnEndCursorOver = 0;

		private static uint __OnClicked = 0;

		private static uint __OnReleased = 0;

		private static uint __OnInputTouchBegin = 0;

		private static uint __OnInputTouchEnd = 0;

		private static uint __OnInputTouchEnter = 0;

		private static uint __OnInputTouchLeave = 0;

		private static uint __RayTracingGroupCullingPriority = 0;

		private static uint __CustomDepthStencilWriteMask = 0;

		private static uint __ExcludeFromHLODLevels = 0;

		private static uint __LODParentPrimitive = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __WasRecentlyRendered = 0;

		private static uint __WakeRigidBody = 0;

		private static uint __WakeAllRigidBodies = 0;

		private static uint __SetWalkableSlopeOverride = 0;

		private static uint __SetVisibleInSceneCaptureOnly = 0;

		private static uint __SetVisibleInRayTracing = 0;

		private static uint __SetVectorParameterForDefaultCustomPrimitiveData = 0;

		private static uint __SetVectorParameterForCustomPrimitiveData = 0;

		private static uint __SetUseCCD = 0;

		private static uint __SetTranslucentSortPriority = 0;

		private static uint __SetTranslucencySortDistanceOffset = 0;

		private static uint __SetStaticWhenNotMoveable = 0;

		private static uint __SetSingleSampleShadowFromStationaryLights = 0;

		private static uint __SetSimulatePhysics = 0;

		private static uint __SetScalarParameterForDefaultCustomPrimitiveData = 0;

		private static uint __SetScalarParameterForCustomPrimitiveData = 0;

		private static uint __SetRenderInMainPass = 0;

		private static uint __SetRenderInDepthPass = 0;

		private static uint __SetRenderCustomDepth = 0;

		private static uint __SetReceivesDecals = 0;

		private static uint __SetPhysMaterialOverride = 0;

		private static uint __SetPhysicsMaxAngularVelocityInRadians = 0;

		private static uint __SetPhysicsMaxAngularVelocityInDegrees = 0;

		private static uint __SetPhysicsLinearVelocity = 0;

		private static uint __SetPhysicsAngularVelocityInRadians = 0;

		private static uint __SetPhysicsAngularVelocityInDegrees = 0;

		private static uint __SetOwnerNoSee = 0;

		private static uint __SetOnlyOwnerSee = 0;

		private static uint __SetNotifyRigidBodyCollision = 0;

		private static uint __SetMaterialByName = 0;

		private static uint __SetMaterial = 0;

		private static uint __SetMassScale = 0;

		private static uint __SetMassOverrideInKg = 0;

		private static uint __SetLinearDamping = 0;

		private static uint __SetLightingChannels = 0;

		private static uint __SetLightAttachmentsAsGroup = 0;

		private static uint __SetIgnoreBoundsForEditorFocus = 0;

		private static uint __SetHoldout = 0;

		private static uint __SetHiddenInSceneCapture = 0;

		private static uint __SetGenerateOverlapEvents = 0;

		private static uint __SetExcludeFromLightAttachmentGroup = 0;

		private static uint __SetExcludeForSpecificHLODLevels = 0;

		private static uint __SetExcludedFromHLODLevel = 0;

		private static uint __SetEnableGravity = 0;

		private static uint __SetEmissiveLightSource = 0;

		private static uint __SetDefaultCustomPrimitiveDataVector4 = 0;

		private static uint __SetDefaultCustomPrimitiveDataVector3 = 0;

		private static uint __SetDefaultCustomPrimitiveDataVector2 = 0;

		private static uint __SetDefaultCustomPrimitiveDataFloat = 0;

		private static uint __SetCustomPrimitiveDataVector4 = 0;

		private static uint __SetCustomPrimitiveDataVector3 = 0;

		private static uint __SetCustomPrimitiveDataVector2 = 0;

		private static uint __SetCustomPrimitiveDataFloat = 0;

		private static uint __SetCustomDepthStencilWriteMask = 0;

		private static uint __SetCustomDepthStencilValue = 0;

		private static uint __SetCullDistance = 0;

		private static uint __SetConstraintMode = 0;

		private static uint __SetCollisionResponseToChannel = 0;

		private static uint __SetCollisionResponseToAllChannels = 0;

		private static uint __SetCollisionProfileName = 0;

		private static uint __SetCollisionObjectType = 0;

		private static uint __SetCollisionEnabled = 0;

		private static uint __SetCenterOfMass = 0;

		private static uint __SetCastShadow = 0;

		private static uint __SetCastInsetShadow = 0;

		private static uint __SetCastHiddenShadow = 0;

		private static uint __SetCastContactShadow = 0;

		private static uint __SetBoundsScale = 0;

		private static uint __SetAngularDamping = 0;

		private static uint __SetAllUseCCD = 0;

		private static uint __SetAllPhysicsLinearVelocity = 0;

		private static uint __SetAllPhysicsAngularVelocityInRadians = 0;

		private static uint __SetAllPhysicsAngularVelocityInDegrees = 0;

		private static uint __SetAllMassScale = 0;

		private static uint __SetAffectIndirectLightingWhileHidden = 0;

		private static uint __SetAffectDynamicIndirectLighting = 0;

		private static uint __SetAffectDistanceFieldLighting = 0;

		private static uint __ScaleByMomentOfInertia = 0;

		private static uint __PutRigidBodyToSleep = 0;

		private static uint __K2_SphereTraceComponent = 0;

		private static uint __K2_SphereOverlapComponent = 0;

		private static uint __K2_LineTraceComponent = 0;

		private static uint __K2_IsQueryCollisionEnabled = 0;

		private static uint __K2_IsPhysicsCollisionEnabled = 0;

		private static uint __K2_IsCollisionEnabled = 0;

		private static uint __K2_BoxOverlapComponent = 0;

		private static uint __IsOverlappingComponent = 0;

		private static uint __IsOverlappingActor = 0;

		private static uint __IsGravityEnabled = 0;

		private static uint __IsExcludedFromHLODLevel = 0;

		private static uint __IsAnyRigidBodyAwake = 0;

		private static uint __InvalidateLumenSurfaceCache = 0;

		private static uint __IgnoreComponentWhenMoving = 0;

		private static uint __IgnoreActorWhenMoving = 0;

		private static uint __GetWalkableSlopeOverride = 0;

		private static uint __GetStaticWhenNotMoveable = 0;

		private static uint __GetPhysicsLinearVelocityAtPoint = 0;

		private static uint __GetPhysicsLinearVelocity = 0;

		private static uint __GetPhysicsAngularVelocityInRadians = 0;

		private static uint __GetPhysicsAngularVelocityInDegrees = 0;

		private static uint __GetOverlappingComponents = 0;

		private static uint __GetOverlappingActors = 0;

		private static uint __GetNumMaterials = 0;

		private static uint __GetMaterialFromCollisionFaceIndex = 0;

		private static uint __GetMaterial = 0;

		private static uint __GetMassScale = 0;

		private static uint __GetMass = 0;

		private static uint __GetLinearDamping = 0;

		private static uint __GetInertiaTensor = 0;

		private static uint __GetIgnoreBoundsForEditorFocus = 0;

		private static uint __GetGenerateOverlapEvents = 0;

		private static uint __GetExcludeForSpecificHLODLevels = 0;

		private static uint __GetCustomPrimitiveDataIndexForVectorParameter = 0;

		private static uint __GetCustomPrimitiveDataIndexForScalarParameter = 0;

		private static uint __GetCollisionResponseToChannel = 0;

		private static uint __GetCollisionProfileName = 0;

		private static uint __GetCollisionObjectType = 0;

		private static uint __GetCollisionEnabled = 0;

		private static uint __GetClosestPointOnCollision = 0;

		private static uint __GetCenterOfMass = 0;

		private static uint __GetBodyInstanceAsyncPhysicsTickHandle = 0;

		private static uint __GetAngularDamping = 0;

		private static uint __CreateDynamicMaterialInstance = 0;

		private static uint __CreateAndSetMaterialInstanceDynamicFromMaterial = 0;

		private static uint __CreateAndSetMaterialInstanceDynamic = 0;

		private static uint __CopyArrayOfMoveIgnoreComponents = 0;

		private static uint __CopyArrayOfMoveIgnoreActors = 0;

		private static uint __ClearMoveIgnoreComponents = 0;

		private static uint __ClearMoveIgnoreActors = 0;

		private static uint __CanCharacterStepUp = 0;

		private static uint __AddVelocityChangeImpulseAtLocation = 0;

		private static uint __AddTorqueInRadians = 0;

		private static uint __AddTorqueInDegrees = 0;

		private static uint __AddRadialImpulse = 0;

		private static uint __AddRadialForce = 0;

		private static uint __AddImpulseAtLocation = 0;

		private static uint __AddImpulse = 0;

		private static uint __AddForceAtLocationLocal = 0;

		private static uint __AddForceAtLocation = 0;

		private static uint __AddForce = 0;

		private static uint __AddAngularImpulseInRadians = 0;

		private static uint __AddAngularImpulseInDegrees = 0;
	}
}