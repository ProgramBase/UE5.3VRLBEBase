using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.FreezablePerPlatformInt")]
	public partial class FFreezablePerPlatformInt : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.FreezablePerPlatformInt");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFreezablePerPlatformInt() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFreezablePerPlatformInt() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFreezablePerPlatformInt A, FFreezablePerPlatformInt B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFreezablePerPlatformInt A, FFreezablePerPlatformInt B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFreezablePerPlatformInt;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}