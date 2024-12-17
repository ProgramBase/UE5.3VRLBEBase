using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.DynamicEntryBox")]
	public partial class UDynamicEntryBox : UDynamicEntryBoxBase, IStaticClass
	{
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.DynamicEntryBox");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Reset(bool bDeleteWidgets = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bDeleteWidgets;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Reset, __InBuffer);
			}
		}

		public virtual void RemoveEntry(UUserWidget EntryWidget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EntryWidget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveEntry, __InBuffer);
			}
		}

		public virtual UUserWidget BP_CreateEntryOfClass(TSubclassOf<UUserWidget> EntryClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EntryClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __BP_CreateEntryOfClass, __InBuffer, __ReturnBuffer);

				return *(UUserWidget*)__ReturnBuffer;
			}
		}

		public virtual UUserWidget BP_CreateEntry()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __BP_CreateEntry, __ReturnBuffer);

				return *(UUserWidget*)__ReturnBuffer;
			}
		}

		private static uint __NumDesignerPreviewEntries = 0;

		private static uint __EntryWidgetClass = 0;

		private static uint __Reset = 0;

		private static uint __RemoveEntry = 0;

		private static uint __BP_CreateEntryOfClass = 0;

		private static uint __BP_CreateEntry = 0;
	}
}