using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlShapeActorCreationParam")]
	public partial class FControlShapeActorCreationParam : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.ControlShapeActorCreationParam");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlShapeActorCreationParam() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlShapeActorCreationParam() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlShapeActorCreationParam A, FControlShapeActorCreationParam B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlShapeActorCreationParam A, FControlShapeActorCreationParam B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlShapeActorCreationParam;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}