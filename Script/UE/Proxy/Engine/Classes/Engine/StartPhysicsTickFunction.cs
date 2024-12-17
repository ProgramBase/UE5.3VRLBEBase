using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StartPhysicsTickFunction")]
	public partial class FStartPhysicsTickFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StartPhysicsTickFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStartPhysicsTickFunction()
		{
		}

		public static bool operator ==(FStartPhysicsTickFunction A, FStartPhysicsTickFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStartPhysicsTickFunction A, FStartPhysicsTickFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStartPhysicsTickFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}