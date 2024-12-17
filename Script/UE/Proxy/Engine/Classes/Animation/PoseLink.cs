using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PoseLink")]
	public partial class FPoseLink : FPoseLinkBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PoseLink");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPoseLink()
		{
		}

		public static bool operator ==(FPoseLink A, FPoseLink B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPoseLink A, FPoseLink B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPoseLink;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}