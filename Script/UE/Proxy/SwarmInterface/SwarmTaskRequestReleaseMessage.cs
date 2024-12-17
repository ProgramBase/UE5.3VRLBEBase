using Script.CoreUObject;
using Script.Library;

namespace Script.SwarmInterface
{
	[PathName("/Script/SwarmInterface.SwarmTaskRequestReleaseMessage")]
	public partial class FSwarmTaskRequestReleaseMessage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SwarmInterface.SwarmTaskRequestReleaseMessage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSwarmTaskRequestReleaseMessage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSwarmTaskRequestReleaseMessage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSwarmTaskRequestReleaseMessage A, FSwarmTaskRequestReleaseMessage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSwarmTaskRequestReleaseMessage A, FSwarmTaskRequestReleaseMessage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSwarmTaskRequestReleaseMessage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}