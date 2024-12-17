using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FPolyglotTextData
	{
		public FPolyglotTextData(ELocalizedTextSourceCategory InCategory, FString InNamespace, FString InKey, FString InNativeString, FString InNativeCulture)
		{
			if (GetType() == typeof(FPolyglotTextData))
			{
				FPolyglotTextDataImplementation.FPolyglotTextData_FPolyglotTextDataImplementation(this, InCategory, InNamespace?.GarbageCollectionHandle ?? nint.Zero, InKey?.GarbageCollectionHandle ?? nint.Zero, InNativeString?.GarbageCollectionHandle ?? nint.Zero, InNativeCulture?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public void SetCategory(ELocalizedTextSourceCategory InCategory)
		{
			FPolyglotTextDataImplementation.FPolyglotTextData_SetCategoryImplementation(GarbageCollectionHandle, InCategory);
		}

		public ELocalizedTextSourceCategory GetCategory()
		{
			return (ELocalizedTextSourceCategory)FPolyglotTextDataImplementation.FPolyglotTextData_GetCategoryImplementation(GarbageCollectionHandle);
		}

		public void SetCategory(FString InNativeCulture)
		{
			FPolyglotTextDataImplementation.FPolyglotTextData_SetCategory1Implementation(GarbageCollectionHandle, InNativeCulture?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FString GetNativeCulture()
		{
			return FPolyglotTextDataImplementation.FPolyglotTextData_GetNativeCultureImplementation(GarbageCollectionHandle) as FString;
		}

		public FString ResolveNativeCulture()
		{
			return FPolyglotTextDataImplementation.FPolyglotTextData_ResolveNativeCultureImplementation(GarbageCollectionHandle) as FString;
		}

		public TArray<FString> GetLocalizedCultures()
		{
			return FPolyglotTextDataImplementation.FPolyglotTextData_GetLocalizedCulturesImplementation(GarbageCollectionHandle) as TArray<FString>;
		}

		public void SetIdentity(FString InNamespace, FString InKey)
		{
			FPolyglotTextDataImplementation.FPolyglotTextData_SetIdentityImplementation(GarbageCollectionHandle, InNamespace?.GarbageCollectionHandle ?? nint.Zero, InKey?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void GetIdentity(ref FString OutNamespace, ref FString OutKey)
		{
			FPolyglotTextDataImplementation.FPolyglotTextData_GetIdentityImplementation(GarbageCollectionHandle, out var __OutValue, OutNamespace?.GarbageCollectionHandle ?? nint.Zero, OutKey?.GarbageCollectionHandle ?? nint.Zero);

			OutNamespace = __OutValue[0] as FString;

			OutKey = __OutValue[1] as FString;
		}

		public FString GetNamespace()
		{
			return FPolyglotTextDataImplementation.FPolyglotTextData_GetNamespaceImplementation(GarbageCollectionHandle) as FString;
		}

		public FString GetKey()
		{
			return FPolyglotTextDataImplementation.FPolyglotTextData_GetKeyImplementation(GarbageCollectionHandle) as FString;
		}

		public void SetNativeString(FString InNativeString)
		{
			FPolyglotTextDataImplementation.FPolyglotTextData_SetNativeStringImplementation(GarbageCollectionHandle, InNativeString?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FString GetNativeString()
		{
			return FPolyglotTextDataImplementation.FPolyglotTextData_GetNativeStringImplementation(GarbageCollectionHandle) as FString;
		}

		public void AddLocalizedString(FString InCulture, FString InLocalizedString)
		{
			FPolyglotTextDataImplementation.FPolyglotTextData_AddLocalizedStringImplementation(GarbageCollectionHandle, InCulture?.GarbageCollectionHandle ?? nint.Zero, InLocalizedString?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void RemoveLocalizedString(FString InCulture)
		{
			FPolyglotTextDataImplementation.FPolyglotTextData_RemoveLocalizedStringImplementation(GarbageCollectionHandle, InCulture?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool GetLocalizedString(FString InCulture, ref FString OutLocalizedString)
		{
			var __ReturnValue = FPolyglotTextDataImplementation.FPolyglotTextData_GetLocalizedStringImplementation(GarbageCollectionHandle, out var __OutValue, InCulture?.GarbageCollectionHandle ?? nint.Zero, OutLocalizedString?.GarbageCollectionHandle ?? nint.Zero);

			OutLocalizedString = __OutValue[0] as FString;

			return (bool)__ReturnValue;
		}

		public void ClearLocalizedStrings()
		{
			FPolyglotTextDataImplementation.FPolyglotTextData_ClearLocalizedStringsImplementation(GarbageCollectionHandle);
		}

		public void IsMinimalPatch(bool InCulture)
		{
			FPolyglotTextDataImplementation.FPolyglotTextData_IsMinimalPatchImplementation(GarbageCollectionHandle, InCulture);
		}

		public bool IsMinimalPatch()
		{
			return (bool)FPolyglotTextDataImplementation.FPolyglotTextData_IsMinimalPatch1Implementation(GarbageCollectionHandle);
		}

		public FText GetText()
		{
			return FPolyglotTextDataImplementation.FPolyglotTextData_GetTextImplementation(GarbageCollectionHandle) as FText;
		}
	}
}