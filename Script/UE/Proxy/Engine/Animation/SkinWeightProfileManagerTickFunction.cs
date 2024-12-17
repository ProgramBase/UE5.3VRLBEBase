using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkinWeightProfileManagerTickFunction")]
	public partial class FSkinWeightProfileManagerTickFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkinWeightProfileManagerTickFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkinWeightProfileManagerTickFunction()
		{
		}

		public static bool operator ==(FSkinWeightProfileManagerTickFunction A, FSkinWeightProfileManagerTickFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkinWeightProfileManagerTickFunction A, FSkinWeightProfileManagerTickFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkinWeightProfileManagerTickFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}