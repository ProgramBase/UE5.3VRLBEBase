using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2AddCallOnActor")]
	public partial class FEdGraphSchemaAction_K2AddCallOnActor : FEdGraphSchemaAction_K2NewNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2AddCallOnActor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2AddCallOnActor()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2AddCallOnActor A, FEdGraphSchemaAction_K2AddCallOnActor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2AddCallOnActor A, FEdGraphSchemaAction_K2AddCallOnActor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2AddCallOnActor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<AActor> LevelActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LevelActors, __ReturnBuffer);

					return *(TArray<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LevelActors, __InBuffer);
				}
			}
		}

		private static uint __LevelActors = 0;

	}
}