using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendClassOutput")]
	public partial class FMetasoundFrontendClassOutput : FMetasoundFrontendClassVertex, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendClassOutput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendClassOutput()
		{
		}

		public static bool operator ==(FMetasoundFrontendClassOutput A, FMetasoundFrontendClassOutput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendClassOutput A, FMetasoundFrontendClassOutput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendClassOutput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}