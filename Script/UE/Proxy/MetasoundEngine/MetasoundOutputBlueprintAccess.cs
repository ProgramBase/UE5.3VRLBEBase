using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetasoundOutputBlueprintAccess")]
	public partial class UMetasoundOutputBlueprintAccess : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEngine.MetasoundOutputBlueprintAccess");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool IsTime(FMetaSoundOutput Output)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Output?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsTime, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsString(FMetaSoundOutput Output)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Output?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsString, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsInt32(FMetaSoundOutput Output)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Output?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsInt32, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsFloat(FMetaSoundOutput Output)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Output?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsFloat, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsBool(FMetaSoundOutput Output)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Output?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static float GetTimeSeconds(FMetaSoundOutput Output, ref bool Success)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Output?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Success;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetTimeSeconds, __InBuffer, __OutBuffer, __ReturnBuffer);

				Success = *(bool*)(__OutBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static FString GetString(FMetaSoundOutput Output, ref bool Success)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Output?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Success;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __GetString, __InBuffer, __OutBuffer, __ReturnBuffer);

				Success = *(bool*)(__OutBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static int GetInt32(FMetaSoundOutput Output, ref bool Success)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Output?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Success;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetInt32, __InBuffer, __OutBuffer, __ReturnBuffer);

				Success = *(bool*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static float GetFloat(FMetaSoundOutput Output, ref bool Success)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Output?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Success;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetFloat, __InBuffer, __OutBuffer, __ReturnBuffer);

				Success = *(bool*)(__OutBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static bool GetBool(FMetaSoundOutput Output, ref bool Success)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Output?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Success;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetBool, __InBuffer, __OutBuffer, __ReturnBuffer);

				Success = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __IsTime = 0;

		private static uint __IsString = 0;

		private static uint __IsInt32 = 0;

		private static uint __IsFloat = 0;

		private static uint __IsBool = 0;

		private static uint __GetTimeSeconds = 0;

		private static uint __GetString = 0;

		private static uint __GetInt32 = 0;

		private static uint __GetFloat = 0;

		private static uint __GetBool = 0;
	}
}