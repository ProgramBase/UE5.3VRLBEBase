using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.IndexedHandleBase")]
	public partial class FIndexedHandleBase : FSimpleIndexedHandleBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.IndexedHandleBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIndexedHandleBase()
		{
		}

		public static bool operator ==(FIndexedHandleBase A, FIndexedHandleBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIndexedHandleBase A, FIndexedHandleBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIndexedHandleBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}