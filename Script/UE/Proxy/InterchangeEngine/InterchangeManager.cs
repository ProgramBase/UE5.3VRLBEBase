using Script.CoreUObject;
using Script.Library;
using Script.InterchangeCore;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangeManager")]
	public partial class UInterchangeManager : UObject, IStaticClass
	{
		public TSet<TSubclassOf<UObject>> RegisteredTranslatorsClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredTranslatorsClass, __ReturnBuffer);

					return *(TSet<TSubclassOf<UObject>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredTranslatorsClass, __InBuffer);
				}
			}
		}

		public TMap<TSubclassOf<UObject>, TSubclassOf<UObject>> RegisteredFactoryClasses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredFactoryClasses, __ReturnBuffer);

					return *(TMap<TSubclassOf<UObject>, TSubclassOf<UObject>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredFactoryClasses, __InBuffer);
				}
			}
		}

		public TMap<TSubclassOf<UObject>, UInterchangeWriterBase> RegisteredWriters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredWriters, __ReturnBuffer);

					return *(TMap<TSubclassOf<UObject>, UInterchangeWriterBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredWriters, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEngine.InterchangeManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="ContentPath">
		/// - The content path where to import the assets
		/// </param>
		/// <param name="SourceData">
		/// - The source data input we want to translate, this object will be duplicate to allow multithread safe operations
		/// </param>
		/// <param name="ImportAssetParameters">
		/// - All import asset parameter we need to pass to the import asset function
		/// </param>
		/// <returns>
		/// true if the import succeed, false otherwise.
		/// </returns>
		public virtual bool ImportScene(FString ContentPath, UInterchangeSourceData SourceData, FImportAssetParameters ImportAssetParameters)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ContentPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ImportAssetParameters?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ImportScene, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="ContentPath">
		/// - The content path where to import the assets
		/// </param>
		/// <param name="SourceData">
		/// - The source data input we want to translate
		/// </param>
		/// <param name="ImportAssetParameters">
		/// - All import asset parameter we need to pass to the import asset function
		/// </param>
		/// <returns>
		/// true if the import succeed, false otherwise.
		/// </returns>
		public virtual bool ImportAsset(FString ContentPath, UInterchangeSourceData SourceData, FImportAssetParameters ImportAssetParameters)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ContentPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ImportAssetParameters?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ImportAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="FactoryClass">
		/// : The class we search a registerd factory
		/// </param>
		/// <returns>
		/// : if found, we return the factory class that is registered. Return NULL if nothing found.
		/// </returns>
		public virtual UClass GetRegisteredFactoryClass(UClass ClassToMake)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ClassToMake?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRegisteredFactoryClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		/// <note>
		/// - We need to return a pointer to have a valid Blueprint callable function
		/// </note>
		public static UInterchangeManager GetInterchangeManagerScripted()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetInterchangeManagerScripted, __ReturnBuffer);

				return *(UInterchangeManager*)__ReturnBuffer;
			}
		}

		/// <param name="SourceData">
		/// - The source data input we want to translate
		/// </param>
		/// <param name="bIsAutomated">
		/// - If true the import asset will not show any UI or dialog
		/// </param>
		/// <returns>
		/// true if the import succeed, false otherwise.
		/// </returns>
		public virtual bool ExportScene(UObject World, bool bIsAutomated = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsAutomated;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ExportScene, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SourceData">
		/// - The source data output 
		/// </param>
		/// <param name="bIsAutomated">
		/// - If true the exporter will not show any UI or dialog
		/// </param>
		/// <returns>
		/// true if the import succeed, false otherwise.
		/// </returns>
		public virtual bool ExportAsset(UObject Asset, bool bIsAutomated = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsAutomated;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ExportAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InFilename">
		/// : Specify a file on disk
		/// </param>
		/// <returns>
		/// : A new UInterchangeSourceData.
		/// </returns>
		public static UInterchangeSourceData CreateSourceData(FString InFileName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFileName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateSourceData, __InBuffer, __ReturnBuffer);

				return *(UInterchangeSourceData*)__ReturnBuffer;
			}
		}

		private static uint __RegisteredTranslatorsClass = 0;

		private static uint __RegisteredFactoryClasses = 0;

		private static uint __RegisteredWriters = 0;

		private static uint __ImportScene = 0;

		private static uint __ImportAsset = 0;

		private static uint __GetRegisteredFactoryClass = 0;

		private static uint __GetInterchangeManagerScripted = 0;

		private static uint __ExportScene = 0;

		private static uint __ExportAsset = 0;

		private static uint __CreateSourceData = 0;
	}
}