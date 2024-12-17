using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigDispatch_AnimAttributeBase")]
	public partial class FRigDispatch_AnimAttributeBase : FRigDispatchFactory, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigDispatch_AnimAttributeBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigDispatch_AnimAttributeBase()
		{
		}

		public static bool operator ==(FRigDispatch_AnimAttributeBase A, FRigDispatch_AnimAttributeBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigDispatch_AnimAttributeBase A, FRigDispatch_AnimAttributeBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigDispatch_AnimAttributeBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}