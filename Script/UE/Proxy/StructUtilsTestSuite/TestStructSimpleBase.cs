using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtilsTestSuite
{
	[PathName("/Script/StructUtilsTestSuite.TestStructSimpleBase")]
	public partial class FTestStructSimpleBase : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/StructUtilsTestSuite.TestStructSimpleBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTestStructSimpleBase() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTestStructSimpleBase() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTestStructSimpleBase A, FTestStructSimpleBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTestStructSimpleBase A, FTestStructSimpleBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTestStructSimpleBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}