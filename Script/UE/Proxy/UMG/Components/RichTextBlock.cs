using Script.CoreUObject;
using Script.Engine;
using Script.SlateCore;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.RichTextBlock")]
	public partial class URichTextBlock : UTextLayoutWidget, IStaticClass
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

		public UDataTable TextStyleSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextStyleSet, __ReturnBuffer);

					return *(UDataTable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextStyleSet, __InBuffer);
				}
			}
		}

		public TArray<TSubclassOf<URichTextBlockDecorator>> DecoratorClasses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DecoratorClasses, __ReturnBuffer);

					return *(TArray<TSubclassOf<URichTextBlockDecorator>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DecoratorClasses, __InBuffer);
				}
			}
		}

		public bool bOverrideDefaultStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideDefaultStyle, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideDefaultStyle, __InBuffer);
				}
			}
		}

		public FTextBlockStyle DefaultTextStyleOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultTextStyleOverride, __ReturnBuffer);

					return *(FTextBlockStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultTextStyleOverride, __InBuffer);
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

		public FTextBlockStyle DefaultTextStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultTextStyle, __ReturnBuffer);

					return *(FTextBlockStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultTextStyle, __InBuffer);
				}
			}
		}

		public TArray<URichTextBlockDecorator> InstanceDecorators
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceDecorators, __ReturnBuffer);

					return *(TArray<URichTextBlockDecorator>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceDecorators, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.RichTextBlock");
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

		public virtual void SetTextStyleSet(UDataTable NewTextStyleSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewTextStyleSet?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTextStyleSet, __InBuffer);
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

		/// <param name="InDefaultTextStyle">
		/// The new text style to apply to all default (i.e. undecorated) text in the block
		/// </param>
		public virtual void SetDefaultTextStyle(FTextBlockStyle InDefaultTextStyle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDefaultTextStyle?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultTextStyle, __InBuffer);
			}
		}

		/// <param name="InStrikeBrush">
		/// The new brush to use to strike through text
		/// </param>
		public virtual void SetDefaultStrikeBrush(FSlateBrush InStrikeBrush)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStrikeBrush?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultStrikeBrush, __InBuffer);
			}
		}

		/// <param name="InShadowOffset">
		/// The new offset
		/// </param>
		public virtual void SetDefaultShadowOffset(FVector2D InShadowOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InShadowOffset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultShadowOffset, __InBuffer);
			}
		}

		/// <param name="InShadowColorAndOpacity">
		/// The new drop shadow color and opacity
		/// </param>
		public virtual void SetDefaultShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InShadowColorAndOpacity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultShadowColorAndOpacity, __InBuffer);
			}
		}

		public virtual void SetDefaultMaterial(UMaterialInterface InMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultMaterial, __InBuffer);
			}
		}

		/// <param name="InFontInfo">
		/// The new font info
		/// </param>
		public virtual void SetDefaultFont(FSlateFontInfo InFontInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFontInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultFont, __InBuffer);
			}
		}

		/// <param name="InColorAndOpacity">
		/// The new text color and opacity
		/// </param>
		public virtual void SetDefaultColorAndOpacity(FSlateColor InColorAndOpacity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColorAndOpacity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultColorAndOpacity, __InBuffer);
			}
		}

		public virtual void SetDecorators(TArray<TSubclassOf<URichTextBlockDecorator>> InDecoratorClasses)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDecoratorClasses?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDecorators, __InBuffer);
			}
		}

		/// <param name="InAutoTextWrap">
		/// to turn wrap on or off
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

		public virtual void RefreshTextLayout()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RefreshTextLayout);
			}
		}

		public virtual UDataTable GetTextStyleSet()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTextStyleSet, __ReturnBuffer);

				return *(UDataTable*)__ReturnBuffer;
			}
		}

		public virtual FText GetText()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetText, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public virtual UMaterialInstanceDynamic GetDefaultDynamicMaterial()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDefaultDynamicMaterial, __ReturnBuffer);

				return *(UMaterialInstanceDynamic*)__ReturnBuffer;
			}
		}

		public virtual URichTextBlockDecorator GetDecoratorByClass(TSubclassOf<URichTextBlockDecorator> DecoratorClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DecoratorClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDecoratorByClass, __InBuffer, __ReturnBuffer);

				return *(URichTextBlockDecorator*)__ReturnBuffer;
			}
		}

		public virtual void ClearAllDefaultStyleOverrides()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearAllDefaultStyleOverrides);
			}
		}

		private static uint __Text = 0;

		private static uint __TextStyleSet = 0;

		private static uint __DecoratorClasses = 0;

		private static uint __bOverrideDefaultStyle = 0;

		private static uint __DefaultTextStyleOverride = 0;

		private static uint __MinDesiredWidth = 0;

		private static uint __TextTransformPolicy = 0;

		private static uint __TextOverflowPolicy = 0;

		private static uint __DefaultTextStyle = 0;

		private static uint __InstanceDecorators = 0;

		private static uint __SetTextTransformPolicy = 0;

		private static uint __SetTextStyleSet = 0;

		private static uint __SetTextOverflowPolicy = 0;

		private static uint __SetText = 0;

		private static uint __SetMinDesiredWidth = 0;

		private static uint __SetDefaultTextStyle = 0;

		private static uint __SetDefaultStrikeBrush = 0;

		private static uint __SetDefaultShadowOffset = 0;

		private static uint __SetDefaultShadowColorAndOpacity = 0;

		private static uint __SetDefaultMaterial = 0;

		private static uint __SetDefaultFont = 0;

		private static uint __SetDefaultColorAndOpacity = 0;

		private static uint __SetDecorators = 0;

		private static uint __SetAutoWrapText = 0;

		private static uint __RefreshTextLayout = 0;

		private static uint __GetTextStyleSet = 0;

		private static uint __GetText = 0;

		private static uint __GetDefaultDynamicMaterial = 0;

		private static uint __GetDecoratorByClass = 0;

		private static uint __ClearAllDefaultStyleOverrides = 0;
	}
}