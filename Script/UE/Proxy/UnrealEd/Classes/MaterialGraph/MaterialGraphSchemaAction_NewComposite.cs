using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialGraphSchemaAction_NewComposite")]
	public partial class FMaterialGraphSchemaAction_NewComposite : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.MaterialGraphSchemaAction_NewComposite");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialGraphSchemaAction_NewComposite()
		{
		}

		public static bool operator ==(FMaterialGraphSchemaAction_NewComposite A, FMaterialGraphSchemaAction_NewComposite B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialGraphSchemaAction_NewComposite A, FMaterialGraphSchemaAction_NewComposite B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialGraphSchemaAction_NewComposite;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}