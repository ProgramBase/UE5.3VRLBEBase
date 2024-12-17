using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.ContentBrowserDataSubsystem")]
	public partial class UContentBrowserDataSubsystem : UEditorSubsystem, IStaticClass
	{
		public TArray<FName> EnabledDataSources
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnabledDataSources, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnabledDataSources, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowserData.ContentBrowserDataSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual TArray<FContentBrowserItem> GetItemsUnderPath(FName InPath, FContentBrowserDataFilter InFilter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InFilter?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetItemsUnderPath, __InBuffer, __ReturnBuffer);

				return *(TArray<FContentBrowserItem>*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Multiple items may have the same virtual path if they are different types, or come from different data sources.
		/// </note>
		public virtual TArray<FContentBrowserItem> GetItemsAtPath(FName InPath, EContentBrowserItemTypeFilter InItemTypeFilter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InItemTypeFilter;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetItemsAtPath, __InBuffer, __ReturnBuffer);

				return *(TArray<FContentBrowserItem>*)__ReturnBuffer;
			}
		}

		public virtual FContentBrowserItem GetItemAtPath(FName InPath, EContentBrowserItemTypeFilter InItemTypeFilter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InItemTypeFilter;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetItemAtPath, __InBuffer, __ReturnBuffer);

				return *(FContentBrowserItem*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> GetAvailableDataSources()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAvailableDataSources, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> GetActiveDataSources()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActiveDataSources, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the data source was available and active, false otherwise.
		/// </returns>
		public virtual bool DeactivateDataSource(FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DeactivateDataSource, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void DeactivateAllDataSources()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DeactivateAllDataSources);
			}
		}

		/// <returns>
		/// True if the data source was available and not already active, false otherwise.
		/// </returns>
		public virtual bool ActivateDataSource(FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ActivateDataSource, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ActivateAllDataSources()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ActivateAllDataSources);
			}
		}

		private static uint __EnabledDataSources = 0;

		private static uint __GetItemsUnderPath = 0;

		private static uint __GetItemsAtPath = 0;

		private static uint __GetItemAtPath = 0;

		private static uint __GetAvailableDataSources = 0;

		private static uint __GetActiveDataSources = 0;

		private static uint __DeactivateDataSource = 0;

		private static uint __DeactivateAllDataSources = 0;

		private static uint __ActivateDataSource = 0;

		private static uint __ActivateAllDataSources = 0;
	}
}