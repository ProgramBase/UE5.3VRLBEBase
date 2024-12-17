using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.HLODLayerActorMapping")]
	public partial class FHLODLayerActorMapping : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.HLODLayerActorMapping");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FHLODLayerActorMapping() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FHLODLayerActorMapping() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FHLODLayerActorMapping A, FHLODLayerActorMapping B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FHLODLayerActorMapping A, FHLODLayerActorMapping B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FHLODLayerActorMapping;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSoftClassPtr<AActor> ActorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorClass, __ReturnBuffer);

					return *(TSoftClassPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorClass, __InBuffer);
				}
			}
		}

		public FString HLODLayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HLODLayer, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HLODLayer, __InBuffer);
				}
			}
		}

		private static uint __ActorClass = 0;

		private static uint __HLODLayer = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}