using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RPCDoSStateConfig")]
	public partial class FRPCDoSStateConfig : FRPCDoSState, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RPCDoSStateConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRPCDoSStateConfig()
		{
		}

		public static bool operator ==(FRPCDoSStateConfig A, FRPCDoSStateConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRPCDoSStateConfig A, FRPCDoSStateConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRPCDoSStateConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}