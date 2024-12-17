using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CharacterMovementComponentPrePhysicsTickFunction")]
	public partial class FCharacterMovementComponentPrePhysicsTickFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CharacterMovementComponentPrePhysicsTickFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCharacterMovementComponentPrePhysicsTickFunction()
		{
		}

		public static bool operator ==(FCharacterMovementComponentPrePhysicsTickFunction A, FCharacterMovementComponentPrePhysicsTickFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCharacterMovementComponentPrePhysicsTickFunction A, FCharacterMovementComponentPrePhysicsTickFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCharacterMovementComponentPrePhysicsTickFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}