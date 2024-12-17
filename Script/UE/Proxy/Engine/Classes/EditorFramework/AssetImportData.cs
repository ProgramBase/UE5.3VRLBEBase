using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AssetImportData")]
	public partial class UAssetImportData : UObject, IStaticClass
	{
		public FAssetImportInfo SourceData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceData, __ReturnBuffer);

					return *(FAssetImportInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AssetImportData");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InPath">
		/// : The filename we want to set at the specified index.
		/// </param>
		/// <param name="Index">
		/// : This specify the source file index in case you have many source file for an imported asset
		/// </param>
		/// <param name="SourceFileLabel">
		/// : Optional, can be empty string, the label we want to see in the UI when displaying the source file. (useful for multi source)
		/// </param>
		public virtual void ScriptedAddFilename(FString InPath, int Index, FString SourceFileLabel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(nint*)(__InBuffer + 12) = SourceFileLabel?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScriptedAddFilename, __InBuffer);
			}
		}

		public virtual FString K2_GetFirstFilename()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __K2_GetFirstFilename, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual TArray<FString> K2_ExtractFilenames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __K2_ExtractFilenames, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		private static uint __SourceData = 0;

		private static uint __ScriptedAddFilename = 0;

		private static uint __K2_GetFirstFilename = 0;

		private static uint __K2_ExtractFilenames = 0;
	}
}