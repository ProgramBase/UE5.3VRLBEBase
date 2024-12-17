using Script.CoreUObject;
using Script.Library;

namespace Script.DataValidation
{
	[PathName("/Script/DataValidation.EditorValidatorBase")]
	public partial class UEditorValidatorBase : UObject, IStaticClass
	{
		public bool bIsEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabled, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataValidation.EditorValidatorBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual EDataValidationResult ValidateLoadedAsset(UObject InAsset, ref TArray<FText> ValidationErrors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ValidationErrors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __ValidateLoadedAsset, __InBuffer, __OutBuffer, __ReturnBuffer);

				ValidationErrors = *(TArray<FText>*)(__OutBuffer);

				return *(EDataValidationResult*)__ReturnBuffer;
			}
		}

		public virtual EDataValidationResult GetValidationResult()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetValidationResult, __ReturnBuffer);

				return *(EDataValidationResult*)__ReturnBuffer;
			}
		}

		public virtual bool CanValidateAsset(UObject InAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanValidateAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanValidate(EDataValidationUsecase InUsecase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InUsecase;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanValidate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void AssetWarning(UObject InAsset, FText InMessage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMessage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AssetWarning, __InBuffer);
			}
		}

		public virtual void AssetPasses(UObject InAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAsset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AssetPasses, __InBuffer);
			}
		}

		public virtual void AssetFails(UObject InAsset, FText InMessage, ref TArray<FText> ValidationErrors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMessage?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ValidationErrors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __AssetFails, __InBuffer, __OutBuffer);

				ValidationErrors = *(TArray<FText>*)(__OutBuffer);

			}
		}

		private static uint __bIsEnabled = 0;

		private static uint __ValidateLoadedAsset = 0;

		private static uint __GetValidationResult = 0;

		private static uint __CanValidateAsset = 0;

		private static uint __CanValidate = 0;

		private static uint __AssetWarning = 0;

		private static uint __AssetPasses = 0;

		private static uint __AssetFails = 0;
	}
}