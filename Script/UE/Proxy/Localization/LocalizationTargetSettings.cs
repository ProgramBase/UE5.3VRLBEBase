using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.LocalizationTargetSettings")]
	public partial class FLocalizationTargetSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Localization.LocalizationTargetSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLocalizationTargetSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLocalizationTargetSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLocalizationTargetSettings A, FLocalizationTargetSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLocalizationTargetSettings A, FLocalizationTargetSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLocalizationTargetSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Name, __InBuffer);
				}
			}
		}

		public FGuid Guid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Guid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Guid, __InBuffer);
				}
			}
		}

		public ELocalizationTargetConflictStatus ConflictStatus
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConflictStatus, __ReturnBuffer);

					return *(ELocalizationTargetConflictStatus*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConflictStatus, __InBuffer);
				}
			}
		}

		public TArray<FGuid> TargetDependencies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetDependencies, __ReturnBuffer);

					return *(TArray<FGuid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetDependencies, __InBuffer);
				}
			}
		}

		public TArray<FFilePath> AdditionalManifestDependencies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AdditionalManifestDependencies, __ReturnBuffer);

					return *(TArray<FFilePath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AdditionalManifestDependencies, __InBuffer);
				}
			}
		}

		public TArray<FString> RequiredModuleNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RequiredModuleNames, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RequiredModuleNames, __InBuffer);
				}
			}
		}

		public FGatherTextFromTextFilesConfiguration GatherFromTextFiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GatherFromTextFiles, __ReturnBuffer);

					return *(FGatherTextFromTextFilesConfiguration*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GatherFromTextFiles, __InBuffer);
				}
			}
		}

		public FGatherTextFromPackagesConfiguration GatherFromPackages
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GatherFromPackages, __ReturnBuffer);

					return *(FGatherTextFromPackagesConfiguration*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GatherFromPackages, __InBuffer);
				}
			}
		}

		public FGatherTextFromMetaDataConfiguration GatherFromMetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GatherFromMetaData, __ReturnBuffer);

					return *(FGatherTextFromMetaDataConfiguration*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GatherFromMetaData, __InBuffer);
				}
			}
		}

		public FLocalizationExportingSettings ExportSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExportSettings, __ReturnBuffer);

					return *(FLocalizationExportingSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExportSettings, __InBuffer);
				}
			}
		}

		public FLocalizationCompilationSettings CompileSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompileSettings, __ReturnBuffer);

					return *(FLocalizationCompilationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompileSettings, __InBuffer);
				}
			}
		}

		public FLocalizationImportDialogueSettings ImportDialogueSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImportDialogueSettings, __ReturnBuffer);

					return *(FLocalizationImportDialogueSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImportDialogueSettings, __InBuffer);
				}
			}
		}

		public int NativeCultureIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NativeCultureIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NativeCultureIndex, __InBuffer);
				}
			}
		}

		public TArray<FCultureStatistics> SupportedCulturesStatistics
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SupportedCulturesStatistics, __ReturnBuffer);

					return *(TArray<FCultureStatistics>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SupportedCulturesStatistics, __InBuffer);
				}
			}
		}

		private static uint __Name = 0;

		private static uint __Guid = 0;

		private static uint __ConflictStatus = 0;

		private static uint __TargetDependencies = 0;

		private static uint __AdditionalManifestDependencies = 0;

		private static uint __RequiredModuleNames = 0;

		private static uint __GatherFromTextFiles = 0;

		private static uint __GatherFromPackages = 0;

		private static uint __GatherFromMetaData = 0;

		private static uint __ExportSettings = 0;

		private static uint __CompileSettings = 0;

		private static uint __ImportDialogueSettings = 0;

		private static uint __NativeCultureIndex = 0;

		private static uint __SupportedCulturesStatistics = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}