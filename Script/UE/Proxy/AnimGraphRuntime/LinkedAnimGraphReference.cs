using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.LinkedAnimGraphReference")]
	public partial class FLinkedAnimGraphReference : FAnimNodeReference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.LinkedAnimGraphReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLinkedAnimGraphReference()
		{
		}

		public static bool operator ==(FLinkedAnimGraphReference A, FLinkedAnimGraphReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLinkedAnimGraphReference A, FLinkedAnimGraphReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLinkedAnimGraphReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}