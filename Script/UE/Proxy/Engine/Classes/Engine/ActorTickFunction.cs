using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorTickFunction")]
	public partial class FActorTickFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ActorTickFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorTickFunction()
		{
		}

		public static bool operator ==(FActorTickFunction A, FActorTickFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorTickFunction A, FActorTickFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorTickFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}