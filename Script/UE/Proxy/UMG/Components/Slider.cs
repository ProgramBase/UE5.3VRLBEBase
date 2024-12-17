using Script.CoreUObject;
using Script.UMG.Widget;
using Script.SlateCore;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.Slider")]
	public partial class USlider : UWidget, IStaticClass
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

		public float MinValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinValue, __InBuffer);
				}
			}
		}

		public float MaxValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxValue, __InBuffer);
				}
			}
		}

		public FSliderStyle WidgetStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetStyle, __ReturnBuffer);

					return *(FSliderStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetStyle, __InBuffer);
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

		public FLinearColor SliderHandleColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SliderHandleColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SliderHandleColor, __InBuffer);
				}
			}
		}

		public bool IndentHandle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IndentHandle, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IndentHandle, __InBuffer);
				}
			}
		}

		public bool Locked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Locked, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Locked, __InBuffer);
				}
			}
		}

		public bool MouseUsesStep
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MouseUsesStep, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MouseUsesStep, __InBuffer);
				}
			}
		}

		public bool RequiresControllerLock
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RequiresControllerLock, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RequiresControllerLock, __InBuffer);
				}
			}
		}

		public float StepSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StepSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StepSize, __InBuffer);
				}
			}
		}

		public bool IsFocusable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IsFocusable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IsFocusable, __InBuffer);
				}
			}
		}

		public FOnMouseCaptureBeginEvent OnMouseCaptureBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMouseCaptureBegin, __ReturnBuffer);

					return *(FOnMouseCaptureBeginEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMouseCaptureBegin, __InBuffer);
				}
			}
		}

		public FOnMouseCaptureEndEvent OnMouseCaptureEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMouseCaptureEnd, __ReturnBuffer);

					return *(FOnMouseCaptureEndEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMouseCaptureEnd, __InBuffer);
				}
			}
		}

		public FOnControllerCaptureBeginEvent OnControllerCaptureBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnControllerCaptureBegin, __ReturnBuffer);

					return *(FOnControllerCaptureBeginEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnControllerCaptureBegin, __InBuffer);
				}
			}
		}

		public FOnControllerCaptureEndEvent OnControllerCaptureEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnControllerCaptureEnd, __ReturnBuffer);

					return *(FOnControllerCaptureEndEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnControllerCaptureEnd, __InBuffer);
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.Slider");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetValue(float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValue, __InBuffer);
			}
		}

		public virtual void SetStepSize(float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStepSize, __InBuffer);
			}
		}

		public virtual void SetSliderHandleColor(FLinearColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSliderHandleColor, __InBuffer);
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

		public virtual void SetMinValue(float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMinValue, __InBuffer);
			}
		}

		public virtual void SetMaxValue(float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaxValue, __InBuffer);
			}
		}

		public virtual void SetLocked(bool InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLocked, __InBuffer);
			}
		}

		public virtual void SetIndentHandle(bool InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIndentHandle, __InBuffer);
			}
		}

		public virtual float GetValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetValue, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetNormalizedValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNormalizedValue, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __Value = 0;

		private static uint __ValueDelegate = 0;

		private static uint __MinValue = 0;

		private static uint __MaxValue = 0;

		private static uint __WidgetStyle = 0;

		private static uint __Orientation = 0;

		private static uint __SliderBarColor = 0;

		private static uint __SliderHandleColor = 0;

		private static uint __IndentHandle = 0;

		private static uint __Locked = 0;

		private static uint __MouseUsesStep = 0;

		private static uint __RequiresControllerLock = 0;

		private static uint __StepSize = 0;

		private static uint __IsFocusable = 0;

		private static uint __OnMouseCaptureBegin = 0;

		private static uint __OnMouseCaptureEnd = 0;

		private static uint __OnControllerCaptureBegin = 0;

		private static uint __OnControllerCaptureEnd = 0;

		private static uint __OnValueChanged = 0;

		private static uint __SetValue = 0;

		private static uint __SetStepSize = 0;

		private static uint __SetSliderHandleColor = 0;

		private static uint __SetSliderBarColor = 0;

		private static uint __SetMinValue = 0;

		private static uint __SetMaxValue = 0;

		private static uint __SetLocked = 0;

		private static uint __SetIndentHandle = 0;

		private static uint __GetValue = 0;

		private static uint __GetNormalizedValue = 0;
	}
}