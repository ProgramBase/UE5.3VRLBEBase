using Script.CoreUObject;
using Script.Library;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.ToolMenuSectionExtensions")]
	public partial class UToolMenuSectionExtensions : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolMenus.ToolMenuSectionExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetLabel(ref FToolMenuSection Section, FText Label)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Label?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetLabel, __InBuffer, __OutBuffer);

				Section = *(FToolMenuSection*)(__OutBuffer);

			}
		}

		public static FText GetLabel(FToolMenuSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLabel, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static void AddEntryObject(ref FToolMenuSection Section, UToolMenuEntryScript InObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InObject?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __AddEntryObject, __InBuffer, __OutBuffer);

				Section = *(FToolMenuSection*)(__OutBuffer);

			}
		}

		public static void AddEntry(ref FToolMenuSection Section, FToolMenuEntry Args)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Args?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __AddEntry, __InBuffer, __OutBuffer);

				Section = *(FToolMenuSection*)(__OutBuffer);

			}
		}

		private static uint __SetLabel = 0;

		private static uint __GetLabel = 0;

		private static uint __AddEntryObject = 0;

		private static uint __AddEntry = 0;
	}
}