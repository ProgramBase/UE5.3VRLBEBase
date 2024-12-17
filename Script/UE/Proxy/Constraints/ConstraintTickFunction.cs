using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Constraints
{
	[PathName("/Script/Constraints.ConstraintTickFunction")]
	public partial class FConstraintTickFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Constraints.ConstraintTickFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FConstraintTickFunction()
		{
		}

		public static bool operator ==(FConstraintTickFunction A, FConstraintTickFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FConstraintTickFunction A, FConstraintTickFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FConstraintTickFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}