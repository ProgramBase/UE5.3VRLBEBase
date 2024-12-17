using Script.CoreUObject;
using Script.Library;
using Script.InterchangeCore;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangeStackInfo")]
	public partial class FInterchangeStackInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangeEngine.InterchangeStackInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangeStackInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangeStackInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangeStackInfo A, FInterchangeStackInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangeStackInfo A, FInterchangeStackInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangeStackInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName StackName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StackName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StackName, __InBuffer);
				}
			}
		}

		public TArray<UInterchangePipelineBase> Pipelines
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Pipelines, __ReturnBuffer);

					return *(TArray<UInterchangePipelineBase>*)__ReturnBuffer;
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

		private static uint __StackName = 0;

		private static uint __Pipelines = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}