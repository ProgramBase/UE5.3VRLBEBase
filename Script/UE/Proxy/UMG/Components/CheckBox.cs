using Script.CoreUObject;
using Script.SlateCore;
using Script.UMG.Widget;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.CheckBox")]
	public partial class UCheckBox : UContentWidget, IStaticClass
	{
		public ECheckBoxState CheckedState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CheckedState, __ReturnBuffer);

					return *(ECheckBoxState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CheckedState, __InBuffer);
				}
			}
		}

		public FGetCheckBoxState CheckedStateDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CheckedStateDelegate, __ReturnBuffer);

					return *(FGetCheckBoxState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CheckedStateDelegate, __InBuffer);
				}
			}
		}

		public FCheckBoxStyle WidgetStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetStyle, __ReturnBuffer);

					return *(FCheckBoxStyle*)__ReturnBuffer;
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

		public EHorizontalAlignment HorizontalAlignment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HorizontalAlignment, __ReturnBuffer);

					return *(EHorizontalAlignment*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HorizontalAlignment, __InBuffer);
				}
			}
		}

		public EButtonClickMethod ClickMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClickMethod, __ReturnBuffer);

					return *(EButtonClickMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClickMethod, __InBuffer);
				}
			}
		}

		public EButtonTouchMethod TouchMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TouchMethod, __ReturnBuffer);

					return *(EButtonTouchMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TouchMethod, __InBuffer);
				}
			}
		}

		public EButtonPressMethod PressMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PressMethod, __ReturnBuffer);

					return *(EButtonPressMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PressMethod, __InBuffer);
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

		public FOnCheckBoxComponentStateChanged OnCheckStateChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnCheckStateChanged, __ReturnBuffer);

					return *(FOnCheckBoxComponentStateChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnCheckStateChanged, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.CheckBox");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetTouchMethod(EButtonTouchMethod InTouchMethod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InTouchMethod;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTouchMethod, __InBuffer);
			}
		}

		public virtual void SetPressMethod(EButtonPressMethod InPressMethod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InPressMethod;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPressMethod, __InBuffer);
			}
		}

		public virtual void SetIsChecked(bool InIsChecked)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InIsChecked;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIsChecked, __InBuffer);
			}
		}

		public virtual void SetClickMethod(EButtonClickMethod InClickMethod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InClickMethod;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetClickMethod, __InBuffer);
			}
		}

		public virtual void SetCheckedState(ECheckBoxState InCheckedState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InCheckedState;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCheckedState, __InBuffer);
			}
		}

		public virtual bool IsPressed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPressed, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsChecked()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsChecked, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual ECheckBoxState GetCheckedState()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCheckedState, __ReturnBuffer);

				return *(ECheckBoxState*)__ReturnBuffer;
			}
		}

		private static uint __CheckedState = 0;

		private static uint __CheckedStateDelegate = 0;

		private static uint __WidgetStyle = 0;

		private static uint __HorizontalAlignment = 0;

		private static uint __ClickMethod = 0;

		private static uint __TouchMethod = 0;

		private static uint __PressMethod = 0;

		private static uint __IsFocusable = 0;

		private static uint __OnCheckStateChanged = 0;

		private static uint __SetTouchMethod = 0;

		private static uint __SetPressMethod = 0;

		private static uint __SetIsChecked = 0;

		private static uint __SetClickMethod = 0;

		private static uint __SetCheckedState = 0;

		private static uint __IsPressed = 0;

		private static uint __IsChecked = 0;

		private static uint __GetCheckedState = 0;
	}
}