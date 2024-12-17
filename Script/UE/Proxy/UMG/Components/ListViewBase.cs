using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.ListViewBase")]
	public partial class UListViewBase : UWidget, IStaticClass
	{
		public FOnListEntryGeneratedDynamic BP_OnEntryGenerated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnEntryGenerated, __ReturnBuffer);

					return *(FOnListEntryGeneratedDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnEntryGenerated, __InBuffer);
				}
			}
		}

		public TSubclassOf<UUserWidget> EntryWidgetClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EntryWidgetClass, __ReturnBuffer);

					return *(TSubclassOf<UUserWidget>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EntryWidgetClass, __InBuffer);
				}
			}
		}

		public float WheelScrollMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WheelScrollMultiplier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WheelScrollMultiplier, __InBuffer);
				}
			}
		}

		public bool bEnableScrollAnimation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableScrollAnimation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableScrollAnimation, __InBuffer);
				}
			}
		}

		public bool AllowOverscroll
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AllowOverscroll, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AllowOverscroll, __InBuffer);
				}
			}
		}

		public bool bEnableRightClickScrolling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableRightClickScrolling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableRightClickScrolling, __InBuffer);
				}
			}
		}

		public bool bEnableFixedLineOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableFixedLineOffset, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableFixedLineOffset, __InBuffer);
				}
			}
		}

		public float FixedLineScrollOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FixedLineScrollOffset, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FixedLineScrollOffset, __InBuffer);
				}
			}
		}

		public bool bAllowDragging
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowDragging, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowDragging, __InBuffer);
				}
			}
		}

		public FOnListEntryReleasedDynamic BP_OnEntryReleased
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnEntryReleased, __ReturnBuffer);

					return *(FOnListEntryReleasedDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnEntryReleased, __InBuffer);
				}
			}
		}

		public int NumDesignerPreviewEntries
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumDesignerPreviewEntries, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumDesignerPreviewEntries, __InBuffer);
				}
			}
		}

		public FUserWidgetPool EntryWidgetPool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EntryWidgetPool, __ReturnBuffer);

					return *(FUserWidgetPool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EntryWidgetPool, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.ListViewBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetWheelScrollMultiplier(float NewWheelScrollMultiplier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewWheelScrollMultiplier;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWheelScrollMultiplier, __InBuffer);
			}
		}

		public virtual void SetScrollOffset(float InScrollOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InScrollOffset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScrollOffset, __InBuffer);
			}
		}

		public virtual void SetScrollbarVisibility(ESlateVisibility InVisibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InVisibility;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScrollbarVisibility, __InBuffer);
			}
		}

		public virtual void ScrollToTop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ScrollToTop);
			}
		}

		public virtual void ScrollToBottom()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ScrollToBottom);
			}
		}

		public virtual void RequestRefresh()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RequestRefresh);
			}
		}

		public virtual void RegenerateAllEntries()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RegenerateAllEntries);
			}
		}

		public virtual float GetScrollOffset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetScrollOffset, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual TArray<UUserWidget> GetDisplayedEntryWidgets()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDisplayedEntryWidgets, __ReturnBuffer);

				return *(TArray<UUserWidget>*)__ReturnBuffer;
			}
		}

		private static uint __BP_OnEntryGenerated = 0;

		private static uint __EntryWidgetClass = 0;

		private static uint __WheelScrollMultiplier = 0;

		private static uint __bEnableScrollAnimation = 0;

		private static uint __AllowOverscroll = 0;

		private static uint __bEnableRightClickScrolling = 0;

		private static uint __bEnableFixedLineOffset = 0;

		private static uint __FixedLineScrollOffset = 0;

		private static uint __bAllowDragging = 0;

		private static uint __BP_OnEntryReleased = 0;

		private static uint __NumDesignerPreviewEntries = 0;

		private static uint __EntryWidgetPool = 0;

		private static uint __SetWheelScrollMultiplier = 0;

		private static uint __SetScrollOffset = 0;

		private static uint __SetScrollbarVisibility = 0;

		private static uint __ScrollToTop = 0;

		private static uint __ScrollToBottom = 0;

		private static uint __RequestRefresh = 0;

		private static uint __RegenerateAllEntries = 0;

		private static uint __GetScrollOffset = 0;

		private static uint __GetDisplayedEntryWidgets = 0;
	}
}