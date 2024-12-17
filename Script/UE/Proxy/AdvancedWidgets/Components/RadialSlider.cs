using Script.CoreUObject;
using Script.UMG;
using Script.UMG.Widget;
using Script.Engine;
using Script.SlateCore;
using Script.Library;

namespace Script.AdvancedWidgets
{
	[PathName("/Script/AdvancedWidgets.RadialSlider")]
	public partial class URadialSlider : UWidget, IStaticClass
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

		public bool bUseCustomDefaultValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseCustomDefaultValue, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseCustomDefaultValue, __InBuffer);
				}
			}
		}

		public float CustomDefaultValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomDefaultValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomDefaultValue, __InBuffer);
				}
			}
		}

		public FRuntimeFloatCurve SliderRange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SliderRange, __ReturnBuffer);

					return *(FRuntimeFloatCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SliderRange, __InBuffer);
				}
			}
		}

		public TArray<float> ValueTags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ValueTags, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ValueTags, __InBuffer);
				}
			}
		}

		public float SliderHandleStartAngle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SliderHandleStartAngle, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SliderHandleStartAngle, __InBuffer);
				}
			}
		}

		public float SliderHandleEndAngle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SliderHandleEndAngle, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SliderHandleEndAngle, __InBuffer);
				}
			}
		}

		public float AngularOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AngularOffset, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AngularOffset, __InBuffer);
				}
			}
		}

		public FVector2D HandStartEndRatio
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HandStartEndRatio, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HandStartEndRatio, __InBuffer);
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

		public FLinearColor SliderProgressColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SliderProgressColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SliderProgressColor, __InBuffer);
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

		public FLinearColor CenterBackgroundColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CenterBackgroundColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CenterBackgroundColor, __InBuffer);
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

		public bool UseVerticalDrag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UseVerticalDrag, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UseVerticalDrag, __InBuffer);
				}
			}
		}

		public bool ShowSliderHandle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShowSliderHandle, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShowSliderHandle, __InBuffer);
				}
			}
		}

		public bool ShowSliderHand
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShowSliderHand, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShowSliderHand, __InBuffer);
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AdvancedWidgets.RadialSlider");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetValueTags(TArray<float> InValueTags)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValueTags?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValueTags, __InBuffer);
			}
		}

		public virtual void SetValue(float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValue, __InBuffer);
			}
		}

		public virtual void SetUseVerticalDrag(bool InUseVerticalDrag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InUseVerticalDrag;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUseVerticalDrag, __InBuffer);
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

		public virtual void SetSliderRange(FRuntimeFloatCurve InSliderRange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSliderRange?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSliderRange, __InBuffer);
			}
		}

		public virtual void SetSliderProgressColor(FLinearColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSliderProgressColor, __InBuffer);
			}
		}

		public virtual void SetSliderHandleStartAngle(float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSliderHandleStartAngle, __InBuffer);
			}
		}

		public virtual void SetSliderHandleEndAngle(float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSliderHandleEndAngle, __InBuffer);
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

		public virtual void SetShowSliderHandle(bool InShowSliderHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InShowSliderHandle;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShowSliderHandle, __InBuffer);
			}
		}

		public virtual void SetShowSliderHand(bool InShowSliderHand)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InShowSliderHand;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShowSliderHand, __InBuffer);
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

		public virtual void SetHandStartEndRatio(FVector2D InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetHandStartEndRatio, __InBuffer);
			}
		}

		public virtual void SetCustomDefaultValue(float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCustomDefaultValue, __InBuffer);
			}
		}

		public virtual void SetCenterBackgroundColor(FLinearColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCenterBackgroundColor, __InBuffer);
			}
		}

		public virtual void SetAngularOffset(float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularOffset, __InBuffer);
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

		public virtual float GetNormalizedSliderHandlePosition()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNormalizedSliderHandlePosition, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetCustomDefaultValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCustomDefaultValue, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __Value = 0;

		private static uint __ValueDelegate = 0;

		private static uint __bUseCustomDefaultValue = 0;

		private static uint __CustomDefaultValue = 0;

		private static uint __SliderRange = 0;

		private static uint __ValueTags = 0;

		private static uint __SliderHandleStartAngle = 0;

		private static uint __SliderHandleEndAngle = 0;

		private static uint __AngularOffset = 0;

		private static uint __HandStartEndRatio = 0;

		private static uint __WidgetStyle = 0;

		private static uint __SliderBarColor = 0;

		private static uint __SliderProgressColor = 0;

		private static uint __SliderHandleColor = 0;

		private static uint __CenterBackgroundColor = 0;

		private static uint __Locked = 0;

		private static uint __MouseUsesStep = 0;

		private static uint __RequiresControllerLock = 0;

		private static uint __StepSize = 0;

		private static uint __IsFocusable = 0;

		private static uint __UseVerticalDrag = 0;

		private static uint __ShowSliderHandle = 0;

		private static uint __ShowSliderHand = 0;

		private static uint __OnMouseCaptureBegin = 0;

		private static uint __OnMouseCaptureEnd = 0;

		private static uint __OnControllerCaptureBegin = 0;

		private static uint __OnControllerCaptureEnd = 0;

		private static uint __OnValueChanged = 0;

		private static uint __SetValueTags = 0;

		private static uint __SetValue = 0;

		private static uint __SetUseVerticalDrag = 0;

		private static uint __SetStepSize = 0;

		private static uint __SetSliderRange = 0;

		private static uint __SetSliderProgressColor = 0;

		private static uint __SetSliderHandleStartAngle = 0;

		private static uint __SetSliderHandleEndAngle = 0;

		private static uint __SetSliderHandleColor = 0;

		private static uint __SetSliderBarColor = 0;

		private static uint __SetShowSliderHandle = 0;

		private static uint __SetShowSliderHand = 0;

		private static uint __SetLocked = 0;

		private static uint __SetHandStartEndRatio = 0;

		private static uint __SetCustomDefaultValue = 0;

		private static uint __SetCenterBackgroundColor = 0;

		private static uint __SetAngularOffset = 0;

		private static uint __GetValue = 0;

		private static uint __GetNormalizedSliderHandlePosition = 0;

		private static uint __GetCustomDefaultValue = 0;
	}
}