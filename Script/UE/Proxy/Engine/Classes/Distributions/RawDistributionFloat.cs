using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RawDistributionFloat")]
	public partial class FRawDistributionFloat : FRawDistribution, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RawDistributionFloat");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRawDistributionFloat()
		{
		}

		public static bool operator ==(FRawDistributionFloat A, FRawDistributionFloat B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRawDistributionFloat A, FRawDistributionFloat B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRawDistributionFloat;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float MinValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinValue, __InBuffer);
				}
			}
		}

		public float MaxValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxValue, __InBuffer);
				}
			}
		}

		public UDistributionFloat Distribution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Distribution, __ReturnBuffer);

					return *(UDistributionFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Distribution, __InBuffer);
				}
			}
		}

		private static uint __MinValue = 0;

		private static uint __MaxValue = 0;

		private static uint __Distribution = 0;

	}
}