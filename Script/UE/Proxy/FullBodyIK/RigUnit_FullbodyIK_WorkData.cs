using Script.CoreUObject;
using Script.Library;

namespace Script.FullBodyIK
{
	[PathName("/Script/FullBodyIK.RigUnit_FullbodyIK_WorkData")]
	public partial class FRigUnit_FullbodyIK_WorkData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FullBodyIK.RigUnit_FullbodyIK_WorkData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_FullbodyIK_WorkData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_FullbodyIK_WorkData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_FullbodyIK_WorkData A, FRigUnit_FullbodyIK_WorkData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_FullbodyIK_WorkData A, FRigUnit_FullbodyIK_WorkData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_FullbodyIK_WorkData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}