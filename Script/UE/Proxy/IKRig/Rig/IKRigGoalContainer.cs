using Script.CoreUObject;
using Script.Library;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.IKRigGoalContainer")]
	public partial class FIKRigGoalContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IKRig.IKRigGoalContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIKRigGoalContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FIKRigGoalContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FIKRigGoalContainer A, FIKRigGoalContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIKRigGoalContainer A, FIKRigGoalContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIKRigGoalContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}