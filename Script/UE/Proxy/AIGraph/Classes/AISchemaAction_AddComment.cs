using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIGraph
{
	[PathName("/Script/AIGraph.AISchemaAction_AddComment")]
	public partial class FAISchemaAction_AddComment : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIGraph.AISchemaAction_AddComment");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAISchemaAction_AddComment()
		{
		}

		public static bool operator ==(FAISchemaAction_AddComment A, FAISchemaAction_AddComment B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAISchemaAction_AddComment A, FAISchemaAction_AddComment B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAISchemaAction_AddComment;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}