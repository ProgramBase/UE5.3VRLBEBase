using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VectorDistribution")]
	public partial class FVectorDistribution : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.VectorDistribution");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVectorDistribution() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FVectorDistribution() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FVectorDistribution A, FVectorDistribution B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVectorDistribution A, FVectorDistribution B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVectorDistribution;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDistributionLookupTable Table
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Table, __ReturnBuffer);

					return *(FDistributionLookupTable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Table, __InBuffer);
				}
			}
		}

		private static uint __Table = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}