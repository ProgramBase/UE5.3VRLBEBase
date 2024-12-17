using Script.CoreUObject;
using Script.Library;
using Script.InterchangeCore;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangeFilePickerBase")]
	public partial class UInterchangeFilePickerBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEngine.InterchangeFilePickerBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool ScriptedFilePickerForTranslatorType(EInterchangeTranslatorType TranslatorType, ref FInterchangeFilePickerParameters Parameters, ref TArray<FString> OutFilenames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(byte*)(__InBuffer) = (byte)TranslatorType;

				*(nint*)(__InBuffer + 1) = Parameters?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = OutFilenames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __ScriptedFilePickerForTranslatorType, __InBuffer, __OutBuffer, __ReturnBuffer);

				Parameters = *(FInterchangeFilePickerParameters*)(__OutBuffer);

				OutFilenames = *(TArray<FString>*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ScriptedFilePickerForTranslatorAssetType(EInterchangeTranslatorAssetType TranslatorAssetType, ref FInterchangeFilePickerParameters Parameters, ref TArray<FString> OutFilenames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(byte*)(__InBuffer) = (byte)TranslatorAssetType;

				*(nint*)(__InBuffer + 1) = Parameters?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = OutFilenames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __ScriptedFilePickerForTranslatorAssetType, __InBuffer, __OutBuffer, __ReturnBuffer);

				Parameters = *(FInterchangeFilePickerParameters*)(__OutBuffer);

				OutFilenames = *(TArray<FString>*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __ScriptedFilePickerForTranslatorType = 0;

		private static uint __ScriptedFilePickerForTranslatorAssetType = 0;
	}
}