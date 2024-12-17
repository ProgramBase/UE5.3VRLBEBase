using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigDispatch_SetAnimAttribute")]
	public partial class FRigDispatch_SetAnimAttribute : FRigDispatch_AnimAttributeBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigDispatch_SetAnimAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigDispatch_SetAnimAttribute()
		{
		}

		public static bool operator ==(FRigDispatch_SetAnimAttribute A, FRigDispatch_SetAnimAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigDispatch_SetAnimAttribute A, FRigDispatch_SetAnimAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigDispatch_SetAnimAttribute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}