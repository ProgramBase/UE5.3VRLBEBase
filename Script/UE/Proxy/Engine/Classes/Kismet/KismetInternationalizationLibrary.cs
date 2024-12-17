using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KismetInternationalizationLibrary")]
	public partial class UKismetInternationalizationLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KismetInternationalizationLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <note>
		/// Unless you're doing something advanced, you likely want SetCurrentLanguageAndLocale or SetCurrentCulture instead.
		/// </note>
		/// <param name="Culture">
		/// The locale to set, as an IETF language tag (eg, "zh-Hans-CN").
		/// </param>
		/// <param name="SaveToConfig">
		/// If true, save the new setting to the users' "GameUserSettings" config so that it persists after a reload.
		/// </param>
		/// <returns>
		/// True if the locale was set, false otherwise.
		/// </returns>
		public static bool SetCurrentLocale(FString Culture, bool SaveToConfig = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Culture?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = SaveToConfig;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetCurrentLocale, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Culture">
		/// The language and locale to set, as an IETF language tag (eg, "zh-Hans-CN").
		/// </param>
		/// <param name="SaveToConfig">
		/// If true, save the new setting to the users' "GameUserSettings" config so that it persists after a reload.
		/// </param>
		/// <returns>
		/// True if the language and locale were set, false otherwise.
		/// </returns>
		public static bool SetCurrentLanguageAndLocale(FString Culture, bool SaveToConfig = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Culture?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = SaveToConfig;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetCurrentLanguageAndLocale, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Unless you're doing something advanced, you likely want SetCurrentLanguageAndLocale or SetCurrentCulture instead.
		/// </note>
		/// <param name="Culture">
		/// The language to set, as an IETF language tag (eg, "zh-Hans-CN").
		/// </param>
		/// <param name="SaveToConfig">
		/// If true, save the new setting to the users' "GameUserSettings" config so that it persists after a reload.
		/// </param>
		/// <returns>
		/// True if the language was set, false otherwise.
		/// </returns>
		public static bool SetCurrentLanguage(FString Culture, bool SaveToConfig = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Culture?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = SaveToConfig;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetCurrentLanguage, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// This function is a sledgehammer, and will set both the language and locale, as well as clear out any asset group cultures that may be set.
		/// </note>
		/// <param name="Culture">
		/// The culture to set, as an IETF language tag (eg, "zh-Hans-CN").
		/// </param>
		/// <param name="SaveToConfig">
		/// If true, save the new setting to the users' "GameUserSettings" config so that it persists after a reload.
		/// </param>
		/// <returns>
		/// True if the culture was set, false otherwise.
		/// </returns>
		public static bool SetCurrentCulture(FString Culture, bool SaveToConfig = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Culture?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = SaveToConfig;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetCurrentCulture, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetGroup">
		/// The asset group to set the culture for.
		/// </param>
		/// <param name="Culture">
		/// The culture to set, as an IETF language tag (eg, "zh-Hans-CN").
		/// </param>
		/// <param name="SaveToConfig">
		/// If true, save the new setting to the users' "GameUserSettings" config so that it persists after a reload.
		/// </param>
		/// <returns>
		/// True if the culture was set, false otherwise.
		/// </returns>
		public static bool SetCurrentAssetGroupCulture(FName AssetGroup, FString Culture, bool SaveToConfig = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = AssetGroup?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Culture?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = SaveToConfig;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetCurrentAssetGroupCulture, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AvailableCultures">
		/// List of available cultures to filter against (see GetLocalizedCultures).
		/// </param>
		/// <param name="CultureToMatch">
		/// Culture to try and match (see GetCurrentLanguage).
		/// </param>
		/// <param name="FallbackCulture">
		/// The culture to return if there is no suitable match in the list (typically your native culture, see GetNativeCulture).
		/// </param>
		/// <returns>
		/// The culture as an IETF language tag (eg, "zh-Hans-CN").
		/// </returns>
		public static FString GetSuitableCulture(TArray<FString> AvailableCultures, FString CultureToMatch, FString FallbackCulture = null)
		{
			unsafe
			{
				FallbackCulture ??= new FString("en");

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AvailableCultures?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CultureToMatch?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FallbackCulture?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSuitableCulture, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Category">
		/// The localization category to query.
		/// </param>
		/// <returns>
		/// The culture as an IETF language tag (eg, "zh-Hans-CN").
		/// </returns>
		public static FString GetNativeCulture(ELocalizedTextSourceCategory TextCategory)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)TextCategory;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNativeCulture, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="IncludeGame">
		/// Check for localized game resources.
		/// </param>
		/// <param name="IncludeEngine">
		/// Check for localized engine resources.
		/// </param>
		/// <param name="IncludeEditor">
		/// Check for localized editor resources.
		/// </param>
		/// <param name="IncludeAdditional">
		/// Check for localized additional (eg, plugin) resources.
		/// </param>
		/// <returns>
		/// The list of cultures as IETF language tags (eg, "zh-Hans-CN").
		/// </returns>
		public static TArray<FString> GetLocalizedCultures(bool IncludeGame = true, bool IncludeEngine = false, bool IncludeEditor = false, bool IncludeAdditional = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(bool*)(__InBuffer) = IncludeGame;

				*(bool*)(__InBuffer + 1) = IncludeEngine;

				*(bool*)(__InBuffer + 2) = IncludeEditor;

				*(bool*)(__InBuffer + 3) = IncludeAdditional;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalizedCultures, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The locale as an IETF language tag (eg, "zh-Hans-CN").
		/// </returns>
		public static FString GetCurrentLocale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentLocale, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The language as an IETF language tag (eg, "zh-Hans-CN").
		/// </returns>
		public static FString GetCurrentLanguage()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentLanguage, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <note>
		/// This function exists for legacy API parity with SetCurrentCulture and is equivalent to GetCurrentLanguage.
		/// </note>
		/// <returns>
		/// The culture as an IETF language tag (eg, "zh-Hans-CN").
		/// </returns>
		public static FString GetCurrentCulture()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentCulture, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Returns the current language if the group category doesn't have a culture override.
		/// </note>
		/// <param name="AssetGroup">
		/// The asset group to get the culture for.
		/// </param>
		/// <returns>
		/// The culture as an IETF language tag (eg, "zh-Hans-CN").
		/// </returns>
		public static FString GetCurrentAssetGroupCulture(FName AssetGroup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetGroup?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentAssetGroupCulture, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Culture">
		/// The culture to get the display name of, as an IETF language tag (eg, "zh-Hans-CN")
		/// </param>
		/// <param name="Localized">
		/// True to get the localized display name (the name of the culture in its own language), or False to get the display name in the current language.
		/// </param>
		/// <returns>
		/// The display name of the culture, or the given culture code on failure.
		/// </returns>
		public static FString GetCultureDisplayName(FString Culture, bool Localized = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Culture?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Localized;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCultureDisplayName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AssetGroup">
		/// The asset group to clear the culture for.
		/// </param>
		/// <param name="SaveToConfig">
		/// If true, save the new setting to the users' "GameUserSettings" config so that it persists after a reload.
		/// </param>
		public static void ClearCurrentAssetGroupCulture(FName AssetGroup, bool SaveToConfig = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AssetGroup?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = SaveToConfig;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearCurrentAssetGroupCulture, __InBuffer);
			}
		}

		private static uint __SetCurrentLocale = 0;

		private static uint __SetCurrentLanguageAndLocale = 0;

		private static uint __SetCurrentLanguage = 0;

		private static uint __SetCurrentCulture = 0;

		private static uint __SetCurrentAssetGroupCulture = 0;

		private static uint __GetSuitableCulture = 0;

		private static uint __GetNativeCulture = 0;

		private static uint __GetLocalizedCultures = 0;

		private static uint __GetCurrentLocale = 0;

		private static uint __GetCurrentLanguage = 0;

		private static uint __GetCurrentCulture = 0;

		private static uint __GetCurrentAssetGroupCulture = 0;

		private static uint __GetCultureDisplayName = 0;

		private static uint __ClearCurrentAssetGroupCulture = 0;
	}
}