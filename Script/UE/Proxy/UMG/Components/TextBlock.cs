using Script.CoreUObject;
using Script.UMG.Widget;
using Script.SlateCore;
using Script.Library;
using Script.Engine;

namespace Script.UMG
{
	[PathName("/Script/UMG.TextBlock")]
	public partial class UTextBlock : UTextLayoutWidget, IStaticClass
	{
		public FText Text
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Text, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Text, __InBuffer);
				}
			}
		}

		public FGetText TextDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextDelegate, __ReturnBuffer);

					return *(FGetText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextDelegate, __InBuffer);
				}
			}
		}

		public FSlateColor ColorAndOpacity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorAndOpacity, __ReturnBuffer);

					return *(FSlateColor*)__ReturnBuffer;
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

		public FGetSlateColor ColorAndOpacityDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorAndOpacityDelegate, __ReturnBuffer);

					return *(FGetSlateColor*)__ReturnBuffer;
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

		public FSlateFontInfo Font
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Font, __ReturnBuffer);

					return *(FSlateFontInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Font, __InBuffer);
				}
			}
		}

		public FSlateBrush StrikeBrush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StrikeBrush, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StrikeBrush, __InBuffer);
				}
			}
		}

		public FVector2D ShadowOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowOffset, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowOffset, __InBuffer);
				}
			}
		}

		public FLinearColor ShadowColorAndOpacity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowColorAndOpacity, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowColorAndOpacity, __InBuffer);
				}
			}
		}

		public FGetLinearColor ShadowColorAndOpacityDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowColorAndOpacityDelegate, __ReturnBuffer);

					return *(FGetLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowColorAndOpacityDelegate, __InBuffer);
				}
			}
		}

		public float MinDesiredWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinDesiredWidth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinDesiredWidth, __InBuffer);
				}
			}
		}

		public bool bWrapWithInvalidationPanel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWrapWithInvalidationPanel, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWrapWithInvalidationPanel, __InBuffer);
				}
			}
		}

		public ETextTransformPolicy TextTransformPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextTransformPolicy, __ReturnBuffer);

					return *(ETextTransformPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextTransformPolicy, __InBuffer);
				}
			}
		}

		public ETextOverflowPolicy TextOverflowPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextOverflowPolicy, __ReturnBuffer);

					return *(ETextOverflowPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextOverflowPolicy, __InBuffer);
				}
			}
		}

		public bool bSimpleTextMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSimpleTextMode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSimpleTextMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.TextBlock");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InTransformPolicy">
		/// the new text transformation policy.
		/// </param>
		public virtual void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InTransformPolicy;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTextTransformPolicy, __InBuffer);
			}
		}

		/// <param name="InOverflowPolicy">
		/// the new text overflow policy.
		/// </param>
		public virtual void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InOverflowPolicy;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTextOverflowPolicy, __InBuffer);
			}
		}

		/// <param name="InText">
		/// The text to assign to the widget
		/// </param>
		public virtual void SetText(FText InText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InText?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetText, __InBuffer);
			}
		}

		/// <param name="InStrikeBrush">
		/// The new brush to use to strike through text
		/// </param>
		public virtual void SetStrikeBrush(FSlateBrush InStrikeBrush)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStrikeBrush?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStrikeBrush, __InBuffer);
			}
		}

		/// <param name="InShadowOffset">
		/// The new offset
		/// </param>
		public virtual void SetShadowOffset(FVector2D InShadowOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InShadowOffset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShadowOffset, __InBuffer);
			}
		}

		/// <param name="InShadowColorAndOpacity">
		/// The new drop shadow color and opacity
		/// </param>
		public virtual void SetShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InShadowColorAndOpacity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShadowColorAndOpacity, __InBuffer);
			}
		}

		/// <param name="InOpacity">
		/// The new text opacity
		/// </param>
		public virtual void SetOpacity(float InOpacity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InOpacity;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOpacity, __InBuffer);
			}
		}

		/// <param name="InMinDesiredWidth">
		/// new minimum desired width
		/// </param>
		public virtual void SetMinDesiredWidth(float InMinDesiredWidth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InMinDesiredWidth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMinDesiredWidth, __InBuffer);
			}
		}

		public virtual void SetFontOutlineMaterial(UMaterialInterface InMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFontOutlineMaterial, __InBuffer);
			}
		}

		public virtual void SetFontMaterial(UMaterialInterface InMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFontMaterial, __InBuffer);
			}
		}

		/// <param name="InFontInfo">
		/// The new font info
		/// </param>
		public virtual void SetFont(FSlateFontInfo InFontInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFontInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFont, __InBuffer);
			}
		}

		/// <param name="InColorAndOpacity">
		/// The new text color and opacity
		/// </param>
		public virtual void SetColorAndOpacity(FSlateColor InColorAndOpacity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColorAndOpacity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetColorAndOpacity, __InBuffer);
			}
		}

		/// <param name="InAutoTextWrap">
		/// to turn wrap on or off.
		/// </param>
		public virtual void SetAutoWrapText(bool InAutoTextWrap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InAutoTextWrap;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAutoWrapText, __InBuffer);
			}
		}

		/// <returns>
		/// The widget text
		/// </returns>
		public virtual FText GetText()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetText, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public virtual UMaterialInstanceDynamic GetDynamicOutlineMaterial()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDynamicOutlineMaterial, __ReturnBuffer);

				return *(UMaterialInstanceDynamic*)__ReturnBuffer;
			}
		}

		public virtual UMaterialInstanceDynamic GetDynamicFontMaterial()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDynamicFontMaterial, __ReturnBuffer);

				return *(UMaterialInstanceDynamic*)__ReturnBuffer;
			}
		}

		private static uint __Text = 0;

		private static uint __TextDelegate = 0;

		private static uint __ColorAndOpacity = 0;

		private static uint __ColorAndOpacityDelegate = 0;

		private static uint __Font = 0;

		private static uint __StrikeBrush = 0;

		private static uint __ShadowOffset = 0;

		private static uint __ShadowColorAndOpacity = 0;

		private static uint __ShadowColorAndOpacityDelegate = 0;

		private static uint __MinDesiredWidth = 0;

		private static uint __bWrapWithInvalidationPanel = 0;

		private static uint __TextTransformPolicy = 0;

		private static uint __TextOverflowPolicy = 0;

		private static uint __bSimpleTextMode = 0;

		private static uint __SetTextTransformPolicy = 0;

		private static uint __SetTextOverflowPolicy = 0;

		private static uint __SetText = 0;

		private static uint __SetStrikeBrush = 0;

		private static uint __SetShadowOffset = 0;

		private static uint __SetShadowColorAndOpacity = 0;

		private static uint __SetOpacity = 0;

		private static uint __SetMinDesiredWidth = 0;

		private static uint __SetFontOutlineMaterial = 0;

		private static uint __SetFontMaterial = 0;

		private static uint __SetFont = 0;

		private static uint __SetColorAndOpacity = 0;

		private static uint __SetAutoWrapText = 0;

		private static uint __GetText = 0;

		private static uint __GetDynamicOutlineMaterial = 0;

		private static uint __GetDynamicFontMaterial = 0;
	}
}