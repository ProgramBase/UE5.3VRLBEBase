using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialGraphSchemaAction_NewComment")]
	public partial class FMaterialGraphSchemaAction_NewComment : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.MaterialGraphSchemaAction_NewComment");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialGraphSchemaAction_NewComment()
		{
		}

		public static bool operator ==(FMaterialGraphSchemaAction_NewComment A, FMaterialGraphSchemaAction_NewComment B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialGraphSchemaAction_NewComment A, FMaterialGraphSchemaAction_NewComment B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialGraphSchemaAction_NewComment;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}