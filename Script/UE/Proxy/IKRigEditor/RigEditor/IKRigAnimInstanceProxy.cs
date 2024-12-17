using Script.CoreUObject;
using Script.Library;
using Script.AnimGraph;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.IKRigAnimInstanceProxy")]
	public partial class FIKRigAnimInstanceProxy : FAnimPreviewInstanceProxy, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IKRigEditor.IKRigAnimInstanceProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIKRigAnimInstanceProxy()
		{
		}

		public static bool operator ==(FIKRigAnimInstanceProxy A, FIKRigAnimInstanceProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIKRigAnimInstanceProxy A, FIKRigAnimInstanceProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIKRigAnimInstanceProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}