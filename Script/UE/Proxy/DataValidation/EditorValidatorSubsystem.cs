using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.DataValidation
{
	[PathName("/Script/DataValidation.EditorValidatorSubsystem")]
	public partial class UEditorValidatorSubsystem : UEditorSubsystem, IStaticClass
	{
		public TArray<FDirectoryPath> ExcludedDirectories
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludedDirectories, __ReturnBuffer);

					return *(TArray<FDirectoryPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludedDirectories, __InBuffer);
				}
			}
		}

		public bool bValidateOnSave
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bValidateOnSave, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bValidateOnSave, __InBuffer);
				}
			}
		}

		public TMap<FString, UEditorValidatorBase> Validators
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Validators, __ReturnBuffer);

					return *(TMap<FString, UEditorValidatorBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Validators, __InBuffer);
				}
			}
		}

		public bool bValidateAssetsWhileSavingForCook
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bValidateAssetsWhileSavingForCook, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bValidateAssetsWhileSavingForCook, __InBuffer);
				}
			}
		}

		public bool bAllowBlueprintValidators
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowBlueprintValidators, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowBlueprintValidators, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataValidation.EditorValidatorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InSettings">
		/// Structure passing context and settings for ValidateAssetsWithSettings
		/// </param>
		/// <param name="OutResults">
		/// More detailed information about the results of the validate assets command
		/// </param>
		/// <returns>
		/// Number of assets with validation failures or warnings
		/// </returns>
		public virtual int ValidateAssetsWithSettings(TArray<FAssetData> AssetDataList, FValidateAssetsSettings InSettings, ref FValidateAssetsResults OutResults)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AssetDataList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutResults?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __ValidateAssetsWithSettings, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResults = *(FValidateAssetsResults*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int ValidateAssets(TArray<FAssetData> AssetDataList, bool bSkipExcludedDirectories = true, bool bShowIfNoFailures = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = AssetDataList?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSkipExcludedDirectories;

				*(bool*)(__InBuffer + 9) = bShowIfNoFailures;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ValidateAssets, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Returns Valid if the object contains valid data; returns Invalid if the object contains invalid data; returns NotValidated if no validations was performed on the object
		/// </returns>
		public virtual EDataValidationResult IsObjectValid(UObject InObject, ref TArray<FText> ValidationErrors, ref TArray<FText> ValidationWarnings, EDataValidationUsecase InValidationUsecase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ValidationErrors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ValidationWarnings?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)InValidationUsecase;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __IsObjectValid, __InBuffer, __OutBuffer, __ReturnBuffer);

				ValidationErrors = *(TArray<FText>*)(__OutBuffer);

				ValidationWarnings = *(TArray<FText>*)(__OutBuffer + 8);

				return *(EDataValidationResult*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Returns Valid if the object pointed to by AssetData contains valid data; returns Invalid if the object contains invalid data or does not exist; returns NotValidated if no validations was performed on the object
		/// </returns>
		public virtual EDataValidationResult IsAssetValid(FAssetData AssetData, ref TArray<FText> ValidationErrors, ref TArray<FText> ValidationWarnings, EDataValidationUsecase InValidationUsecase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = AssetData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ValidationErrors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ValidationWarnings?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)InValidationUsecase;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __IsAssetValid, __InBuffer, __OutBuffer, __ReturnBuffer);

				ValidationErrors = *(TArray<FText>*)(__OutBuffer);

				ValidationWarnings = *(TArray<FText>*)(__OutBuffer + 8);

				return *(EDataValidationResult*)__ReturnBuffer;
			}
		}

		public virtual void AddValidator(UEditorValidatorBase InValidator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValidator?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddValidator, __InBuffer);
			}
		}

		private static uint __ExcludedDirectories = 0;

		private static uint __bValidateOnSave = 0;

		private static uint __Validators = 0;

		private static uint __bValidateAssetsWhileSavingForCook = 0;

		private static uint __bAllowBlueprintValidators = 0;

		private static uint __ValidateAssetsWithSettings = 0;

		private static uint __ValidateAssets = 0;

		private static uint __IsObjectValid = 0;

		private static uint __IsAssetValid = 0;

		private static uint __AddValidator = 0;
	}
}