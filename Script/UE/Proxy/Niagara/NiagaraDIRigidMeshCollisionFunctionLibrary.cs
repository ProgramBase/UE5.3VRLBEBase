using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDIRigidMeshCollisionFunctionLibrary")]
	public partial class UNiagaraDIRigidMeshCollisionFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDIRigidMeshCollisionFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetSourceActors(UNiagaraComponent NiagaraSystem, FName OverrideName, TArray<AActor> SourceActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SourceActors?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSourceActors, __InBuffer);
			}
		}

		private static uint __SetSourceActors = 0;
	}
}