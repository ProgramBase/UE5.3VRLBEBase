using Script.CoreUObject;
using Script.Library;
using Script.MetasoundFrontend;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundBuilderNodeOutputHandle")]
	public partial class FMetaSoundBuilderNodeOutputHandle : FMetasoundFrontendVertexHandle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEngine.MetaSoundBuilderNodeOutputHandle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetaSoundBuilderNodeOutputHandle()
		{
		}

		public static bool operator ==(FMetaSoundBuilderNodeOutputHandle A, FMetaSoundBuilderNodeOutputHandle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetaSoundBuilderNodeOutputHandle A, FMetaSoundBuilderNodeOutputHandle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetaSoundBuilderNodeOutputHandle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}