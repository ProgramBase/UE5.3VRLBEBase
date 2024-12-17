using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigControlModifiedContext")]
	public partial class FRigControlModifiedContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigControlModifiedContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigControlModifiedContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigControlModifiedContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigControlModifiedContext A, FRigControlModifiedContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigControlModifiedContext A, FRigControlModifiedContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigControlModifiedContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}