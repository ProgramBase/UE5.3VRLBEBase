using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangeImportSettings")]
	public partial class FInterchangeImportSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangeEngine.InterchangeImportSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangeImportSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangeImportSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangeImportSettings A, FInterchangeImportSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangeImportSettings A, FInterchangeImportSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangeImportSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FName, FInterchangePipelineStack> PipelineStacks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PipelineStacks, __ReturnBuffer);

					return *(TMap<FName, FInterchangePipelineStack>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PipelineStacks, __InBuffer);
				}
			}
		}

		public FName DefaultPipelineStack
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultPipelineStack, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultPipelineStack, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UInterchangePipelineConfigurationBase> PipelineConfigurationDialogClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PipelineConfigurationDialogClass, __ReturnBuffer);

					return *(TSoftClassPtr<UInterchangePipelineConfigurationBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PipelineConfigurationDialogClass, __InBuffer);
				}
			}
		}

		public bool bShowPipelineStacksConfigurationDialog
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowPipelineStacksConfigurationDialog, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowPipelineStacksConfigurationDialog, __InBuffer);
				}
			}
		}

		private static uint __PipelineStacks = 0;

		private static uint __DefaultPipelineStack = 0;

		private static uint __PipelineConfigurationDialogClass = 0;

		private static uint __bShowPipelineStacksConfigurationDialog = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}