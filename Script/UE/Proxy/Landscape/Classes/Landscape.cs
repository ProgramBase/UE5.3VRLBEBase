using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.Landscape")]
	public partial class ALandscape : ALandscapeProxy, IStaticClass
	{
		public bool bAreNewLandscapeActorsSpatiallyLoaded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAreNewLandscapeActorsSpatiallyLoaded, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAreNewLandscapeActorsSpatiallyLoaded, __InBuffer);
				}
			}
		}

		public bool bIncludeGridSizeInNameForLandscapeActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIncludeGridSizeInNameForLandscapeActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIncludeGridSizeInNameForLandscapeActors, __InBuffer);
				}
			}
		}

		public bool bCanHaveLayersContent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanHaveLayersContent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanHaveLayersContent, __InBuffer);
				}
			}
		}

		public bool bUseGeneratedLandscapeSplineMeshesActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseGeneratedLandscapeSplineMeshesActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseGeneratedLandscapeSplineMeshesActors, __InBuffer);
				}
			}
		}

		public FGuid LandscapeSplinesTargetLayerGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeSplinesTargetLayerGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeSplinesTargetLayerGuid, __InBuffer);
				}
			}
		}

		public bool bEnableEditorLayersTick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableEditorLayersTick, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableEditorLayersTick, __InBuffer);
				}
			}
		}

		public TArray<FLandscapeLayer> LandscapeLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeLayers, __ReturnBuffer);

					return *(TArray<FLandscapeLayer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeLayers, __InBuffer);
				}
			}
		}

		public TArray<UTextureRenderTarget2D> HeightmapRTList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HeightmapRTList, __ReturnBuffer);

					return *(TArray<UTextureRenderTarget2D>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HeightmapRTList, __InBuffer);
				}
			}
		}

		public TArray<UTextureRenderTarget2D> WeightmapRTList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WeightmapRTList, __ReturnBuffer);

					return *(TArray<UTextureRenderTarget2D>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WeightmapRTList, __InBuffer);
				}
			}
		}

		public TArray<TWeakObjectPtr<UTexture2D>> TrackedStreamingInTextures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TrackedStreamingInTextures, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<UTexture2D>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TrackedStreamingInTextures, __InBuffer);
				}
			}
		}

		public TSet<ULandscapeComponent> LandscapeSplinesAffectedComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeSplinesAffectedComponents, __ReturnBuffer);

					return *(TSet<ULandscapeComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeSplinesAffectedComponents, __InBuffer);
				}
			}
		}

		public bool bLandscapeLayersAreInitialized
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLandscapeLayersAreInitialized, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLandscapeLayersAreInitialized, __InBuffer);
				}
			}
		}

		public bool bLandscapeLayersAreUsingLocalMerge
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLandscapeLayersAreUsingLocalMerge, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLandscapeLayersAreUsingLocalMerge, __InBuffer);
				}
			}
		}

		public bool WasCompilingShaders
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WasCompilingShaders, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WasCompilingShaders, __InBuffer);
				}
			}
		}

		public uint LayerContentUpdateModes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LayerContentUpdateModes, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LayerContentUpdateModes, __InBuffer);
				}
			}
		}

		public bool bSplineLayerUpdateRequested
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSplineLayerUpdateRequested, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSplineLayerUpdateRequested, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.Landscape");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RenderHeightmap(FTransform InWorldTransform, FBox2D InExtents, UTextureRenderTarget2D OutRenderTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InWorldTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InExtents?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RenderHeightmap, __InBuffer);
			}
		}

		private static uint __bAreNewLandscapeActorsSpatiallyLoaded = 0;

		private static uint __bIncludeGridSizeInNameForLandscapeActors = 0;

		private static uint __bCanHaveLayersContent = 0;

		private static uint __bUseGeneratedLandscapeSplineMeshesActors = 0;

		private static uint __LandscapeSplinesTargetLayerGuid = 0;

		private static uint __bEnableEditorLayersTick = 0;

		private static uint __LandscapeLayers = 0;

		private static uint __HeightmapRTList = 0;

		private static uint __WeightmapRTList = 0;

		private static uint __TrackedStreamingInTextures = 0;

		private static uint __LandscapeSplinesAffectedComponents = 0;

		private static uint __bLandscapeLayersAreInitialized = 0;

		private static uint __bLandscapeLayersAreUsingLocalMerge = 0;

		private static uint __WasCompilingShaders = 0;

		private static uint __LayerContentUpdateModes = 0;

		private static uint __bSplineLayerUpdateRequested = 0;

		private static uint __RenderHeightmap = 0;
	}
}