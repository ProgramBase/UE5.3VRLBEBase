using Script.CoreUObject;
using Script.SlateCore;
using Script.UMG.Widget;
using Script.Library;
using Script.Engine;

namespace Script.UMG
{
	[PathName("/Script/UMG.Image")]
	public partial class UImage : UWidget, IStaticClass
	{
		public FSlateBrush Brush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Brush, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Brush, __InBuffer);
				}
			}
		}

		public FGetSlateBrush BrushDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrushDelegate, __ReturnBuffer);

					return *(FGetSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrushDelegate, __InBuffer);
				}
			}
		}

		public FLinearColor ColorAndOpacity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorAndOpacity, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColorAndOpacity, __InBuffer);
				}
			}
		}

		public FGetLinearColor ColorAndOpacityDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorAndOpacityDelegate, __ReturnBuffer);

					return *(FGetLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColorAndOpacityDelegate, __InBuffer);
				}
			}
		}

		public bool bFlipForRightToLeftFlowDirection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFlipForRightToLeftFlowDirection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFlipForRightToLeftFlowDirection, __InBuffer);
				}
			}
		}

		public FOnPointerEvent OnMouseButtonDownEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMouseButtonDownEvent, __ReturnBuffer);

					return *(FOnPointerEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMouseButtonDownEvent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.Image");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetOpacity(float InOpacity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InOpacity;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOpacity, __InBuffer);
			}
		}

		public virtual void SetDesiredSizeOverride(FVector2D DesiredSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DesiredSize?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDesiredSizeOverride, __InBuffer);
			}
		}

		public virtual void SetColorAndOpacity(FLinearColor InColorAndOpacity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColorAndOpacity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetColorAndOpacity, __InBuffer);
			}
		}

		public virtual void SetBrushTintColor(FSlateColor TintColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TintColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBrushTintColor, __InBuffer);
			}
		}

		public virtual void SetBrushResourceObject(UObject ResourceObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ResourceObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBrushResourceObject, __InBuffer);
			}
		}

		/// <param name="Texture">
		/// Dynamic Texture to use to set on Brush.
		/// </param>
		/// <param name="bMatchSize">
		/// If true, image will change its size to texture size. If false, texture will be stretched to image size.
		/// </param>
		public virtual void SetBrushFromTextureDynamic(UTexture2DDynamic Texture, bool bMatchSize = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bMatchSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBrushFromTextureDynamic, __InBuffer);
			}
		}

		/// <param name="Texture">
		/// Texture to use to set on Brush.
		/// </param>
		/// <param name="bMatchSize">
		/// If true, image will change its size to texture size. If false, texture will be stretched to image size.
		/// </param>
		public virtual void SetBrushFromTexture(UTexture2D Texture, bool bMatchSize = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bMatchSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBrushFromTexture, __InBuffer);
			}
		}

		/// <param name="SoftTexture">
		/// Soft Texture to use to set on Brush.
		/// </param>
		/// <param name="bMatchSize">
		/// If true, image will change its size to texture size. If false, texture will be stretched to image size.
		/// </param>
		public virtual void SetBrushFromSoftTexture(TSoftObjectPtr<UTexture2D> SoftTexture, bool bMatchSize = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = SoftTexture?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bMatchSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBrushFromSoftTexture, __InBuffer);
			}
		}

		public virtual void SetBrushFromSoftMaterial(TSoftObjectPtr<UMaterialInterface> SoftMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBrushFromSoftMaterial, __InBuffer);
			}
		}

		public virtual void SetBrushFromMaterial(UMaterialInterface Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBrushFromMaterial, __InBuffer);
			}
		}

		/// <param name="AtlasRegion">
		/// Region of the Atlas to use to set on Brush.
		/// </param>
		/// <param name="bMatchSize">
		/// If true, image will change its size to atlas region size. If false, atlas region will be stretched to image size.
		/// </param>
		public virtual void SetBrushFromAtlasInterface(TScriptInterface<ISlateTextureAtlasInterface> AtlasRegion, bool bMatchSize = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AtlasRegion?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bMatchSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBrushFromAtlasInterface, __InBuffer);
			}
		}

		public virtual void SetBrushFromAsset(USlateBrushAsset Asset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBrushFromAsset, __InBuffer);
			}
		}

		public virtual void SetBrush(FSlateBrush InBrush)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBrush?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBrush, __InBuffer);
			}
		}

		public virtual UMaterialInstanceDynamic GetDynamicMaterial()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDynamicMaterial, __ReturnBuffer);

				return *(UMaterialInstanceDynamic*)__ReturnBuffer;
			}
		}

		private static uint __Brush = 0;

		private static uint __BrushDelegate = 0;

		private static uint __ColorAndOpacity = 0;

		private static uint __ColorAndOpacityDelegate = 0;

		private static uint __bFlipForRightToLeftFlowDirection = 0;

		private static uint __OnMouseButtonDownEvent = 0;

		private static uint __SetOpacity = 0;

		private static uint __SetDesiredSizeOverride = 0;

		private static uint __SetColorAndOpacity = 0;

		private static uint __SetBrushTintColor = 0;

		private static uint __SetBrushResourceObject = 0;

		private static uint __SetBrushFromTextureDynamic = 0;

		private static uint __SetBrushFromTexture = 0;

		private static uint __SetBrushFromSoftTexture = 0;

		private static uint __SetBrushFromSoftMaterial = 0;

		private static uint __SetBrushFromMaterial = 0;

		private static uint __SetBrushFromAtlasInterface = 0;

		private static uint __SetBrushFromAsset = 0;

		private static uint __SetBrush = 0;

		private static uint __GetDynamicMaterial = 0;
	}
}