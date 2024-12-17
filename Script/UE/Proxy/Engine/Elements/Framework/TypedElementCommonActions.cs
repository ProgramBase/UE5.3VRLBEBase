using Script.CoreUObject;
using Script.Library;
using Script.TypedElementFramework;
using Script.TypedElementRuntime;

namespace Script.Engine
{
	[PathName("/Script/Engine.TypedElementCommonActions")]
	public partial class UTypedElementCommonActions : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TypedElementCommonActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <note>
		/// This list should have been pre-normalized via UTypedElementSelectionSet::GetNormalizedSelection or UTypedElementSelectionSet::GetNormalizedElementList.
		/// </note>
		public virtual TArray<FScriptTypedElementHandle> PasteNormalizedElementsFromString(FScriptTypedElementListProxy ElementList, UWorld World, FTypedElementPasteOptions PasteOption, FString InputString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PasteOption?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InputString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PasteNormalizedElementsFromString, __InBuffer, __ReturnBuffer);

				return *(TArray<FScriptTypedElementHandle>*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Internally this just calls PasteNormalizedElements on the result of UTypedElementSelectionSet::GetNormalizedSelection.
		/// </note>
		public virtual TArray<FScriptTypedElementHandle> PasteElementsFromString(UTypedElementSelectionSet SelectionSet, UWorld World, FTypedElementPasteOptions PasteOption, FString InputString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = SelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PasteOption?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InputString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PasteElementsFromString, __InBuffer, __ReturnBuffer);

				return *(TArray<FScriptTypedElementHandle>*)__ReturnBuffer;
			}
		}

		/// <note>
		/// This list should have been pre-normalized via UTypedElementSelectionSet::GetNormalizedSelection or UTypedElementSelectionSet::GetNormalizedElementList.
		/// </note>
		public virtual TArray<FScriptTypedElementHandle> K2_PasteNormalizedElements(FScriptTypedElementListProxy ElementList, UWorld World, FTypedElementPasteOptions PasteOption)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PasteOption?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_PasteNormalizedElements, __InBuffer, __ReturnBuffer);

				return *(TArray<FScriptTypedElementHandle>*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Internally this just calls PasteNormalizedElements on the result of UTypedElementSelectionSet::GetNormalizedSelection.
		/// </note>
		public virtual TArray<FScriptTypedElementHandle> K2_PasteElements(UTypedElementSelectionSet SelectionSet, UWorld World, FTypedElementPasteOptions PasteOption)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PasteOption?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_PasteElements, __InBuffer, __ReturnBuffer);

				return *(TArray<FScriptTypedElementHandle>*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Internally this just calls DuplicateNormalizedElements on the result of UTypedElementSelectionSet::GetNormalizedSelection.
		/// </note>
		public virtual TArray<FScriptTypedElementHandle> K2_DuplicateSelectedElements(UTypedElementSelectionSet SelectionSet, UWorld World, FVector LocationOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LocationOffset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_DuplicateSelectedElements, __InBuffer, __ReturnBuffer);

				return *(TArray<FScriptTypedElementHandle>*)__ReturnBuffer;
			}
		}

		/// <note>
		/// This list should have been pre-normalized via UTypedElementSelectionSet::GetNormalizedSelection or UTypedElementSelectionSet::GetNormalizedElementList.
		/// </note>
		public virtual TArray<FScriptTypedElementHandle> DuplicateNormalizedElements(FScriptTypedElementListProxy ElementList, UWorld World, FVector LocationOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LocationOffset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __DuplicateNormalizedElements, __InBuffer, __ReturnBuffer);

				return *(TArray<FScriptTypedElementHandle>*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Internally this just calls DeleteNormalizedElements on the result of UTypedElementSelectionSet::GetNormalizedSelection.
		/// </note>
		public virtual bool DeleteSelectedElements(UTypedElementSelectionSet SelectionSet, UWorld World, FTypedElementDeletionOptions DeletionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DeletionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DeleteSelectedElements, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// This list should have been pre-normalized via UTypedElementSelectionSet::GetNormalizedSelection or UTypedElementSelectionSet::GetNormalizedElementList.
		/// </note>
		public virtual bool DeleteNormalizedElements(FScriptTypedElementListProxy ElementList, UWorld World, UTypedElementSelectionSet InSelectionSet, FTypedElementDeletionOptions DeletionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = DeletionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DeleteNormalizedElements, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Internally this just calls CopyNormalizedElements on the result of UTypedElementSelectionSet::GetNormalizedSelection.
		/// </note>
		public virtual bool CopySelectedElementsToString(UTypedElementSelectionSet SelectionSet, ref FString OutputString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutputString?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __CopySelectedElementsToString, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutputString = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Internally this just calls CopyNormalizedElements on the result of UTypedElementSelectionSet::GetNormalizedSelection.
		/// </note>
		public virtual bool CopySelectedElements(UTypedElementSelectionSet SelectionSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CopySelectedElements, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// This list should have been pre-normalized via UTypedElementSelectionSet::GetNormalizedSelection or UTypedElementSelectionSet::GetNormalizedElementList.
		/// </note>
		public virtual bool CopyNormalizedElementsToString(FScriptTypedElementListProxy ElementList, ref FString OutputString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutputString?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __CopyNormalizedElementsToString, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutputString = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// This list should have been pre-normalized via UTypedElementSelectionSet::GetNormalizedSelection or UTypedElementSelectionSet::GetNormalizedElementList.
		/// </note>
		public virtual bool CopyNormalizedElements(FScriptTypedElementListProxy ElementList)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CopyNormalizedElements, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __PasteNormalizedElementsFromString = 0;

		private static uint __PasteElementsFromString = 0;

		private static uint __K2_PasteNormalizedElements = 0;

		private static uint __K2_PasteElements = 0;

		private static uint __K2_DuplicateSelectedElements = 0;

		private static uint __DuplicateNormalizedElements = 0;

		private static uint __DeleteSelectedElements = 0;

		private static uint __DeleteNormalizedElements = 0;

		private static uint __CopySelectedElementsToString = 0;

		private static uint __CopySelectedElements = 0;

		private static uint __CopyNormalizedElementsToString = 0;

		private static uint __CopyNormalizedElements = 0;
	}
}