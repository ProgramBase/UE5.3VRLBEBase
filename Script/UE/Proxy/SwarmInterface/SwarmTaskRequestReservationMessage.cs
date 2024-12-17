using Script.CoreUObject;
using Script.Library;

namespace Script.SwarmInterface
{
	[PathName("/Script/SwarmInterface.SwarmTaskRequestReservationMessage")]
	public partial class FSwarmTaskRequestReservationMessage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SwarmInterface.SwarmTaskRequestReservationMessage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSwarmTaskRequestReservationMessage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSwarmTaskRequestReservationMessage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSwarmTaskRequestReservationMessage A, FSwarmTaskRequestReservationMessage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSwarmTaskRequestReservationMessage A, FSwarmTaskRequestReservationMessage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSwarmTaskRequestReservationMessage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}