using Script.CoreUObject;
using Script.SlateCore;
using Script.Slate;
using Script.Library;
using Script.Engine;

namespace Script.UMG
{
	[PathName("/Script/UMG.ListView")]
	public partial class UListView : UListViewBase, IStaticClass
	{
		public FTableViewStyle WidgetStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetStyle, __ReturnBuffer);

					return *(FTableViewStyle*)__ReturnBuffer;
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

		public ESelectionMode SelectionMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionMode, __ReturnBuffer);

					return *(ESelectionMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionMode, __InBuffer);
				}
			}
		}

		public EConsumeMouseWheel ConsumeMouseWheel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConsumeMouseWheel, __ReturnBuffer);

					return *(EConsumeMouseWheel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConsumeMouseWheel, __InBuffer);
				}
			}
		}

		public bool bClearSelectionOnClick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bClearSelectionOnClick, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bClearSelectionOnClick, __InBuffer);
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

		public bool bReturnFocusToSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReturnFocusToSelection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReturnFocusToSelection, __InBuffer);
				}
			}
		}

		public TArray<UObject> ListItems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ListItems, __ReturnBuffer);

					return *(TArray<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ListItems, __InBuffer);
				}
			}
		}

		public float EntrySpacing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EntrySpacing, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EntrySpacing, __InBuffer);
				}
			}
		}

		public float HorizontalEntrySpacing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HorizontalEntrySpacing, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HorizontalEntrySpacing, __InBuffer);
				}
			}
		}

		public float VerticalEntrySpacing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VerticalEntrySpacing, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VerticalEntrySpacing, __InBuffer);
				}
			}
		}

		public FOnListEntryInitializedDynamic BP_OnEntryInitialized
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnEntryInitialized, __ReturnBuffer);

					return *(FOnListEntryInitializedDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnEntryInitialized, __InBuffer);
				}
			}
		}

		public FSimpleListItemEventDynamic BP_OnItemClicked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnItemClicked, __ReturnBuffer);

					return *(FSimpleListItemEventDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnItemClicked, __InBuffer);
				}
			}
		}

		public FSimpleListItemEventDynamic BP_OnItemDoubleClicked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnItemDoubleClicked, __ReturnBuffer);

					return *(FSimpleListItemEventDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnItemDoubleClicked, __InBuffer);
				}
			}
		}

		public FOnItemIsHoveredChangedDynamic BP_OnItemIsHoveredChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnItemIsHoveredChanged, __ReturnBuffer);

					return *(FOnItemIsHoveredChangedDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnItemIsHoveredChanged, __InBuffer);
				}
			}
		}

		public FOnListItemSelectionChangedDynamic BP_OnItemSelectionChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnItemSelectionChanged, __ReturnBuffer);

					return *(FOnListItemSelectionChangedDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnItemSelectionChanged, __InBuffer);
				}
			}
		}

		public FOnListItemScrolledIntoViewDynamic BP_OnItemScrolledIntoView
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnItemScrolledIntoView, __ReturnBuffer);

					return *(FOnListItemScrolledIntoViewDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnItemScrolledIntoView, __InBuffer);
				}
			}
		}

		public FOnListViewScrolledDynamic BP_OnListViewScrolled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnListViewScrolled, __ReturnBuffer);

					return *(FOnListViewScrolledDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnListViewScrolled, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.ListView");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSelectionMode(ESelectionMode SelectionMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)SelectionMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSelectionMode, __InBuffer);
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

		public virtual void ScrollIndexIntoView(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScrollIndexIntoView, __InBuffer);
			}
		}

		public virtual void RemoveItem(UObject Item)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveItem, __InBuffer);
			}
		}

		public virtual void OnListItemOuterEndPlayed(AActor ItemOuter, EEndPlayReason EndPlayReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ItemOuter?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)EndPlayReason;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnListItemOuterEndPlayed, __InBuffer);
			}
		}

		public virtual void OnListItemEndPlayed(AActor Item, EEndPlayReason EndPlayReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)EndPlayReason;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnListItemEndPlayed, __InBuffer);
			}
		}

		public virtual void NavigateToIndex(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __NavigateToIndex, __InBuffer);
			}
		}

		public virtual bool IsRefreshPending()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsRefreshPending, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetVerticalEntrySpacing()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetVerticalEntrySpacing, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual int GetNumItems()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumItems, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual TArray<UObject> GetListItems()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetListItems, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		public virtual UObject GetItemAt(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetItemAt, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual int GetIndexForItem(UObject Item)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetIndexForItem, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual float GetHorizontalEntrySpacing()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetHorizontalEntrySpacing, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void ClearListItems()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearListItems);
			}
		}

		public virtual void BP_SetSelectedItem(UObject Item)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BP_SetSelectedItem, __InBuffer);
			}
		}

		public virtual void BP_SetListItems(TArray<UObject> InListItems)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InListItems?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BP_SetListItems, __InBuffer);
			}
		}

		public virtual void BP_SetItemSelection(UObject Item, bool bSelected)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSelected;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BP_SetItemSelection, __InBuffer);
			}
		}

		public virtual void BP_ScrollItemIntoView(UObject Item)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BP_ScrollItemIntoView, __InBuffer);
			}
		}

		public virtual void BP_NavigateToItem(UObject Item)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BP_NavigateToItem, __InBuffer);
			}
		}

		public virtual bool BP_IsItemVisible(UObject Item)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __BP_IsItemVisible, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool BP_GetSelectedItems(ref TArray<UObject> Items)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Items?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __BP_GetSelectedItems, __InBuffer, __OutBuffer, __ReturnBuffer);

				Items = *(TArray<UObject>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UObject BP_GetSelectedItem()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __BP_GetSelectedItem, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual int BP_GetNumItemsSelected()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __BP_GetNumItemsSelected, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void BP_ClearSelection()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __BP_ClearSelection);
			}
		}

		public virtual void BP_CancelScrollIntoView()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __BP_CancelScrollIntoView);
			}
		}

		public virtual void AddItem(UObject Item)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddItem, __InBuffer);
			}
		}

		private static uint __WidgetStyle = 0;

		private static uint __ScrollBarStyle = 0;

		private static uint __Orientation = 0;

		private static uint __SelectionMode = 0;

		private static uint __ConsumeMouseWheel = 0;

		private static uint __bClearSelectionOnClick = 0;

		private static uint __bIsFocusable = 0;

		private static uint __bReturnFocusToSelection = 0;

		private static uint __ListItems = 0;

		private static uint __EntrySpacing = 0;

		private static uint __HorizontalEntrySpacing = 0;

		private static uint __VerticalEntrySpacing = 0;

		private static uint __BP_OnEntryInitialized = 0;

		private static uint __BP_OnItemClicked = 0;

		private static uint __BP_OnItemDoubleClicked = 0;

		private static uint __BP_OnItemIsHoveredChanged = 0;

		private static uint __BP_OnItemSelectionChanged = 0;

		private static uint __BP_OnItemScrolledIntoView = 0;

		private static uint __BP_OnListViewScrolled = 0;

		private static uint __SetSelectionMode = 0;

		private static uint __SetSelectedIndex = 0;

		private static uint __ScrollIndexIntoView = 0;

		private static uint __RemoveItem = 0;

		private static uint __OnListItemOuterEndPlayed = 0;

		private static uint __OnListItemEndPlayed = 0;

		private static uint __NavigateToIndex = 0;

		private static uint __IsRefreshPending = 0;

		private static uint __GetVerticalEntrySpacing = 0;

		private static uint __GetNumItems = 0;

		private static uint __GetListItems = 0;

		private static uint __GetItemAt = 0;

		private static uint __GetIndexForItem = 0;

		private static uint __GetHorizontalEntrySpacing = 0;

		private static uint __ClearListItems = 0;

		private static uint __BP_SetSelectedItem = 0;

		private static uint __BP_SetListItems = 0;

		private static uint __BP_SetItemSelection = 0;

		private static uint __BP_ScrollItemIntoView = 0;

		private static uint __BP_NavigateToItem = 0;

		private static uint __BP_IsItemVisible = 0;

		private static uint __BP_GetSelectedItems = 0;

		private static uint __BP_GetSelectedItem = 0;

		private static uint __BP_GetNumItemsSelected = 0;

		private static uint __BP_ClearSelection = 0;

		private static uint __BP_CancelScrollIntoView = 0;

		private static uint __AddItem = 0;
	}
}