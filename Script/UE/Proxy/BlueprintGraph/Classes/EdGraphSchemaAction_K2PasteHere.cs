﻿using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2PasteHere")]
	public partial class FEdGraphSchemaAction_K2PasteHere : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2PasteHere");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2PasteHere()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2PasteHere A, FEdGraphSchemaAction_K2PasteHere B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2PasteHere A, FEdGraphSchemaAction_K2PasteHere B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2PasteHere;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}