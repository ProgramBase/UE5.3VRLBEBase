using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimUpdateContext")]
	public partial class FAnimUpdateContext : FAnimExecutionContext, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimUpdateContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimUpdateContext()
		{
		}

		public static bool operator ==(FAnimUpdateContext A, FAnimUpdateContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimUpdateContext A, FAnimUpdateContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimUpdateContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}