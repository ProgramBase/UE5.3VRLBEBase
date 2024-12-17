using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.SimpleIndexedHandleBase")]
	public partial class FSimpleIndexedHandleBase : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.SimpleIndexedHandleBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSimpleIndexedHandleBase() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSimpleIndexedHandleBase() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSimpleIndexedHandleBase A, FSimpleIndexedHandleBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSimpleIndexedHandleBase A, FSimpleIndexedHandleBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSimpleIndexedHandleBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}