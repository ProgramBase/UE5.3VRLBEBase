using Script.CoreUObject;
using Script.Library;
using Script.InterchangeCore;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangeContentImportSettings")]
	public partial class FInterchangeContentImportSettings : FInterchangeImportSettings, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangeEngine.InterchangeContentImportSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangeContentImportSettings()
		{
		}

		public static bool operator ==(FInterchangeContentImportSettings A, FInterchangeContentImportSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangeContentImportSettings A, FInterchangeContentImportSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangeContentImportSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<EInterchangeTranslatorAssetType, FName> DefaultPipelineStackOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultPipelineStackOverride, __ReturnBuffer);

					return *(TMap<EInterchangeTranslatorAssetType, FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultPipelineStackOverride, __InBuffer);
				}
			}
		}

		public TMap<EInterchangeTranslatorAssetType, bool> ShowPipelineStacksConfigurationDialogOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShowPipelineStacksConfigurationDialogOverride, __ReturnBuffer);

					return *(TMap<EInterchangeTranslatorAssetType, bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShowPipelineStacksConfigurationDialogOverride, __InBuffer);
				}
			}
		}

		private static uint __DefaultPipelineStackOverride = 0;

		private static uint __ShowPipelineStacksConfigurationDialogOverride = 0;

	}
}