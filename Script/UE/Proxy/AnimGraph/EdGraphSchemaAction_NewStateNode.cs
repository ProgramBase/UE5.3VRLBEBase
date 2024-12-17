﻿using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.EdGraphSchemaAction_NewStateNode")]
	public partial class FEdGraphSchemaAction_NewStateNode : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraph.EdGraphSchemaAction_NewStateNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_NewStateNode()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_NewStateNode A, FEdGraphSchemaAction_NewStateNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_NewStateNode A, FEdGraphSchemaAction_NewStateNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_NewStateNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}