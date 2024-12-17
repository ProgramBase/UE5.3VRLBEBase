using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BodyInstanceAsyncPhysicsTickHandle")]
	public partial class FBodyInstanceAsyncPhysicsTickHandle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BodyInstanceAsyncPhysicsTickHandle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBodyInstanceAsyncPhysicsTickHandle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBodyInstanceAsyncPhysicsTickHandle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBodyInstanceAsyncPhysicsTickHandle A, FBodyInstanceAsyncPhysicsTickHandle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBodyInstanceAsyncPhysicsTickHandle A, FBodyInstanceAsyncPhysicsTickHandle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBodyInstanceAsyncPhysicsTickHandle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}