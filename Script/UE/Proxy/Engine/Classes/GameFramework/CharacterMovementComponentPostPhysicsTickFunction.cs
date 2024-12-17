using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CharacterMovementComponentPostPhysicsTickFunction")]
	public partial class FCharacterMovementComponentPostPhysicsTickFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CharacterMovementComponentPostPhysicsTickFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCharacterMovementComponentPostPhysicsTickFunction()
		{
		}

		public static bool operator ==(FCharacterMovementComponentPostPhysicsTickFunction A, FCharacterMovementComponentPostPhysicsTickFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCharacterMovementComponentPostPhysicsTickFunction A, FCharacterMovementComponentPostPhysicsTickFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCharacterMovementComponentPostPhysicsTickFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}