using Script.CoreUObject;
using Script.Library;

namespace Script.SwarmInterface
{
	[PathName("/Script/SwarmInterface.SwarmQuitMessage")]
	public partial class FSwarmQuitMessage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SwarmInterface.SwarmQuitMessage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSwarmQuitMessage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSwarmQuitMessage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSwarmQuitMessage A, FSwarmQuitMessage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSwarmQuitMessage A, FSwarmQuitMessage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSwarmQuitMessage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}