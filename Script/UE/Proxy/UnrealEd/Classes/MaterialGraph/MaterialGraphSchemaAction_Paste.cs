using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialGraphSchemaAction_Paste")]
	public partial class FMaterialGraphSchemaAction_Paste : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.MaterialGraphSchemaAction_Paste");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialGraphSchemaAction_Paste()
		{
		}

		public static bool operator ==(FMaterialGraphSchemaAction_Paste A, FMaterialGraphSchemaAction_Paste B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialGraphSchemaAction_Paste A, FMaterialGraphSchemaAction_Paste B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialGraphSchemaAction_Paste;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}