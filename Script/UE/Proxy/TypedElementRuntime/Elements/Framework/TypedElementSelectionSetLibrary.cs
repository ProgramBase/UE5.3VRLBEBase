using Script.CoreUObject;
using Script.Library;
using Script.TypedElementFramework;

namespace Script.TypedElementRuntime
{
	[PathName("/Script/TypedElementRuntime.TypedElementSelectionSetLibrary")]
	public partial class UTypedElementSelectionSetLibrary : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementRuntime.TypedElementSelectionSetLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <note>
		/// Equivalent to calling ClearSelection then SelectElements, but happens in a single batch.
		/// </note>
		/// <returns>
		/// True if the selection was changed, false otherwise.
		/// </returns>
		public static bool SetSelectionFromList(UTypedElementSelectionSet SelectionSet, FScriptTypedElementListProxy ElementList, FTypedElementSelectionOptions SelectionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SelectionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetSelectionFromList, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the selection was changed, false otherwise.
		/// </returns>
		public static bool SelectElementsFromList(UTypedElementSelectionSet SelectionSet, FScriptTypedElementListProxy ElementList, FTypedElementSelectionOptions SelectionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SelectionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SelectElementsFromList, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FScriptTypedElementListProxy GetNormalizedSelection(UTypedElementSelectionSet SelectionSet, FTypedElementSelectionNormalizationOptions NormalizationOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NormalizationOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNormalizedSelection, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementListProxy*)__ReturnBuffer;
			}
		}

		public static FScriptTypedElementListProxy GetNormalizedElementList(UTypedElementSelectionSet SelectionSet, FScriptTypedElementListProxy ElementList, FTypedElementSelectionNormalizationOptions NormalizationOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NormalizationOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNormalizedElementList, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementListProxy*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the selection was changed, false otherwise.
		/// </returns>
		public static bool DeselectElementsFromList(UTypedElementSelectionSet SelectionSet, FScriptTypedElementListProxy ElementList, FTypedElementSelectionOptions SelectionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SelectionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DeselectElementsFromList, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetSelectionFromList = 0;

		private static uint __SelectElementsFromList = 0;

		private static uint __GetNormalizedSelection = 0;

		private static uint __GetNormalizedElementList = 0;

		private static uint __DeselectElementsFromList = 0;
	}
}