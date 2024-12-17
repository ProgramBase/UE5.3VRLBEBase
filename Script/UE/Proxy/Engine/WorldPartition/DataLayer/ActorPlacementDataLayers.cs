using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorPlacementDataLayers")]
	public partial class FActorPlacementDataLayers : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ActorPlacementDataLayers");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorPlacementDataLayers() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActorPlacementDataLayers() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActorPlacementDataLayers A, FActorPlacementDataLayers B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorPlacementDataLayers A, FActorPlacementDataLayers B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorPlacementDataLayers;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> DataLayerInstanceNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataLayerInstanceNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataLayerInstanceNames, __InBuffer);
				}
			}
		}

		public int ContextID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ContextID, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ContextID, __InBuffer);
				}
			}
		}

		private static uint __DataLayerInstanceNames = 0;

		private static uint __ContextID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}