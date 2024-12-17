using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangePipelinePropertyStatePerContext")]
	public partial class FInterchangePipelinePropertyStatePerContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangeCore.InterchangePipelinePropertyStatePerContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangePipelinePropertyStatePerContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangePipelinePropertyStatePerContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangePipelinePropertyStatePerContext A, FInterchangePipelinePropertyStatePerContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangePipelinePropertyStatePerContext A, FInterchangePipelinePropertyStatePerContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangePipelinePropertyStatePerContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bVisible
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bVisible, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bVisible, __InBuffer);
				}
			}
		}

		private static uint __bVisible = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}