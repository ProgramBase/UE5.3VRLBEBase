using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimSingleNodeInstanceProxy")]
	public partial class FAnimSingleNodeInstanceProxy : FAnimInstanceProxy, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimSingleNodeInstanceProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimSingleNodeInstanceProxy()
		{
		}

		public static bool operator ==(FAnimSingleNodeInstanceProxy A, FAnimSingleNodeInstanceProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimSingleNodeInstanceProxy A, FAnimSingleNodeInstanceProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimSingleNodeInstanceProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}