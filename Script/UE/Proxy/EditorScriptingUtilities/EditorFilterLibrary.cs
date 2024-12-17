using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EditorFilterLibrary")]
	public partial class UEditorFilterLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorScriptingUtilities.EditorFilterLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="TargetArray">
		/// Array of Object to filter. The array will not change.
		/// </param>
		/// <param name="FilterType">
		/// Should include or not the array's item if it respects the condition.
		/// </param>
		/// <returns>
		/// The filtered list.
		/// </returns>
		public static TArray<AActor> BySelection(TArray<AActor> TargetArray, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)FilterType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BySelection, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// Array of Actor to filter. The array will not change.
		/// </param>
		/// <param name="LevelName">
		/// The name of the Level the actor belongs to (same name as in the ContentBrowser).
		/// </param>
		/// <param name="FilterType">
		/// Should include or not the array's item if it respects the condition.
		/// </param>
		/// <returns>
		/// The filtered list.
		/// </returns>
		public static TArray<AActor> ByLevelName(TArray<AActor> TargetArray, FName LevelName, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LevelName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)FilterType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ByLevelName, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// Array of Actor to filter. The array will not change.
		/// </param>
		/// <param name="LayerName">
		/// The exact name of the Layer the actor belongs to.
		/// </param>
		/// <param name="FilterType">
		/// Should include or not the array's item if it respects the condition.
		/// </param>
		/// <returns>
		/// The filtered list.
		/// </returns>
		public static TArray<AActor> ByLayer(TArray<AActor> TargetArray, FName LayerName, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)FilterType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ByLayer, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// Array of Object to filter. The array will not change.
		/// </param>
		/// <param name="NameSubString">
		/// The text the Object's ID name.
		/// </param>
		/// <param name="FilterType">
		/// Should include or not the array's item if it respects the condition.
		/// </param>
		/// <param name="StringMatch">
		/// Contains the NameSubString OR matches with the wildcard *? OR exactly the same value.
		/// </param>
		/// <returns>
		/// The filtered list.
		/// </returns>
		public static TArray<UObject> ByIDName(TArray<UObject> TargetArray, FString NameSubString, EEditorScriptingStringMatchType StringMatch = EEditorScriptingStringMatchType.Contains, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NameSubString?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)StringMatch;

				*(byte*)(__InBuffer + 17) = (byte)FilterType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ByIDName, __InBuffer, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// Array of Object to filter. The array will not change.
		/// </param>
		/// <param name="ObjectClass">
		/// The Class of the object.
		/// </param>
		/// <param name="FilterType">
		/// Should include or not the array's item if it respects the condition.
		/// </param>
		/// <returns>
		/// The filtered list.
		/// </returns>
		public static TArray<UObject> ByClass(TArray<UObject> TargetArray, TSubclassOf<UObject> ObjectClass, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ObjectClass?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)FilterType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ByClass, __InBuffer, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// Array of Actor to filter. The array will not change.
		/// </param>
		/// <param name="Tag">
		/// The exact name of the Tag the actor contains.
		/// </param>
		/// <param name="FilterType">
		/// Should include or not the array's item if it respects the condition.
		/// </param>
		/// <returns>
		/// The filtered list.
		/// </returns>
		public static TArray<AActor> ByActorTag(TArray<AActor> TargetArray, FName Tag, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)FilterType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ByActorTag, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// Array of Actor to filter. The array will not change.
		/// </param>
		/// <param name="NameSubString">
		/// The text the Actor's Label.
		/// </param>
		/// <param name="FilterType">
		/// Should include or not the array's item if it respects the condition.
		/// </param>
		/// <param name="StringMatch">
		/// Contains the NameSubString OR matches with the wildcard *? OR exactly the same value.
		/// </param>
		/// <param name="bIgnoreCase">
		/// Determines case sensitivity options for string comparisons.
		/// </param>
		/// <returns>
		/// The filtered list.
		/// </returns>
		public static TArray<AActor> ByActorLabel(TArray<AActor> TargetArray, FString NameSubString, EEditorScriptingStringMatchType StringMatch = EEditorScriptingStringMatchType.Contains, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include, bool bIgnoreCase = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NameSubString?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)StringMatch;

				*(byte*)(__InBuffer + 17) = (byte)FilterType;

				*(bool*)(__InBuffer + 18) = bIgnoreCase;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ByActorLabel, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		private static uint __BySelection = 0;

		private static uint __ByLevelName = 0;

		private static uint __ByLayer = 0;

		private static uint __ByIDName = 0;

		private static uint __ByClass = 0;

		private static uint __ByActorTag = 0;

		private static uint __ByActorLabel = 0;
	}
}