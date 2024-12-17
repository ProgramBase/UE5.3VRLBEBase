using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KSkinnedLevelSetElem")]
	public partial class FKSkinnedLevelSetElem : FKShapeElem, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.KSkinnedLevelSetElem");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FKSkinnedLevelSetElem()
		{
		}

		public static bool operator ==(FKSkinnedLevelSetElem A, FKSkinnedLevelSetElem B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FKSkinnedLevelSetElem A, FKSkinnedLevelSetElem B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FKSkinnedLevelSetElem;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}