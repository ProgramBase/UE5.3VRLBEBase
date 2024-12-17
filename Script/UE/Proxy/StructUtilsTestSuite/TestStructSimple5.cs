using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtilsTestSuite
{
	[PathName("/Script/StructUtilsTestSuite.TestStructSimple5")]
	public partial class FTestStructSimple5 : FTestStructSimpleBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/StructUtilsTestSuite.TestStructSimple5");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTestStructSimple5()
		{
		}

		public static bool operator ==(FTestStructSimple5 A, FTestStructSimple5 B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTestStructSimple5 A, FTestStructSimple5 B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTestStructSimple5;

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