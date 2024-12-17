using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_MultiFABRIK_WorkData")]
	public partial class FRigUnit_MultiFABRIK_WorkData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_MultiFABRIK_WorkData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_MultiFABRIK_WorkData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_MultiFABRIK_WorkData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_MultiFABRIK_WorkData A, FRigUnit_MultiFABRIK_WorkData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_MultiFABRIK_WorkData A, FRigUnit_MultiFABRIK_WorkData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_MultiFABRIK_WorkData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}