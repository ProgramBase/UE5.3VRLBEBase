using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PyTestStructLibrary")]
	public partial class UPyTestStructLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PyTestStructLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetBoolMutableViaRef(ref FPyTestStruct InStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetBoolMutableViaRef, __InBuffer, __OutBuffer);

				InStruct = *(FPyTestStruct*)(__OutBuffer);

			}
		}

		public static void SetBoolMutable(FPyTestStruct InStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBoolMutable, __InBuffer);
			}
		}

		public static bool LegacyIsBoolSet(FPyTestStruct InStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LegacyIsBoolSet, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsBoolSet(FPyTestStruct InStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsBoolSet, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static int GetConstantValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetConstantValue, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void ClearBoolMutableViaRef(ref FPyTestStruct InStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ClearBoolMutableViaRef, __InBuffer, __OutBuffer);

				InStruct = *(FPyTestStruct*)(__OutBuffer);

			}
		}

		public static void ClearBoolMutable(FPyTestStruct InStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearBoolMutable, __InBuffer);
			}
		}

		public static FPyTestStruct AddStr(FPyTestStruct InStruct, FString InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddStr, __InBuffer, __ReturnBuffer);

				return *(FPyTestStruct*)__ReturnBuffer;
			}
		}

		public static FPyTestStruct AddInt(FPyTestStruct InStruct, int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InValue;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddInt, __InBuffer, __ReturnBuffer);

				return *(FPyTestStruct*)__ReturnBuffer;
			}
		}

		public static FPyTestStruct AddFloat(FPyTestStruct InStruct, float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InValue;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddFloat, __InBuffer, __ReturnBuffer);

				return *(FPyTestStruct*)__ReturnBuffer;
			}
		}

		private static uint __SetBoolMutableViaRef = 0;

		private static uint __SetBoolMutable = 0;

		private static uint __LegacyIsBoolSet = 0;

		private static uint __IsBoolSet = 0;

		private static uint __GetConstantValue = 0;

		private static uint __ClearBoolMutableViaRef = 0;

		private static uint __ClearBoolMutable = 0;

		private static uint __AddStr = 0;

		private static uint __AddInt = 0;

		private static uint __AddFloat = 0;
	}
}