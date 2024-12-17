using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.ContentBrowserDataMenuContext_DragDropMenu")]
	public partial class UContentBrowserDataMenuContext_DragDropMenu : UObject, IStaticClass
	{
		public FContentBrowserItem DropTargetItem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DropTargetItem, __ReturnBuffer);

					return *(FContentBrowserItem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DropTargetItem, __InBuffer);
				}
			}
		}

		public TArray<FContentBrowserItem> DraggedItems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DraggedItems, __ReturnBuffer);

					return *(TArray<FContentBrowserItem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DraggedItems, __InBuffer);
				}
			}
		}

		public bool bCanMove
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanMove, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanMove, __InBuffer);
				}
			}
		}

		public bool bCanCopy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanCopy, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanCopy, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowserData.ContentBrowserDataMenuContext_DragDropMenu");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DropTargetItem = 0;

		private static uint __DraggedItems = 0;

		private static uint __bCanMove = 0;

		private static uint __bCanCopy = 0;
	}
}