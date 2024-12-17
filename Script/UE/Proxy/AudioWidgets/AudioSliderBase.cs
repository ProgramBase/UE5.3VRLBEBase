using Script.CoreUObject;
using Script.UMG;
using Script.UMG.Widget;
using Script.SlateCore;
using Script.Library;

namespace Script.AudioWidgets
{
	[PathName("/Script/AudioWidgets.AudioSliderBase")]
	public partial class UAudioSliderBase : UWidget, IStaticClass
	{
		public float Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		public FText UnitsText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UnitsText, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UnitsText, __InBuffer);
				}
			}
		}

		public FLinearColor TextLabelBackgroundColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextLabelBackgroundColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextLabelBackgroundColor, __InBuffer);
				}
			}
		}

		public FGetLinearColor TextLabelBackgroundColorDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextLabelBackgroundColorDelegate, __ReturnBuffer);

					return *(FGetLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextLabelBackgroundColorDelegate, __InBuffer);
				}
			}
		}

		public bool ShowLabelOnlyOnHover
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShowLabelOnlyOnHover, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShowLabelOnlyOnHover, __InBuffer);
				}
			}
		}

		public bool ShowUnitsText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShowUnitsText, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShowUnitsText, __InBuffer);
				}
			}
		}

		public bool IsUnitsTextReadOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IsUnitsTextReadOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IsUnitsTextReadOnly, __InBuffer);
				}
			}
		}

		public bool IsValueTextReadOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IsValueTextReadOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IsValueTextReadOnly, __InBuffer);
				}
			}
		}

		public FGetFloat ValueDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ValueDelegate, __ReturnBuffer);

					return *(FGetFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ValueDelegate, __InBuffer);
				}
			}
		}

		public FLinearColor SliderBackgroundColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SliderBackgroundColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SliderBackgroundColor, __InBuffer);
				}
			}
		}

		public FGetLinearColor SliderBackgroundColorDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SliderBackgroundColorDelegate, __ReturnBuffer);

					return *(FGetLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SliderBackgroundColorDelegate, __InBuffer);
				}
			}
		}

		public FLinearColor SliderBarColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SliderBarColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SliderBarColor, __InBuffer);
				}
			}
		}

		public FGetLinearColor SliderBarColorDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SliderBarColorDelegate, __ReturnBuffer);

					return *(FGetLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SliderBarColorDelegate, __InBuffer);
				}
			}
		}

		public FLinearColor SliderThumbColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SliderThumbColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SliderThumbColor, __InBuffer);
				}
			}
		}

		public FGetLinearColor SliderThumbColorDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SliderThumbColorDelegate, __ReturnBuffer);

					return *(FGetLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SliderThumbColorDelegate, __InBuffer);
				}
			}
		}

		public FLinearColor WidgetBackgroundColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetBackgroundColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetBackgroundColor, __InBuffer);
				}
			}
		}

		public FGetLinearColor WidgetBackgroundColorDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetBackgroundColorDelegate, __ReturnBuffer);

					return *(FGetLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetBackgroundColorDelegate, __InBuffer);
				}
			}
		}

		public EOrientation Orientation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Orientation, __ReturnBuffer);

					return *(EOrientation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Orientation, __InBuffer);
				}
			}
		}

		public FOnFloatValueChangedEvent OnValueChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnValueChanged, __ReturnBuffer);

					return *(FOnFloatValueChangedEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnValueChanged, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioWidgets.AudioSliderBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetWidgetBackgroundColor(FLinearColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWidgetBackgroundColor, __InBuffer);
			}
		}

		public virtual void SetValueTextReadOnly(bool bIsReadOnly)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsReadOnly;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValueTextReadOnly, __InBuffer);
			}
		}

		public virtual void SetUnitsTextReadOnly(bool bIsReadOnly)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsReadOnly;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUnitsTextReadOnly, __InBuffer);
			}
		}

		public virtual void SetUnitsText(FText Units)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Units?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUnitsText, __InBuffer);
			}
		}

		public virtual void SetTextLabelBackgroundColor(FSlateColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTextLabelBackgroundColor, __InBuffer);
			}
		}

		public virtual void SetSliderThumbColor(FLinearColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSliderThumbColor, __InBuffer);
			}
		}

		public virtual void SetSliderBarColor(FLinearColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSliderBarColor, __InBuffer);
			}
		}

		public virtual void SetSliderBackgroundColor(FLinearColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSliderBackgroundColor, __InBuffer);
			}
		}

		public virtual void SetShowUnitsText(bool bShowUnitsText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bShowUnitsText;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShowUnitsText, __InBuffer);
			}
		}

		public virtual void SetShowLabelOnlyOnHover(bool bShowLabelOnlyOnHover)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bShowLabelOnlyOnHover;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShowLabelOnlyOnHover, __InBuffer);
			}
		}

		public virtual float GetSliderValue(float OutputValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = OutputValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetSliderValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetOutputValue(float InSliderValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InSliderValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetOutputValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetLinValue(float OutputValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = OutputValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetLinValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __Value = 0;

		private static uint __UnitsText = 0;

		private static uint __TextLabelBackgroundColor = 0;

		private static uint __TextLabelBackgroundColorDelegate = 0;

		private static uint __ShowLabelOnlyOnHover = 0;

		private static uint __ShowUnitsText = 0;

		private static uint __IsUnitsTextReadOnly = 0;

		private static uint __IsValueTextReadOnly = 0;

		private static uint __ValueDelegate = 0;

		private static uint __SliderBackgroundColor = 0;

		private static uint __SliderBackgroundColorDelegate = 0;

		private static uint __SliderBarColor = 0;

		private static uint __SliderBarColorDelegate = 0;

		private static uint __SliderThumbColor = 0;

		private static uint __SliderThumbColorDelegate = 0;

		private static uint __WidgetBackgroundColor = 0;

		private static uint __WidgetBackgroundColorDelegate = 0;

		private static uint __Orientation = 0;

		private static uint __OnValueChanged = 0;

		private static uint __SetWidgetBackgroundColor = 0;

		private static uint __SetValueTextReadOnly = 0;

		private static uint __SetUnitsTextReadOnly = 0;

		private static uint __SetUnitsText = 0;

		private static uint __SetTextLabelBackgroundColor = 0;

		private static uint __SetSliderThumbColor = 0;

		private static uint __SetSliderBarColor = 0;

		private static uint __SetSliderBackgroundColor = 0;

		private static uint __SetShowUnitsText = 0;

		private static uint __SetShowLabelOnlyOnHover = 0;

		private static uint __GetSliderValue = 0;

		private static uint __GetOutputValue = 0;

		private static uint __GetLinValue = 0;
	}
}