using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StaticMeshActor")]
	public partial class AStaticMeshActor : AActor, IStaticClass
	{
		public UStaticMeshComponent StaticMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshComponent, __InBuffer);
				}
			}
		}

		public bool bStaticMeshReplicateMovement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStaticMeshReplicateMovement, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStaticMeshReplicateMovement, __InBuffer);
				}
			}
		}

		public EPhysicsReplicationMode StaticMeshPhysicsReplicationMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshPhysicsReplicationMode, __ReturnBuffer);

					return *(EPhysicsReplicationMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshPhysicsReplicationMode, __InBuffer);
				}
			}
		}

		public ENavDataGatheringMode NavigationGeometryGatheringMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavigationGeometryGatheringMode, __ReturnBuffer);

					return *(ENavDataGatheringMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavigationGeometryGatheringMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.StaticMeshActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetMobility(EComponentMobility InMobility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InMobility;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMobility, __InBuffer);
			}
		}

		private static uint __StaticMeshComponent = 0;

		private static uint __bStaticMeshReplicateMovement = 0;

		private static uint __StaticMeshPhysicsReplicationMode = 0;

		private static uint __NavigationGeometryGatheringMode = 0;

		private static uint __SetMobility = 0;
	}
}