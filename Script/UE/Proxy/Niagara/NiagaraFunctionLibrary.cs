using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraFunctionLibrary")]
	public partial class UNiagaraFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UNiagaraComponent SpawnSystemAttachedWithParams(FFXSystemSpawnParameters SpawnParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SpawnParams?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnSystemAttachedWithParams, __InBuffer, __ReturnBuffer);

				return *(UNiagaraComponent*)__ReturnBuffer;
			}
		}

		public static UNiagaraComponent SpawnSystemAttached(UNiagaraSystem SystemTemplate, USceneComponent AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, EAttachLocation LocationType, bool bAutoDestroy, bool bAutoActivate = true, ENCPoolMethod PoolingMethod = ENCPoolMethod.None, bool bPreCullCheck = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[45];

				*(nint*)(__InBuffer) = SystemTemplate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttachToComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AttachPointName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)LocationType;

				*(bool*)(__InBuffer + 41) = bAutoDestroy;

				*(bool*)(__InBuffer + 42) = bAutoActivate;

				*(byte*)(__InBuffer + 43) = (byte)PoolingMethod;

				*(bool*)(__InBuffer + 44) = bPreCullCheck;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnSystemAttached, __InBuffer, __ReturnBuffer);

				return *(UNiagaraComponent*)__ReturnBuffer;
			}
		}

		public static UNiagaraComponent SpawnSystemAtLocationWithParams(FFXSystemSpawnParameters SpawnParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SpawnParams?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnSystemAtLocationWithParams, __InBuffer, __ReturnBuffer);

				return *(UNiagaraComponent*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The spawned UNiagaraComponent
		/// </returns>
		public static UNiagaraComponent SpawnSystemAtLocation(UObject WorldContextObject, UNiagaraSystem SystemTemplate, FVector Location, FRotator Rotation = null, FVector Scale = null, bool bAutoDestroy = true, bool bAutoActivate = true, ENCPoolMethod PoolingMethod = ENCPoolMethod.None, bool bPreCullCheck = true)
		{
			unsafe
			{
				Rotation ??= new FRotator();

				Scale ??= new FVector(1.000000, 1.000000, 1.000000);

				var __InBuffer = stackalloc byte[44];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SystemTemplate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Scale?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 40) = bAutoDestroy;

				*(bool*)(__InBuffer + 41) = bAutoActivate;

				*(byte*)(__InBuffer + 42) = (byte)PoolingMethod;

				*(bool*)(__InBuffer + 43) = bPreCullCheck;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnSystemAtLocation, __InBuffer, __ReturnBuffer);

				return *(UNiagaraComponent*)__ReturnBuffer;
			}
		}

		public static void SetVolumeTextureObject(UNiagaraComponent NiagaraSystem, FString OverrideName, UVolumeTexture Texture)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetVolumeTextureObject, __InBuffer);
			}
		}

		public static void SetTextureObject(UNiagaraComponent NiagaraSystem, FString OverrideName, UTexture Texture)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetTextureObject, __InBuffer);
			}
		}

		public static void SetTexture2DArrayObject(UNiagaraComponent NiagaraSystem, FString OverrideName, UTexture2DArray Texture)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetTexture2DArrayObject, __InBuffer);
			}
		}

		public static void SetSkeletalMeshDataInterfaceSamplingRegions(UNiagaraComponent NiagaraSystem, FString OverrideName, TArray<FName> SamplingRegions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SamplingRegions?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSkeletalMeshDataInterfaceSamplingRegions, __InBuffer);
			}
		}

		public static void SetSkeletalMeshDataInterfaceFilteredSockets(UNiagaraComponent NiagaraSystem, FString OverrideName, TArray<FName> FilteredSockets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FilteredSockets?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSkeletalMeshDataInterfaceFilteredSockets, __InBuffer);
			}
		}

		public static void SetSkeletalMeshDataInterfaceFilteredBones(UNiagaraComponent NiagaraSystem, FString OverrideName, TArray<FName> FilteredBones)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FilteredBones?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSkeletalMeshDataInterfaceFilteredBones, __InBuffer);
			}
		}

		public static void SetComponentNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject, UPrimitiveComponent Primitive, int CollisionGroup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Primitive?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = CollisionGroup;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetComponentNiagaraGPURayTracedCollisionGroup, __InBuffer);
			}
		}

		public static void SetActorNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject, AActor Actor, int CollisionGroup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = CollisionGroup;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetActorNiagaraGPURayTracedCollisionGroup, __InBuffer);
			}
		}

		public static void ReleaseNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject, int CollisionGroup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = CollisionGroup;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReleaseNiagaraGPURayTracedCollisionGroup, __InBuffer);
			}
		}

		public static void OverrideSystemUserVariableStaticMeshComponent(UNiagaraComponent NiagaraSystem, FString OverrideName, UStaticMeshComponent StaticMeshComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = StaticMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __OverrideSystemUserVariableStaticMeshComponent, __InBuffer);
			}
		}

		public static void OverrideSystemUserVariableStaticMesh(UNiagaraComponent NiagaraSystem, FString OverrideName, UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __OverrideSystemUserVariableStaticMesh, __InBuffer);
			}
		}

		public static void OverrideSystemUserVariableSkeletalMeshComponent(UNiagaraComponent NiagaraSystem, FString OverrideName, USkeletalMeshComponent SkeletalMeshComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SkeletalMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __OverrideSystemUserVariableSkeletalMeshComponent, __InBuffer);
			}
		}

		public static UNiagaraParameterCollectionInstance GetNiagaraParameterCollection(UObject WorldContextObject, UNiagaraParameterCollection Collection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Collection?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraParameterCollection, __InBuffer, __ReturnBuffer);

				return *(UNiagaraParameterCollectionInstance*)__ReturnBuffer;
			}
		}

		public static int AcquireNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AcquireNiagaraGPURayTracedCollisionGroup, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __SpawnSystemAttachedWithParams = 0;

		private static uint __SpawnSystemAttached = 0;

		private static uint __SpawnSystemAtLocationWithParams = 0;

		private static uint __SpawnSystemAtLocation = 0;

		private static uint __SetVolumeTextureObject = 0;

		private static uint __SetTextureObject = 0;

		private static uint __SetTexture2DArrayObject = 0;

		private static uint __SetSkeletalMeshDataInterfaceSamplingRegions = 0;

		private static uint __SetSkeletalMeshDataInterfaceFilteredSockets = 0;

		private static uint __SetSkeletalMeshDataInterfaceFilteredBones = 0;

		private static uint __SetComponentNiagaraGPURayTracedCollisionGroup = 0;

		private static uint __SetActorNiagaraGPURayTracedCollisionGroup = 0;

		private static uint __ReleaseNiagaraGPURayTracedCollisionGroup = 0;

		private static uint __OverrideSystemUserVariableStaticMeshComponent = 0;

		private static uint __OverrideSystemUserVariableStaticMesh = 0;

		private static uint __OverrideSystemUserVariableSkeletalMeshComponent = 0;

		private static uint __GetNiagaraParameterCollection = 0;

		private static uint __AcquireNiagaraGPURayTracedCollisionGroup = 0;
	}
}