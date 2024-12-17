using Script.CoreUObject;
using Script.Library;

namespace Script.SwarmInterface
{
	[PathName("/Script/SwarmInterface.SwarmPingMessage")]
	public partial class FSwarmPingMessage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SwarmInterface.SwarmPingMessage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSwarmPingMessage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSwarmPingMessage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSwarmPingMessage A, FSwarmPingMessage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSwarmPingMessage A, FSwarmPingMessage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSwarmPingMessage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}