using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.TreeView")]
	public partial class UTreeView : UListView, IStaticClass
	{
		public FOnGetItemChildrenDynamic BP_OnGetItemChildren
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnGetItemChildren, __ReturnBuffer);

					return *(FOnGetItemChildrenDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnGetItemChildren, __InBuffer);
				}
			}
		}

		public FOnItemExpansionChangedDynamic BP_OnItemExpansionChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnItemExpansionChanged, __ReturnBuffer);

					return *(FOnItemExpansionChangedDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BP_OnItemExpansionChanged, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.TreeView");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetItemExpansion(UObject Item, bool bExpandItem)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bExpandItem;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetItemExpansion, __InBuffer);
			}
		}

		public virtual void ExpandAll()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ExpandAll);
			}
		}

		public virtual void CollapseAll()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __CollapseAll);
			}
		}

		private static uint __BP_OnGetItemChildren = 0;

		private static uint __BP_OnItemExpansionChanged = 0;

		private static uint __SetItemExpansion = 0;

		private static uint __ExpandAll = 0;

		private static uint __CollapseAll = 0;
	}
}