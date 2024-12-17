using Script.CoreUObject;
using Script.Library;

namespace Script.DataflowCore
{
	[PathName("/Script/DataflowCore.DataflowSelection")]
	public partial class FDataflowSelection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowCore.DataflowSelection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDataflowSelection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDataflowSelection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDataflowSelection A, FDataflowSelection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDataflowSelection A, FDataflowSelection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDataflowSelection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}