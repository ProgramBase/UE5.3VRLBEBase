using Script.CoreUObject;
using Script.Library;
using Script.Niagara;
using Script.Engine;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraClipboardEditorScriptingUtilities")]
	public partial class UNiagaraClipboardEditorScriptingUtilities : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraClipboardEditorScriptingUtilities");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void TrySetLocalValueAsInt(UNiagaraClipboardFunctionInput InInput, ref bool bOutSucceeded, int InValue, bool bLooseTyping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(nint*)(__InBuffer) = InInput?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOutSucceeded;

				*(int*)(__InBuffer + 9) = InValue;

				*(bool*)(__InBuffer + 13) = bLooseTyping;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __TrySetLocalValueAsInt, __InBuffer, __OutBuffer);

				bOutSucceeded = *(bool*)(__OutBuffer);

			}
		}

		public static void TryGetLocalValueAsInt(UNiagaraClipboardFunctionInput InInput, ref bool bOutSucceeded, ref int OutValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = InInput?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOutSucceeded;

				*(int*)(__InBuffer + 9) = OutValue;

				var __OutBuffer = stackalloc byte[5];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __TryGetLocalValueAsInt, __InBuffer, __OutBuffer);

				bOutSucceeded = *(bool*)(__OutBuffer);

				OutValue = *(int*)(__OutBuffer + 1);

			}
		}

		public static void TryGetLocalValueAsFloat(UNiagaraClipboardFunctionInput InInput, ref bool bOutSucceeded, ref float OutValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = InInput?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOutSucceeded;

				*(float*)(__InBuffer + 9) = OutValue;

				var __OutBuffer = stackalloc byte[5];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __TryGetLocalValueAsFloat, __InBuffer, __OutBuffer);

				bOutSucceeded = *(bool*)(__OutBuffer);

				OutValue = *(float*)(__OutBuffer + 1);

			}
		}

		public static void TryGetInputByName(TArray<UNiagaraClipboardFunctionInput> InInputs, FName InInputName, ref bool bOutSucceeded, ref UNiagaraClipboardFunctionInput OutInput)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InInputs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bOutSucceeded;

				*(nint*)(__InBuffer + 17) = OutInput?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __TryGetInputByName, __InBuffer, __OutBuffer);

				bOutSucceeded = *(bool*)(__OutBuffer);

				OutInput = *(UNiagaraClipboardFunctionInput*)(__OutBuffer + 1);

			}
		}

		public static FName GetTypeName(UNiagaraClipboardFunctionInput InInput)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InInput?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTypeName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public static UNiagaraClipboardFunctionInput CreateVec3LocalValueInput(UObject InOuter, FName InInputName, bool bInHasEditCondition, bool bInEditConditionValue, FVector InVec3Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InOuter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInHasEditCondition;

				*(bool*)(__InBuffer + 17) = bInEditConditionValue;

				*(nint*)(__InBuffer + 18) = InVec3Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateVec3LocalValueInput, __InBuffer, __ReturnBuffer);

				return *(UNiagaraClipboardFunctionInput*)__ReturnBuffer;
			}
		}

		public static UNiagaraClipboardFunctionInput CreateVec2LocalValueInput(UObject InOuter, FName InInputName, bool bInHasEditCondition, bool bInEditConditionValue, FVector2D InVec2Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InOuter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInHasEditCondition;

				*(bool*)(__InBuffer + 17) = bInEditConditionValue;

				*(nint*)(__InBuffer + 18) = InVec2Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateVec2LocalValueInput, __InBuffer, __ReturnBuffer);

				return *(UNiagaraClipboardFunctionInput*)__ReturnBuffer;
			}
		}

		public static UNiagaraClipboardFunctionInput CreateStructLocalValueInput(UObject InOuter, FName InInputName, bool bInHasEditCondition, bool bInEditConditionValue, UUserDefinedStruct InStructValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InOuter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInHasEditCondition;

				*(bool*)(__InBuffer + 17) = bInEditConditionValue;

				*(nint*)(__InBuffer + 18) = InStructValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateStructLocalValueInput, __InBuffer, __ReturnBuffer);

				return *(UNiagaraClipboardFunctionInput*)__ReturnBuffer;
			}
		}

		public static UNiagaraClipboardFunctionInput CreateLinkedValueInput(UObject InOuter, FName InInputName, FName InInputTypeName, bool bInHasEditCondition, bool bInEditConditionValue, FName InLinkedValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = InOuter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InInputTypeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bInHasEditCondition;

				*(bool*)(__InBuffer + 25) = bInEditConditionValue;

				*(nint*)(__InBuffer + 26) = InLinkedValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateLinkedValueInput, __InBuffer, __ReturnBuffer);

				return *(UNiagaraClipboardFunctionInput*)__ReturnBuffer;
			}
		}

		public static UNiagaraClipboardFunctionInput CreateIntLocalValueInput(UObject InOuter, FName InInputName, bool bInHasEditCondition, bool bInEditConditionValue, int InLocalValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[22];

				*(nint*)(__InBuffer) = InOuter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInHasEditCondition;

				*(bool*)(__InBuffer + 17) = bInEditConditionValue;

				*(int*)(__InBuffer + 18) = InLocalValue;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateIntLocalValueInput, __InBuffer, __ReturnBuffer);

				return *(UNiagaraClipboardFunctionInput*)__ReturnBuffer;
			}
		}

		public static UNiagaraClipboardFunctionInput CreateFloatLocalValueInput(UObject InOuter, FName InInputName, bool bInHasEditCondition, bool bInEditConditionValue, float InLocalValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[22];

				*(nint*)(__InBuffer) = InOuter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInHasEditCondition;

				*(bool*)(__InBuffer + 17) = bInEditConditionValue;

				*(float*)(__InBuffer + 18) = InLocalValue;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateFloatLocalValueInput, __InBuffer, __ReturnBuffer);

				return *(UNiagaraClipboardFunctionInput*)__ReturnBuffer;
			}
		}

		public static UNiagaraClipboardFunctionInput CreateExpressionValueInput(UObject InOuter, FName InInputName, FName InInputTypeName, bool bInHasEditCondition, bool bInEditConditionValue, FString InExpressionValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = InOuter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InInputTypeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bInHasEditCondition;

				*(bool*)(__InBuffer + 25) = bInEditConditionValue;

				*(nint*)(__InBuffer + 26) = InExpressionValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateExpressionValueInput, __InBuffer, __ReturnBuffer);

				return *(UNiagaraClipboardFunctionInput*)__ReturnBuffer;
			}
		}

		public static UNiagaraClipboardFunctionInput CreateEnumLocalValueInput(UObject InOuter, FName InInputName, bool bInHasEditCondition, bool bInEditCoditionValue, UUserDefinedEnum InEnumType, int InEnumValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[30];

				*(nint*)(__InBuffer) = InOuter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInHasEditCondition;

				*(bool*)(__InBuffer + 17) = bInEditCoditionValue;

				*(nint*)(__InBuffer + 18) = InEnumType?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 26) = InEnumValue;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateEnumLocalValueInput, __InBuffer, __ReturnBuffer);

				return *(UNiagaraClipboardFunctionInput*)__ReturnBuffer;
			}
		}

		public static UNiagaraClipboardFunctionInput CreateDynamicValueInput(UObject InOuter, FName InInputName, FName InInputTypeName, bool bInHasEditCondition, bool bInEditConditionValue, FString InDynamicValueName, UNiagaraScript InDynamicValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = InOuter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InInputTypeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bInHasEditCondition;

				*(bool*)(__InBuffer + 25) = bInEditConditionValue;

				*(nint*)(__InBuffer + 26) = InDynamicValueName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 34) = InDynamicValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateDynamicValueInput, __InBuffer, __ReturnBuffer);

				return *(UNiagaraClipboardFunctionInput*)__ReturnBuffer;
			}
		}

		public static UNiagaraClipboardFunctionInput CreateDataValueInput(UObject InOuter, FName InInputName, bool bInHasEditCondition, bool bInEditConditionValue, UNiagaraDataInterface InDataValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InOuter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInHasEditCondition;

				*(bool*)(__InBuffer + 17) = bInEditConditionValue;

				*(nint*)(__InBuffer + 18) = InDataValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateDataValueInput, __InBuffer, __ReturnBuffer);

				return *(UNiagaraClipboardFunctionInput*)__ReturnBuffer;
			}
		}

		public static UNiagaraClipboardFunctionInput CreateBoolLocalValueInput(UObject InOuter, FName InInputName, bool bInHasEditCondition, bool bInEditConditionValue, bool InBoolValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InOuter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInHasEditCondition;

				*(bool*)(__InBuffer + 17) = bInEditConditionValue;

				*(bool*)(__InBuffer + 18) = InBoolValue;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateBoolLocalValueInput, __InBuffer, __ReturnBuffer);

				return *(UNiagaraClipboardFunctionInput*)__ReturnBuffer;
			}
		}

		private static uint __TrySetLocalValueAsInt = 0;

		private static uint __TryGetLocalValueAsInt = 0;

		private static uint __TryGetLocalValueAsFloat = 0;

		private static uint __TryGetInputByName = 0;

		private static uint __GetTypeName = 0;

		private static uint __CreateVec3LocalValueInput = 0;

		private static uint __CreateVec2LocalValueInput = 0;

		private static uint __CreateStructLocalValueInput = 0;

		private static uint __CreateLinkedValueInput = 0;

		private static uint __CreateIntLocalValueInput = 0;

		private static uint __CreateFloatLocalValueInput = 0;

		private static uint __CreateExpressionValueInput = 0;

		private static uint __CreateEnumLocalValueInput = 0;

		private static uint __CreateDynamicValueInput = 0;

		private static uint __CreateDataValueInput = 0;

		private static uint __CreateBoolLocalValueInput = 0;
	}
}