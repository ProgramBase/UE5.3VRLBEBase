using Script.Library;
using Script.Engine;

namespace Script.CoreUObject
{
	public partial class FActorSpawnParameters : IGarbageCollectionHandle
	{
		public FName Name
		{
			get => FActorSpawnParametersImplementation.FActorSpawnParameters_GetNameImplementation(GarbageCollectionHandle);

			set => FActorSpawnParametersImplementation.FActorSpawnParameters_SetNameImplementation(GarbageCollectionHandle, value.GarbageCollectionHandle);
		}

		public AActor Template
		{
			get => FActorSpawnParametersImplementation.FActorSpawnParameters_GetTemplateImplementation(GarbageCollectionHandle);

			set => FActorSpawnParametersImplementation.FActorSpawnParameters_SetTemplateImplementation(GarbageCollectionHandle, value.GarbageCollectionHandle);
		}

		public AActor Owner
		{
			get => FActorSpawnParametersImplementation.FActorSpawnParameters_GetOwnerImplementation(GarbageCollectionHandle);

			set => FActorSpawnParametersImplementation.FActorSpawnParameters_SetOwnerImplementation(GarbageCollectionHandle, value.GarbageCollectionHandle);
		}

		public APawn Instigator
		{
			get => FActorSpawnParametersImplementation.FActorSpawnParameters_GetInstigatorImplementation(GarbageCollectionHandle);

			set => FActorSpawnParametersImplementation.FActorSpawnParameters_SetInstigatorImplementation(GarbageCollectionHandle, value.GarbageCollectionHandle);
		}

		public ULevel OverrideLevel
		{
			get => FActorSpawnParametersImplementation.FActorSpawnParameters_GetOverrideLevelImplementation(GarbageCollectionHandle);

			set => FActorSpawnParametersImplementation.FActorSpawnParameters_SetOverrideLevelImplementation(GarbageCollectionHandle, value.GarbageCollectionHandle);
		}

		public UChildActorComponent OverrideParentComponent
		{
			get => FActorSpawnParametersImplementation.FActorSpawnParameters_GetOverrideParentComponentImplementation(GarbageCollectionHandle);

			set => FActorSpawnParametersImplementation.FActorSpawnParameters_SetOverrideParentComponentImplementation(GarbageCollectionHandle, value.GarbageCollectionHandle);
		}

		public ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingOverride
		{
			get => FActorSpawnParametersImplementation.FActorSpawnParameters_GetSpawnCollisionHandlingOverrideImplementation(GarbageCollectionHandle);

			set => FActorSpawnParametersImplementation.FActorSpawnParameters_SetSpawnCollisionHandlingOverrideImplementation(GarbageCollectionHandle, value);
		}

		public ESpawnActorNameMode NameMode
		{
			get => FActorSpawnParametersImplementation.FActorSpawnParameters_GetNameModeImplementation(GarbageCollectionHandle);

			set => FActorSpawnParametersImplementation.FActorSpawnParameters_SetNameModeImplementation(GarbageCollectionHandle, value);
		}

		public EObjectFlags ObjectFlags
		{
			get => FActorSpawnParametersImplementation.FActorSpawnParameters_GetObjectFlagsImplementation(GarbageCollectionHandle);

			set => FActorSpawnParametersImplementation.FActorSpawnParameters_SetObjectFlagsImplementation(GarbageCollectionHandle, value);
		}

		public FActorSpawnParameters()
		{
			if (GetType() == typeof(FActorSpawnParameters))
			{
				FActorSpawnParametersImplementation.FActorSpawnParameters_FActorSpawnParametersImplementation(this);
			}
		}

		~FActorSpawnParameters()
		{
			FActorSpawnParametersImplementation.FActorSpawnParameters_DestructorImplementation(GarbageCollectionHandle);
		}

		public nint GarbageCollectionHandle { get; set; }
	}
}