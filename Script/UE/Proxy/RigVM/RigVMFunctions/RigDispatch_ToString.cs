using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigDispatch_ToString")]
	public partial class FRigDispatch_ToString : FRigVMDispatchFactory, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigDispatch_ToString");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigDispatch_ToString()
		{
		}

		public static bool operator ==(FRigDispatch_ToString A, FRigDispatch_ToString B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigDispatch_ToString A, FRigDispatch_ToString B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigDispatch_ToString;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}