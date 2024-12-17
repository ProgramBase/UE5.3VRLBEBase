using Script.CoreUObject;
using Script.Library;
using Script.Engine;
using Script.UnrealEd;

namespace Script.Persona
{
	[PathName("/Script/Persona.PersonaToolMenuContext")]
	public partial class UPersonaToolMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.PersonaToolMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual USkeleton GetSkeleton()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSkeleton, __ReturnBuffer);

				return *(USkeleton*)__ReturnBuffer;
			}
		}

		public virtual UDebugSkelMeshComponent GetPreviewMeshComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPreviewMeshComponent, __ReturnBuffer);

				return *(UDebugSkelMeshComponent*)__ReturnBuffer;
			}
		}

		public virtual USkeletalMesh GetMesh()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMesh, __ReturnBuffer);

				return *(USkeletalMesh*)__ReturnBuffer;
			}
		}

		public virtual UAnimBlueprint GetAnimBlueprint()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAnimBlueprint, __ReturnBuffer);

				return *(UAnimBlueprint*)__ReturnBuffer;
			}
		}

		public virtual UAnimationAsset GetAnimationAsset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAnimationAsset, __ReturnBuffer);

				return *(UAnimationAsset*)__ReturnBuffer;
			}
		}

		private static uint __GetSkeleton = 0;

		private static uint __GetPreviewMeshComponent = 0;

		private static uint __GetMesh = 0;

		private static uint __GetAnimBlueprint = 0;

		private static uint __GetAnimationAsset = 0;
	}
}