using Script.CoreUObject;
using Script.Library;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.ClosestPhysicsObjectResult")]
	public partial class FClosestPhysicsObjectResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Chaos.ClosestPhysicsObjectResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FClosestPhysicsObjectResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FClosestPhysicsObjectResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FClosestPhysicsObjectResult A, FClosestPhysicsObjectResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FClosestPhysicsObjectResult A, FClosestPhysicsObjectResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FClosestPhysicsObjectResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}