using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorComponentTickFunction")]
	public partial class FActorComponentTickFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ActorComponentTickFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorComponentTickFunction()
		{
		}

		public static bool operator ==(FActorComponentTickFunction A, FActorComponentTickFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorComponentTickFunction A, FActorComponentTickFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorComponentTickFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}