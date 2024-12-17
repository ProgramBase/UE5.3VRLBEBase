using Script.CoreUObject;
using Script.Slate;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.TileView")]
	public partial class UTileView : UListView, IStaticClass
	{
		public float EntryHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EntryHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EntryHeight, __InBuffer);
				}
			}
		}

		public float EntryWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EntryWidth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EntryWidth, __InBuffer);
				}
			}
		}

		public EListItemAlignment TileAlignment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TileAlignment, __ReturnBuffer);

					return *(EListItemAlignment*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TileAlignment, __InBuffer);
				}
			}
		}

		public bool bWrapHorizontalNavigation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWrapHorizontalNavigation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWrapHorizontalNavigation, __InBuffer);
				}
			}
		}

		public bool bEntrySizeIncludesEntrySpacing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEntrySizeIncludesEntrySpacing, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEntrySizeIncludesEntrySpacing, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.TileView");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetEntryWidth(float NewWidth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewWidth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEntryWidth, __InBuffer);
			}
		}

		public virtual void SetEntryHeight(float NewHeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewHeight;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEntryHeight, __InBuffer);
			}
		}

		public virtual bool IsAligned()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsAligned, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetEntryWidth()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetEntryWidth, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetEntryHeight()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetEntryHeight, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __EntryHeight = 0;

		private static uint __EntryWidth = 0;

		private static uint __TileAlignment = 0;

		private static uint __bWrapHorizontalNavigation = 0;

		private static uint __bEntrySizeIncludesEntrySpacing = 0;

		private static uint __SetEntryWidth = 0;

		private static uint __SetEntryHeight = 0;

		private static uint __IsAligned = 0;

		private static uint __GetEntryWidth = 0;

		private static uint __GetEntryHeight = 0;
	}
}