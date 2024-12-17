using Script.CoreUObject;
using Script.Library;

namespace Script.DataflowCore
{
	[PathName("/Script/DataflowCore.DataflowConnection")]
	public partial class FDataflowConnection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowCore.DataflowConnection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDataflowConnection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDataflowConnection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDataflowConnection A, FDataflowConnection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDataflowConnection A, FDataflowConnection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDataflowConnection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}