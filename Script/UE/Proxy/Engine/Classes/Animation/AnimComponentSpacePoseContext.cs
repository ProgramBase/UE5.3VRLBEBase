using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimComponentSpacePoseContext")]
	public partial class FAnimComponentSpacePoseContext : FAnimExecutionContext, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimComponentSpacePoseContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimComponentSpacePoseContext()
		{
		}

		public static bool operator ==(FAnimComponentSpacePoseContext A, FAnimComponentSpacePoseContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimComponentSpacePoseContext A, FAnimComponentSpacePoseContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimComponentSpacePoseContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}