using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigHierarchyRef")]
	public partial class FRigHierarchyRef : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigHierarchyRef");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigHierarchyRef() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigHierarchyRef() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigHierarchyRef A, FRigHierarchyRef B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigHierarchyRef A, FRigHierarchyRef B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigHierarchyRef;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}