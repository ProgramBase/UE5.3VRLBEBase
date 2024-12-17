﻿using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2Graph")]
	public partial class FEdGraphSchemaAction_K2Graph : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2Graph");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2Graph()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2Graph A, FEdGraphSchemaAction_K2Graph B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2Graph A, FEdGraphSchemaAction_K2Graph B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2Graph;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}