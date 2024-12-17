using Script.CoreUObject;
using Script.UMG;
using Script.UMG.Widget;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.Synth2DSlider")]
	public partial class USynth2DSlider : UWidget, IStaticClass
	{
		public float ValueX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ValueX, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ValueX, __InBuffer);
				}
			}
		}

		public float ValueY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ValueY, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ValueY, __InBuffer);
				}
			}
		}

		public FGetFloat ValueXDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ValueXDelegate, __ReturnBuffer);

					return *(FGetFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ValueXDelegate, __InBuffer);
				}
			}
		}

		public FGetFloat ValueYDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ValueYDelegate, __ReturnBuffer);

					return *(FGetFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ValueYDelegate, __InBuffer);
				}
			}
		}

		public FSynth2DSliderStyle WidgetStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetStyle, __ReturnBuffer);

					return *(FSynth2DSliderStyle*)__ReturnBuffer;
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

		public FOnMouseCaptureBeginEventSynth2D OnMouseCaptureBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMouseCaptureBegin, __ReturnBuffer);

					return *(FOnMouseCaptureBeginEventSynth2D*)__ReturnBuffer;
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

		public FOnMouseCaptureEndEventSynth2D OnMouseCaptureEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMouseCaptureEnd, __ReturnBuffer);

					return *(FOnMouseCaptureEndEventSynth2D*)__ReturnBuffer;
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

		public FOnControllerCaptureBeginEventSynth2D OnControllerCaptureBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnControllerCaptureBegin, __ReturnBuffer);

					return *(FOnControllerCaptureBeginEventSynth2D*)__ReturnBuffer;
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

		public FOnControllerCaptureEndEventSynth2D OnControllerCaptureEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnControllerCaptureEnd, __ReturnBuffer);

					return *(FOnControllerCaptureEndEventSynth2D*)__ReturnBuffer;
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

		public FOnFloatValueChangedEventSynth2D OnValueChangedX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnValueChangedX, __ReturnBuffer);

					return *(FOnFloatValueChangedEventSynth2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnValueChangedX, __InBuffer);
				}
			}
		}

		public FOnFloatValueChangedEventSynth2D OnValueChangedY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnValueChangedY, __ReturnBuffer);

					return *(FOnFloatValueChangedEventSynth2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnValueChangedY, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.Synth2DSlider");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetValue(FVector2D InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

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

		public virtual FVector2D GetValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetValue, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		private static uint __ValueX = 0;

		private static uint __ValueY = 0;

		private static uint __ValueXDelegate = 0;

		private static uint __ValueYDelegate = 0;

		private static uint __WidgetStyle = 0;

		private static uint __SliderHandleColor = 0;

		private static uint __IndentHandle = 0;

		private static uint __Locked = 0;

		private static uint __StepSize = 0;

		private static uint __IsFocusable = 0;

		private static uint __OnMouseCaptureBegin = 0;

		private static uint __OnMouseCaptureEnd = 0;

		private static uint __OnControllerCaptureBegin = 0;

		private static uint __OnControllerCaptureEnd = 0;

		private static uint __OnValueChangedX = 0;

		private static uint __OnValueChangedY = 0;

		private static uint __SetValue = 0;

		private static uint __SetStepSize = 0;

		private static uint __SetSliderHandleColor = 0;

		private static uint __SetLocked = 0;

		private static uint __SetIndentHandle = 0;

		private static uint __GetValue = 0;
	}
}