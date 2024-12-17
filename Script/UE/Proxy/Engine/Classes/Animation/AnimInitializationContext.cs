using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimInitializationContext")]
	public partial class FAnimInitializationContext : FAnimExecutionContext, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimInitializationContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimInitializationContext()
		{
		}

		public static bool operator ==(FAnimInitializationContext A, FAnimInitializationContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimInitializationContext A, FAnimInitializationContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimInitializationContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}