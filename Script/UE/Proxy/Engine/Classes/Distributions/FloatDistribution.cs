using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.FloatDistribution")]
	public partial class FFloatDistribution : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.FloatDistribution");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFloatDistribution() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFloatDistribution() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFloatDistribution A, FFloatDistribution B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFloatDistribution A, FFloatDistribution B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFloatDistribution;

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