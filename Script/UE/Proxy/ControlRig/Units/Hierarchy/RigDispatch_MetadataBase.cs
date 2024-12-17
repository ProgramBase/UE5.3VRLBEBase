using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigDispatch_MetadataBase")]
	public partial class FRigDispatch_MetadataBase : FRigDispatchFactory, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigDispatch_MetadataBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigDispatch_MetadataBase()
		{
		}

		public static bool operator ==(FRigDispatch_MetadataBase A, FRigDispatch_MetadataBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigDispatch_MetadataBase A, FRigDispatch_MetadataBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigDispatch_MetadataBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}