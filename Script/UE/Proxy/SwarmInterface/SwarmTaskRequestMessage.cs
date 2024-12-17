using Script.CoreUObject;
using Script.Library;

namespace Script.SwarmInterface
{
	[PathName("/Script/SwarmInterface.SwarmTaskRequestMessage")]
	public partial class FSwarmTaskRequestMessage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SwarmInterface.SwarmTaskRequestMessage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSwarmTaskRequestMessage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSwarmTaskRequestMessage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSwarmTaskRequestMessage A, FSwarmTaskRequestMessage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSwarmTaskRequestMessage A, FSwarmTaskRequestMessage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSwarmTaskRequestMessage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}