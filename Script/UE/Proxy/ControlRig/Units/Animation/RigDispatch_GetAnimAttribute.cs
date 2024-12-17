using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigDispatch_GetAnimAttribute")]
	public partial class FRigDispatch_GetAnimAttribute : FRigDispatch_AnimAttributeBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigDispatch_GetAnimAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigDispatch_GetAnimAttribute()
		{
		}

		public static bool operator ==(FRigDispatch_GetAnimAttribute A, FRigDispatch_GetAnimAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigDispatch_GetAnimAttribute A, FRigDispatch_GetAnimAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigDispatch_GetAnimAttribute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}