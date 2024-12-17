using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavGraphEdge")]
	public partial class FNavGraphEdge : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NavigationSystem.NavGraphEdge");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNavGraphEdge() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNavGraphEdge() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNavGraphEdge A, FNavGraphEdge B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNavGraphEdge A, FNavGraphEdge B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNavGraphEdge;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}