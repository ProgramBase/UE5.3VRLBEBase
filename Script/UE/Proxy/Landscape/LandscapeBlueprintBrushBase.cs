using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeBlueprintBrushBase")]
	public partial class ALandscapeBlueprintBrushBase : AActor, IStaticClass
	{
		public ALandscape OwningLandscape
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwningLandscape, __ReturnBuffer);

					return *(ALandscape*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwningLandscape, __InBuffer);
				}
			}
		}

		public bool UpdateOnPropertyChange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UpdateOnPropertyChange, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UpdateOnPropertyChange, __InBuffer);
				}
			}
		}

		public bool AffectHeightmap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AffectHeightmap, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AffectHeightmap, __InBuffer);
				}
			}
		}

		public bool AffectWeightmap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AffectWeightmap, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AffectWeightmap, __InBuffer);
				}
			}
		}

		public bool AffectVisibilityLayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AffectVisibilityLayer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AffectVisibilityLayer, __InBuffer);
				}
			}
		}

		public TArray<FName> AffectedWeightmapLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AffectedWeightmapLayers, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AffectedWeightmapLayers, __InBuffer);
				}
			}
		}

		public bool bIsVisible
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsVisible, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsVisible, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.LandscapeBlueprintBrushBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RequestLandscapeUpdate(bool bInUserTriggered = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInUserTriggered;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RequestLandscapeUpdate, __InBuffer);
			}
		}

		public virtual UTextureRenderTarget2D RenderLayer(FLandscapeBrushParameters InParameters)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InParameters?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __RenderLayer, __InBuffer, __ReturnBuffer);

				return *(UTextureRenderTarget2D*)__ReturnBuffer;
			}
		}

		public virtual UTextureRenderTarget2D Render(bool InIsHeightmap, UTextureRenderTarget2D InCombinedResult, FName InWeightmapLayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(bool*)(__InBuffer) = InIsHeightmap;

				*(nint*)(__InBuffer + 1) = InCombinedResult?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = InWeightmapLayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __Render, __InBuffer, __ReturnBuffer);

				return *(UTextureRenderTarget2D*)__ReturnBuffer;
			}
		}

		public virtual void Initialize(FTransform InLandscapeTransform, FIntPoint InLandscapeSize, FIntPoint InLandscapeRenderTargetSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InLandscapeTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InLandscapeSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InLandscapeRenderTargetSize?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Initialize, __InBuffer);
			}
		}

		public virtual void GetBlueprintRenderDependencies(ref TArray<UObject> OutStreamableAssets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutStreamableAssets?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall6Implementation(GarbageCollectionHandle, __GetBlueprintRenderDependencies, __InBuffer, __OutBuffer);

				OutStreamableAssets = *(TArray<UObject>*)(__OutBuffer);

			}
		}

		private static uint __OwningLandscape = 0;

		private static uint __UpdateOnPropertyChange = 0;

		private static uint __AffectHeightmap = 0;

		private static uint __AffectWeightmap = 0;

		private static uint __AffectVisibilityLayer = 0;

		private static uint __AffectedWeightmapLayers = 0;

		private static uint __bIsVisible = 0;

		private static uint __RequestLandscapeUpdate = 0;

		private static uint __RenderLayer = 0;

		private static uint __Render = 0;

		private static uint __Initialize = 0;

		private static uint __GetBlueprintRenderDependencies = 0;
	}
}