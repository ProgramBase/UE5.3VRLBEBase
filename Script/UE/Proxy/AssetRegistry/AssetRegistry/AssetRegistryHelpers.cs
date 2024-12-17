using Script.CoreUObject;
using Script.Library;

namespace Script.AssetRegistry
{
	[PathName("/Script/AssetRegistry.AssetRegistryHelpers")]
	public partial class UAssetRegistryHelpers : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetRegistry.AssetRegistryHelpers");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FSoftObjectPath ToSoftObjectPath(FAssetData InAssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ToSoftObjectPath, __InBuffer, __ReturnBuffer);

				return *(FSoftObjectPath*)__ReturnBuffer;
			}
		}

		public static FARFilter SetFilterTagsAndValues(FARFilter InFilter, TArray<FTagAndValue> InTagsAndValues)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTagsAndValues?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetFilterTagsAndValues, __InBuffer, __ReturnBuffer);

				return *(FARFilter*)__ReturnBuffer;
			}
		}

		public static bool IsValid(FAssetData InAssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsUAsset(FAssetData InAssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsUAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsRedirector(FAssetData InAssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsRedirector, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsAssetLoaded(FAssetData InAssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsAssetLoaded, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetTagValue(FAssetData InAssetData, FName InTagName, ref FString OutTagValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InAssetData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTagName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutTagValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetTagValue, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutTagValue = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString GetFullName(FAssetData InAssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetFullName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetExportTextName(FAssetData InAssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetExportTextName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static UClass GetClass(FAssetData InAssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public static void GetBlueprintAssets(FARFilter InFilter, ref TArray<FAssetData> OutAssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetBlueprintAssets, __InBuffer, __OutBuffer);

				OutAssetData = *(TArray<FAssetData>*)(__OutBuffer);

			}
		}

		public static TScriptInterface<IAssetRegistry> GetAssetRegistry()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAssetRegistry, __ReturnBuffer);

				return *(TScriptInterface<IAssetRegistry>*)__ReturnBuffer;
			}
		}

		public static UObject GetAsset(FAssetData InAssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAsset, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public static UClass FindAssetNativeClass(FAssetData AssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindAssetNativeClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		/// <param name="InAsset">
		/// The asset to create asset data for
		/// </param>
		/// <param name="bAllowBlueprintClass">
		/// By default trying to create asset data for a blueprint class will create one for the UBlueprint instead
		/// </param>
		public static FAssetData CreateAssetData(UObject InAsset, bool bAllowBlueprintClass = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAllowBlueprintClass;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateAssetData, __InBuffer, __ReturnBuffer);

				return *(FAssetData*)__ReturnBuffer;
			}
		}

		private static uint __ToSoftObjectPath = 0;

		private static uint __SetFilterTagsAndValues = 0;

		private static uint __IsValid = 0;

		private static uint __IsUAsset = 0;

		private static uint __IsRedirector = 0;

		private static uint __IsAssetLoaded = 0;

		private static uint __GetTagValue = 0;

		private static uint __GetFullName = 0;

		private static uint __GetExportTextName = 0;

		private static uint __GetClass = 0;

		private static uint __GetBlueprintAssets = 0;

		private static uint __GetAssetRegistry = 0;

		private static uint __GetAsset = 0;

		private static uint __FindAssetNativeClass = 0;

		private static uint __CreateAssetData = 0;
	}
}