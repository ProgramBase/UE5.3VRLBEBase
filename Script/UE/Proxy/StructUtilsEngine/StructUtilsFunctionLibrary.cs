using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.StructUtils;

namespace Script.StructUtilsEngine
{
	[PathName("/Script/StructUtilsEngine.StructUtilsFunctionLibrary")]
	public partial class UStructUtilsFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StructUtilsEngine.StructUtilsFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetInstancedStructValue(ref FInstancedStruct InstancedStruct, int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InstancedStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Value;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetInstancedStructValue, __InBuffer, __OutBuffer);

				InstancedStruct = *(FInstancedStruct*)(__OutBuffer);

			}
		}

		public static void Reset(ref FInstancedStruct InstancedStruct, UScriptStruct StructType = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InstancedStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StructType?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Reset, __InBuffer, __OutBuffer);

				InstancedStruct = *(FInstancedStruct*)(__OutBuffer);

			}
		}

		public static bool NotEqual_InstancedStruct(FInstancedStruct A, FInstancedStruct B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_InstancedStruct, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FInstancedStruct MakeInstancedStruct(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeInstancedStruct, __InBuffer, __ReturnBuffer);

				return *(FInstancedStruct*)__ReturnBuffer;
			}
		}

		public static bool IsValid_InstancedStruct(FInstancedStruct InstancedStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InstancedStruct?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValid_InstancedStruct, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static EStructUtilsResult IsInstancedStructValid(FInstancedStruct InstancedStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InstancedStruct?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsInstancedStructValid, __InBuffer, __ReturnBuffer);

				return *(EStructUtilsResult*)__ReturnBuffer;
			}
		}

		public static void GetInstancedStructValue(ref EStructUtilsResult ExecResult, FInstancedStruct InstancedStruct, ref int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(byte*)(__InBuffer) = (byte)ExecResult;

				*(nint*)(__InBuffer + 1) = InstancedStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 9) = Value;

				var __OutBuffer = stackalloc byte[5];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetInstancedStructValue, __InBuffer, __OutBuffer);

				ExecResult = *(EStructUtilsResult*)(__OutBuffer);

				Value = *(int*)(__OutBuffer + 1);

			}
		}

		public static bool EqualEqual_InstancedStruct(FInstancedStruct A, FInstancedStruct B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_InstancedStruct, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetInstancedStructValue = 0;

		private static uint __Reset = 0;

		private static uint __NotEqual_InstancedStruct = 0;

		private static uint __MakeInstancedStruct = 0;

		private static uint __IsValid_InstancedStruct = 0;

		private static uint __IsInstancedStructValid = 0;

		private static uint __GetInstancedStructValue = 0;

		private static uint __EqualEqual_InstancedStruct = 0;
	}
}