using Script.CoreUObject;
using Script.Library;
using Script.AudioExtensions;

namespace Script.Engine
{
	[PathName("/Script/Engine.AudioParameterConversionStatics")]
	public partial class UAudioParameterConversionStatics : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AudioParameterConversionStatics");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FAudioParameter StringToAudioParameter(FName Name, FString String)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = String?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __StringToAudioParameter, __InBuffer, __ReturnBuffer);

				return *(FAudioParameter*)__ReturnBuffer;
			}
		}

		public static FAudioParameter StringArrayToAudioParameter(FName Name, TArray<FString> Strings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Strings?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __StringArrayToAudioParameter, __InBuffer, __ReturnBuffer);

				return *(FAudioParameter*)__ReturnBuffer;
			}
		}

		public static FAudioParameter ObjectToAudioParameter(FName Name, UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ObjectToAudioParameter, __InBuffer, __ReturnBuffer);

				return *(FAudioParameter*)__ReturnBuffer;
			}
		}

		public static FAudioParameter ObjectArrayToAudioParameter(FName Name, TArray<UObject> Objects)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Objects?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ObjectArrayToAudioParameter, __InBuffer, __ReturnBuffer);

				return *(FAudioParameter*)__ReturnBuffer;
			}
		}

		public static FAudioParameter IntegerToAudioParameter(FName Name, int Integer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Integer;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __IntegerToAudioParameter, __InBuffer, __ReturnBuffer);

				return *(FAudioParameter*)__ReturnBuffer;
			}
		}

		public static FAudioParameter IntegerArrayToAudioParameter(FName Name, TArray<int> Integers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Integers?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __IntegerArrayToAudioParameter, __InBuffer, __ReturnBuffer);

				return *(FAudioParameter*)__ReturnBuffer;
			}
		}

		public static FAudioParameter FloatToAudioParameter(FName Name, float Float)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Float;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FloatToAudioParameter, __InBuffer, __ReturnBuffer);

				return *(FAudioParameter*)__ReturnBuffer;
			}
		}

		public static FAudioParameter FloatArrayToAudioParameter(FName Name, TArray<float> Floats)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Floats?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FloatArrayToAudioParameter, __InBuffer, __ReturnBuffer);

				return *(FAudioParameter*)__ReturnBuffer;
			}
		}

		public static FAudioParameter BooleanToAudioParameter(FName Name, bool Bool)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Bool;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BooleanToAudioParameter, __InBuffer, __ReturnBuffer);

				return *(FAudioParameter*)__ReturnBuffer;
			}
		}

		public static FAudioParameter BooleanArrayToAudioParameter(FName Name, TArray<bool> Bools)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Bools?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BooleanArrayToAudioParameter, __InBuffer, __ReturnBuffer);

				return *(FAudioParameter*)__ReturnBuffer;
			}
		}

		private static uint __StringToAudioParameter = 0;

		private static uint __StringArrayToAudioParameter = 0;

		private static uint __ObjectToAudioParameter = 0;

		private static uint __ObjectArrayToAudioParameter = 0;

		private static uint __IntegerToAudioParameter = 0;

		private static uint __IntegerArrayToAudioParameter = 0;

		private static uint __FloatToAudioParameter = 0;

		private static uint __FloatArrayToAudioParameter = 0;

		private static uint __BooleanToAudioParameter = 0;

		private static uint __BooleanArrayToAudioParameter = 0;
	}
}