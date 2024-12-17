using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2AddComponent")]
	public partial class FEdGraphSchemaAction_K2AddComponent : FEdGraphSchemaAction_K2NewNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2AddComponent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2AddComponent()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2AddComponent A, FEdGraphSchemaAction_K2AddComponent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2AddComponent A, FEdGraphSchemaAction_K2AddComponent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2AddComponent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UActorComponent> ComponentClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentClass, __ReturnBuffer);

					return *(TSubclassOf<UActorComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentClass, __InBuffer);
				}
			}
		}

		public UObject ComponentAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentAsset, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentAsset, __InBuffer);
				}
			}
		}

		private static uint __ComponentClass = 0;

		private static uint __ComponentAsset = 0;

	}
}