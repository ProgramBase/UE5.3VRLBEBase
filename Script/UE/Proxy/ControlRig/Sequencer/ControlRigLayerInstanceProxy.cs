using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigLayerInstanceProxy")]
	public partial class FControlRigLayerInstanceProxy : FAnimInstanceProxy, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.ControlRigLayerInstanceProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigLayerInstanceProxy()
		{
		}

		public static bool operator ==(FControlRigLayerInstanceProxy A, FControlRigLayerInstanceProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigLayerInstanceProxy A, FControlRigLayerInstanceProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigLayerInstanceProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}