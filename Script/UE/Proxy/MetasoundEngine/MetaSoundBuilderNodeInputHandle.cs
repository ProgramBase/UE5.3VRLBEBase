using Script.CoreUObject;
using Script.Library;
using Script.MetasoundFrontend;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundBuilderNodeInputHandle")]
	public partial class FMetaSoundBuilderNodeInputHandle : FMetasoundFrontendVertexHandle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEngine.MetaSoundBuilderNodeInputHandle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetaSoundBuilderNodeInputHandle()
		{
		}

		public static bool operator ==(FMetaSoundBuilderNodeInputHandle A, FMetaSoundBuilderNodeInputHandle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetaSoundBuilderNodeInputHandle A, FMetaSoundBuilderNodeInputHandle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetaSoundBuilderNodeInputHandle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}