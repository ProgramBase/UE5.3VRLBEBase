using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangePipelineStack")]
	public partial class FInterchangePipelineStack : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangeEngine.InterchangePipelineStack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangePipelineStack() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangePipelineStack() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangePipelineStack A, FInterchangePipelineStack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangePipelineStack A, FInterchangePipelineStack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangePipelineStack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FSoftObjectPath> Pipelines
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Pipelines, __ReturnBuffer);

					return *(TArray<FSoftObjectPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Pipelines, __InBuffer);
				}
			}
		}

		public TArray<FInterchangeTranslatorPipelines> PerTranslatorPipelines
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PerTranslatorPipelines, __ReturnBuffer);

					return *(TArray<FInterchangeTranslatorPipelines>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PerTranslatorPipelines, __InBuffer);
				}
			}
		}

		private static uint __Pipelines = 0;

		private static uint __PerTranslatorPipelines = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}