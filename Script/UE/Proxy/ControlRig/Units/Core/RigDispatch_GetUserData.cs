using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigDispatch_GetUserData")]
	public partial class FRigDispatch_GetUserData : FRigDispatchFactory, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigDispatch_GetUserData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigDispatch_GetUserData()
		{
		}

		public static bool operator ==(FRigDispatch_GetUserData A, FRigDispatch_GetUserData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigDispatch_GetUserData A, FRigDispatch_GetUserData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigDispatch_GetUserData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}