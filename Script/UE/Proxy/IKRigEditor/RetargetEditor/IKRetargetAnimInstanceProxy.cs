using Script.CoreUObject;
using Script.Library;
using Script.AnimGraph;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.IKRetargetAnimInstanceProxy")]
	public partial class FIKRetargetAnimInstanceProxy : FAnimPreviewInstanceProxy, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IKRigEditor.IKRetargetAnimInstanceProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIKRetargetAnimInstanceProxy()
		{
		}

		public static bool operator ==(FIKRetargetAnimInstanceProxy A, FIKRetargetAnimInstanceProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIKRetargetAnimInstanceProxy A, FIKRetargetAnimInstanceProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIKRetargetAnimInstanceProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}