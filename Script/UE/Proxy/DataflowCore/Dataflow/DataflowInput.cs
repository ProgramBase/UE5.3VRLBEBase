using Script.CoreUObject;
using Script.Library;

namespace Script.DataflowCore
{
	[PathName("/Script/DataflowCore.DataflowInput")]
	public partial class FDataflowInput : FDataflowConnection, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowCore.DataflowInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDataflowInput()
		{
		}

		public static bool operator ==(FDataflowInput A, FDataflowInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDataflowInput A, FDataflowInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDataflowInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}