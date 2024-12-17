using Script.CoreUObject;
using Script.UMG.Widget;
using Script.SlateCore;
using Script.Slate;
using Script.UMG.MultiLineEditableTextBox;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.MultiLineEditableTextBox")]
	public partial class UMultiLineEditableTextBox : UTextLayoutWidget, IStaticClass
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

		public FText HintText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HintText, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HintText, __InBuffer);
				}
			}
		}

		public FGetText HintTextDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HintTextDelegate, __ReturnBuffer);

					return *(FGetText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HintTextDelegate, __InBuffer);
				}
			}
		}

		public FEditableTextBoxStyle WidgetStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetStyle, __ReturnBuffer);

					return *(FEditableTextBoxStyle*)__ReturnBuffer;
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

		public bool bIsReadOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsReadOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsReadOnly, __InBuffer);
				}
			}
		}

		public bool AllowContextMenu
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AllowContextMenu, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AllowContextMenu, __InBuffer);
				}
			}
		}

		public FVirtualKeyboardOptions VirtualKeyboardOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualKeyboardOptions, __ReturnBuffer);

					return *(FVirtualKeyboardOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualKeyboardOptions, __InBuffer);
				}
			}
		}

		public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualKeyboardDismissAction, __ReturnBuffer);

					return *(EVirtualKeyboardDismissAction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualKeyboardDismissAction, __InBuffer);
				}
			}
		}

		public FOnMultiLineEditableTextBoxChangedEvent OnTextChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTextChanged, __ReturnBuffer);

					return *(FOnMultiLineEditableTextBoxChangedEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTextChanged, __InBuffer);
				}
			}
		}

		public FOnMultiLineEditableTextBoxCommittedEvent OnTextCommitted
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTextCommitted, __ReturnBuffer);

					return *(FOnMultiLineEditableTextBoxCommittedEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTextCommitted, __InBuffer);
				}
			}
		}

		public bool bIsFontDeprecationDone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsFontDeprecationDone, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsFontDeprecationDone, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.MultiLineEditableTextBox");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetTextStyle(FTextBlockStyle InTextStyle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTextStyle?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTextStyle, __InBuffer);
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

		public virtual void SetIsReadOnly(bool bReadOnly)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bReadOnly;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIsReadOnly, __InBuffer);
			}
		}

		/// <param name="InHintText">
		/// The text that appears when there is no text in the text box
		/// </param>
		public virtual void SetHintText(FText InHintText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InHintText?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetHintText, __InBuffer);
			}
		}

		public virtual void SetForegroundColor(FLinearColor color)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = color?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetForegroundColor, __InBuffer);
			}
		}

		public virtual void SetError(FText InError)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InError?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetError, __InBuffer);
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

		public virtual FText GetHintText()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetHintText, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		private static uint __Text = 0;

		private static uint __HintText = 0;

		private static uint __HintTextDelegate = 0;

		private static uint __WidgetStyle = 0;

		private static uint __bIsReadOnly = 0;

		private static uint __AllowContextMenu = 0;

		private static uint __VirtualKeyboardOptions = 0;

		private static uint __VirtualKeyboardDismissAction = 0;

		private static uint __OnTextChanged = 0;

		private static uint __OnTextCommitted = 0;

		private static uint __bIsFontDeprecationDone = 0;

		private static uint __SetTextStyle = 0;

		private static uint __SetText = 0;

		private static uint __SetIsReadOnly = 0;

		private static uint __SetHintText = 0;

		private static uint __SetForegroundColor = 0;

		private static uint __SetError = 0;

		private static uint __GetText = 0;

		private static uint __GetHintText = 0;
	}
}