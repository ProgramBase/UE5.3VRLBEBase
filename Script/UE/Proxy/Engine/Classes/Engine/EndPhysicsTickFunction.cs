using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EndPhysicsTickFunction")]
	public partial class FEndPhysicsTickFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.EndPhysicsTickFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEndPhysicsTickFunction()
		{
		}

		public static bool operator ==(FEndPhysicsTickFunction A, FEndPhysicsTickFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEndPhysicsTickFunction A, FEndPhysicsTickFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEndPhysicsTickFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}