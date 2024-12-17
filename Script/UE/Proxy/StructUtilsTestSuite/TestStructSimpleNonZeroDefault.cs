using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtilsTestSuite
{
	[PathName("/Script/StructUtilsTestSuite.TestStructSimpleNonZeroDefault")]
	public partial class FTestStructSimpleNonZeroDefault : FTestStructSimpleBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/StructUtilsTestSuite.TestStructSimpleNonZeroDefault");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTestStructSimpleNonZeroDefault()
		{
		}

		public static bool operator ==(FTestStructSimpleNonZeroDefault A, FTestStructSimpleNonZeroDefault B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTestStructSimpleNonZeroDefault A, FTestStructSimpleNonZeroDefault B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTestStructSimpleNonZeroDefault;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Float
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Float, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Float, __InBuffer);
				}
			}
		}

		private static uint __Float = 0;

	}
}