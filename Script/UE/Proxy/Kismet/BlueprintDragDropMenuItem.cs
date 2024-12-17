using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.BlueprintDragDropMenuItem")]
	public partial class FBlueprintDragDropMenuItem : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Kismet.BlueprintDragDropMenuItem");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintDragDropMenuItem()
		{
		}

		public static bool operator ==(FBlueprintDragDropMenuItem A, FBlueprintDragDropMenuItem B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintDragDropMenuItem A, FBlueprintDragDropMenuItem B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintDragDropMenuItem;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}