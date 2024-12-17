using Script.CoreUObject;
using Script.SlateCore;
using Script.UMG.Widget;
using Script.UMG.ComboBoxString;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.ComboBoxString")]
	public partial class UComboBoxString : UWidget, IStaticClass
	{
		public TArray<FString> DefaultOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultOptions, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultOptions, __InBuffer);
				}
			}
		}

		public FString SelectedOption
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedOption, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedOption, __InBuffer);
				}
			}
		}

		public FComboBoxStyle WidgetStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetStyle, __ReturnBuffer);

					return *(FComboBoxStyle*)__ReturnBuffer;
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

		public FTableRowStyle ItemStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ItemStyle, __ReturnBuffer);

					return *(FTableRowStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ItemStyle, __InBuffer);
				}
			}
		}

		public FScrollBarStyle ScrollBarStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollBarStyle, __ReturnBuffer);

					return *(FScrollBarStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollBarStyle, __InBuffer);
				}
			}
		}

		public FMargin ContentPadding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ContentPadding, __ReturnBuffer);

					return *(FMargin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ContentPadding, __InBuffer);
				}
			}
		}

		public float MaxListHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxListHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxListHeight, __InBuffer);
				}
			}
		}

		public bool HasDownArrow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HasDownArrow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HasDownArrow, __InBuffer);
				}
			}
		}

		public bool EnableGamepadNavigationMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnableGamepadNavigationMode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnableGamepadNavigationMode, __InBuffer);
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

		public FSlateColor ForegroundColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForegroundColor, __ReturnBuffer);

					return *(FSlateColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForegroundColor, __InBuffer);
				}
			}
		}

		public bool bIsFocusable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsFocusable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsFocusable, __InBuffer);
				}
			}
		}

		public FGenerateWidgetForString OnGenerateWidgetEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnGenerateWidgetEvent, __ReturnBuffer);

					return *(FGenerateWidgetForString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnGenerateWidgetEvent, __InBuffer);
				}
			}
		}

		public FOnSelectionChangedEvent OnSelectionChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSelectionChanged, __ReturnBuffer);

					return *(FOnSelectionChangedEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSelectionChanged, __InBuffer);
				}
			}
		}

		public FOnOpeningEvent OnOpening
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnOpening, __ReturnBuffer);

					return *(FOnOpeningEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnOpening, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.ComboBoxString");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSelectedOption(FString Option)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Option?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSelectedOption, __InBuffer);
			}
		}

		public virtual void SetSelectedIndex(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSelectedIndex, __InBuffer);
			}
		}

		public virtual bool RemoveOption(FString Option)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Option?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveOption, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void RefreshOptions()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RefreshOptions);
			}
		}

		public virtual bool IsOpen()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsOpen, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FString GetSelectedOption()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSelectedOption, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual int GetSelectedIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSelectedIndex, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetOptionCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetOptionCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FString GetOptionAtIndex(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetOptionAtIndex, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual int FindOptionIndex(FString Option)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Option?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __FindOptionIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void ClearSelection()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearSelection);
			}
		}

		public virtual void ClearOptions()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearOptions);
			}
		}

		public virtual void AddOption(FString Option)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Option?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddOption, __InBuffer);
			}
		}

		private static uint __DefaultOptions = 0;

		private static uint __SelectedOption = 0;

		private static uint __WidgetStyle = 0;

		private static uint __ItemStyle = 0;

		private static uint __ScrollBarStyle = 0;

		private static uint __ContentPadding = 0;

		private static uint __MaxListHeight = 0;

		private static uint __HasDownArrow = 0;

		private static uint __EnableGamepadNavigationMode = 0;

		private static uint __Font = 0;

		private static uint __ForegroundColor = 0;

		private static uint __bIsFocusable = 0;

		private static uint __OnGenerateWidgetEvent = 0;

		private static uint __OnSelectionChanged = 0;

		private static uint __OnOpening = 0;

		private static uint __SetSelectedOption = 0;

		private static uint __SetSelectedIndex = 0;

		private static uint __RemoveOption = 0;

		private static uint __RefreshOptions = 0;

		private static uint __IsOpen = 0;

		private static uint __GetSelectedOption = 0;

		private static uint __GetSelectedIndex = 0;

		private static uint __GetOptionCount = 0;

		private static uint __GetOptionAtIndex = 0;

		private static uint __FindOptionIndex = 0;

		private static uint __ClearSelection = 0;

		private static uint __ClearOptions = 0;

		private static uint __AddOption = 0;
	}
}