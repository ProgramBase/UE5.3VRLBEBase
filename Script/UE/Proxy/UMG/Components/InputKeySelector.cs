using Script.CoreUObject;
using Script.SlateCore;
using Script.Slate;
using Script.UMG.InputKeySelector;
using Script.InputCore;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.InputKeySelector")]
	public partial class UInputKeySelector : UWidget, IStaticClass
	{
		public FButtonStyle WidgetStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetStyle, __ReturnBuffer);

					return *(FButtonStyle*)__ReturnBuffer;
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

		public FTextBlockStyle TextStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextStyle, __ReturnBuffer);

					return *(FTextBlockStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextStyle, __InBuffer);
				}
			}
		}

		public FInputChord SelectedKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedKey, __ReturnBuffer);

					return *(FInputChord*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedKey, __InBuffer);
				}
			}
		}

		public FMargin Margin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Margin, __ReturnBuffer);

					return *(FMargin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Margin, __InBuffer);
				}
			}
		}

		public FText KeySelectionText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __KeySelectionText, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __KeySelectionText, __InBuffer);
				}
			}
		}

		public FText NoKeySpecifiedText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NoKeySpecifiedText, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NoKeySpecifiedText, __InBuffer);
				}
			}
		}

		public bool bAllowModifierKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowModifierKeys, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowModifierKeys, __InBuffer);
				}
			}
		}

		public bool bAllowGamepadKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowGamepadKeys, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowGamepadKeys, __InBuffer);
				}
			}
		}

		public TArray<FKey> EscapeKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EscapeKeys, __ReturnBuffer);

					return *(TArray<FKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EscapeKeys, __InBuffer);
				}
			}
		}

		public FOnKeySelected OnKeySelected
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnKeySelected, __ReturnBuffer);

					return *(FOnKeySelected*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnKeySelected, __InBuffer);
				}
			}
		}

		public FOnIsSelectingKeyChanged OnIsSelectingKeyChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnIsSelectingKeyChanged, __ReturnBuffer);

					return *(FOnIsSelectingKeyChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnIsSelectingKeyChanged, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.InputKeySelector");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetTextBlockVisibility(ESlateVisibility InVisibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InVisibility;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTextBlockVisibility, __InBuffer);
			}
		}

		public virtual void SetSelectedKey(FInputChord InSelectedKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSelectedKey?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSelectedKey, __InBuffer);
			}
		}

		public virtual void SetNoKeySpecifiedText(FText InNoKeySpecifiedText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNoKeySpecifiedText?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNoKeySpecifiedText, __InBuffer);
			}
		}

		public virtual void SetKeySelectionText(FText InKeySelectionText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKeySelectionText?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetKeySelectionText, __InBuffer);
			}
		}

		public virtual void SetEscapeKeys(TArray<FKey> InKeys)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKeys?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEscapeKeys, __InBuffer);
			}
		}

		public virtual void SetAllowModifierKeys(bool bInAllowModifierKeys)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInAllowModifierKeys;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllowModifierKeys, __InBuffer);
			}
		}

		public virtual void SetAllowGamepadKeys(bool bInAllowGamepadKeys)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInAllowGamepadKeys;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllowGamepadKeys, __InBuffer);
			}
		}

		public virtual bool GetIsSelectingKey()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetIsSelectingKey, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __WidgetStyle = 0;

		private static uint __TextStyle = 0;

		private static uint __SelectedKey = 0;

		private static uint __Margin = 0;

		private static uint __KeySelectionText = 0;

		private static uint __NoKeySpecifiedText = 0;

		private static uint __bAllowModifierKeys = 0;

		private static uint __bAllowGamepadKeys = 0;

		private static uint __EscapeKeys = 0;

		private static uint __OnKeySelected = 0;

		private static uint __OnIsSelectingKeyChanged = 0;

		private static uint __SetTextBlockVisibility = 0;

		private static uint __SetSelectedKey = 0;

		private static uint __SetNoKeySpecifiedText = 0;

		private static uint __SetKeySelectionText = 0;

		private static uint __SetEscapeKeys = 0;

		private static uint __SetAllowModifierKeys = 0;

		private static uint __SetAllowGamepadKeys = 0;

		private static uint __GetIsSelectingKey = 0;
	}
}