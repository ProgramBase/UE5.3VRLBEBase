using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundParameterPack")]
	public partial class UMetasoundParameterPack : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundFrontend.MetasoundParameterPack");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual ESetParamResult SetTrigger(FName ParameterName, bool OnlyIfExists = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = OnlyIfExists;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetTrigger, __InBuffer, __ReturnBuffer);

				return *(ESetParamResult*)__ReturnBuffer;
			}
		}

		public virtual ESetParamResult SetString(FName ParameterName, FString InValue, bool OnlyIfExists = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = OnlyIfExists;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetString, __InBuffer, __ReturnBuffer);

				return *(ESetParamResult*)__ReturnBuffer;
			}
		}

		public virtual ESetParamResult SetInt(FName ParameterName, int InValue, bool OnlyIfExists = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InValue;

				*(bool*)(__InBuffer + 12) = OnlyIfExists;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetInt, __InBuffer, __ReturnBuffer);

				return *(ESetParamResult*)__ReturnBuffer;
			}
		}

		public virtual ESetParamResult SetFloat(FName ParameterName, float InValue, bool OnlyIfExists = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InValue;

				*(bool*)(__InBuffer + 12) = OnlyIfExists;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetFloat, __InBuffer, __ReturnBuffer);

				return *(ESetParamResult*)__ReturnBuffer;
			}
		}

		public virtual ESetParamResult SetBool(FName ParameterName, bool InValue, bool OnlyIfExists = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = InValue;

				*(bool*)(__InBuffer + 9) = OnlyIfExists;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetBool, __InBuffer, __ReturnBuffer);

				return *(ESetParamResult*)__ReturnBuffer;
			}
		}

		public static UMetasoundParameterPack MakeMetasoundParameterPack()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __MakeMetasoundParameterPack, __ReturnBuffer);

				return *(UMetasoundParameterPack*)__ReturnBuffer;
			}
		}

		public virtual bool HasTrigger(FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasTrigger, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasString(FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasString, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasInt(FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasInt, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasFloat(FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasFloat, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasBool(FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetTrigger(FName ParameterName, ref ESetParamResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetTrigger, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(ESetParamResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FString GetString(FName ParameterName, ref ESetParamResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __GetString, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(ESetParamResult*)(__OutBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual int GetInt(FName ParameterName, ref ESetParamResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetInt, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(ESetParamResult*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual float GetFloat(FName ParameterName, ref ESetParamResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetFloat, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(ESetParamResult*)(__OutBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual bool GetBool(FName ParameterName, ref ESetParamResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetBool, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(ESetParamResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetTrigger = 0;

		private static uint __SetString = 0;

		private static uint __SetInt = 0;

		private static uint __SetFloat = 0;

		private static uint __SetBool = 0;

		private static uint __MakeMetasoundParameterPack = 0;

		private static uint __HasTrigger = 0;

		private static uint __HasString = 0;

		private static uint __HasInt = 0;

		private static uint __HasFloat = 0;

		private static uint __HasBool = 0;

		private static uint __GetTrigger = 0;

		private static uint __GetString = 0;

		private static uint __GetInt = 0;

		private static uint __GetFloat = 0;

		private static uint __GetBool = 0;
	}
}