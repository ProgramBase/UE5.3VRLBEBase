using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ComponentSpacePoseLink")]
	public partial class FComponentSpacePoseLink : FPoseLinkBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ComponentSpacePoseLink");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FComponentSpacePoseLink()
		{
		}

		public static bool operator ==(FComponentSpacePoseLink A, FComponentSpacePoseLink B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FComponentSpacePoseLink A, FComponentSpacePoseLink B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FComponentSpacePoseLink;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}