using Script.CoreUObject;
using Script.Library;
using Script.PhysicsCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.GameplayStatics")]
	public partial class UGameplayStatics : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.GameplayStatics");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void UnRetainAllSoundsInSoundClass(USoundClass InSoundClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSoundClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __UnRetainAllSoundsInSoundClass, __InBuffer);
			}
		}

		public static void UnloadStreamLevelBySoftObjectPtr(UObject WorldContextObject, TSoftObjectPtr<UWorld> Level, FLatentActionInfo LatentInfo, bool bShouldBlockOnUnload)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Level?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bShouldBlockOnUnload;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __UnloadStreamLevelBySoftObjectPtr, __InBuffer);
			}
		}

		public static void UnloadStreamLevel(UObject WorldContextObject, FName LevelName, FLatentActionInfo LatentInfo, bool bShouldBlockOnUnload)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LevelName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bShouldBlockOnUnload;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __UnloadStreamLevel, __InBuffer);
			}
		}

		/// <param name="OutLaunchVelocity">
		/// The launch velocity returned from this calculation
		/// </param>
		/// <param name="ProjectileStartLocation">
		/// Location the projectile is launched from
		/// </param>
		/// <param name="TargetActor">
		/// Actor that the projectile should hit in TimeToTarget seconds
		/// </param>
		/// <param name="TargetLocationOffset">
		/// Offset to apply to the location the projectile is aiming for
		/// </param>
		/// <param name="GravityZOverride">
		/// Optional override of WorldGravityZ
		/// </param>
		/// <param name="TimeToTarget">
		/// Time (in seconds) between the projectile being launched and the projectile hitting the TargetActor - clamped to be at least 0.1
		/// </param>
		public static bool SuggestProjectileVelocity_MovingTarget(UObject WorldContextObject, ref FVector OutLaunchVelocity, FVector ProjectileStartLocation, AActor TargetActor, FVector TargetLocationOffset, double GravityZOverride, double TimeToTarget, EDrawDebugTrace DrawDebugType, float DrawDebugTime, FLinearColor DrawDebugColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[69];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutLaunchVelocity?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ProjectileStartLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = TargetActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = TargetLocationOffset?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 40) = GravityZOverride;

				*(double*)(__InBuffer + 48) = TimeToTarget;

				*(byte*)(__InBuffer + 56) = (byte)DrawDebugType;

				*(float*)(__InBuffer + 57) = DrawDebugTime;

				*(nint*)(__InBuffer + 61) = DrawDebugColor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __SuggestProjectileVelocity_MovingTarget, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutLaunchVelocity = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="OutLaunchVelocity">
		/// Returns the launch velocity required to reach the EndPos
		/// </param>
		/// <param name="StartPos">
		/// Start position of the simulation
		/// </param>
		/// <param name="EndPos">
		/// Desired end location for the simulation
		/// </param>
		/// <param name="OverrideGravityZ">
		/// Optional override of WorldGravityZ
		/// </param>
		/// <param name="ArcParam">
		/// Change height of arc between 0.0-1.0 where 0.5 is the default medium arc, 0 is up, and 1 is directly toward EndPos.
		/// </param>
		public static bool SuggestProjectileVelocity_CustomArc(UObject WorldContextObject, ref FVector OutLaunchVelocity, FVector StartPos, FVector EndPos, float OverrideGravityZ, float ArcParam)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutLaunchVelocity?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = StartPos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = EndPos?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = OverrideGravityZ;

				*(float*)(__InBuffer + 36) = ArcParam;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __SuggestProjectileVelocity_CustomArc, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutLaunchVelocity = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Sound">
		/// - sound to play
		/// </param>
		/// <param name="AttachComponent">
		/// - Component to attach to.
		/// </param>
		/// <param name="AttachPointName">
		/// - Optional named point within the AttachComponent to play the sound at
		/// </param>
		/// <param name="Location">
		/// - Depending on the value of Location Type this is either a relative offset from 
		/// the attach component/point or an absolute world position that will be translated to a relative offset
		/// </param>
		/// <param name="Rotation">
		/// - Depending on the value of Location Type this is either a relative offset from
		/// the attach component/point or an absolute world rotation that will be translated to a relative offset
		/// </param>
		/// <param name="LocationType">
		/// - Specifies whether Location is a relative offset or an absolute world position
		/// </param>
		/// <param name="bStopWhenAttachedToDestroyed">
		/// - Specifies whether the sound should stop playing when the
		/// owner of the attach to component is destroyed.
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - A linear scalar multiplied with the volume, in order to make the sound louder or softer.
		/// </param>
		/// <param name="PitchMultiplier">
		/// - A linear scalar multiplied with the pitch.
		/// </param>
		/// <param name="StartTime">
		/// - How far in to the sound to begin playback at
		/// </param>
		/// <param name="AttenuationSettings">
		/// - Override attenuation settings package to play sound with
		/// </param>
		/// <param name="ConcurrencySettings">
		/// - Override concurrency settings package to play sound with
		/// </param>
		/// <param name="bAutoDestroy">
		/// - Whether the returned audio component will be automatically cleaned up when the sound finishes
		/// (by completing or stopping) or whether it can be reactivated
		/// </param>
		/// <returns>
		/// An audio component to manipulate the spawned sound
		/// </returns>
		public static UAudioComponent SpawnSoundAttached(USoundBase Sound, USceneComponent AttachToComponent, FName AttachPointName = null, FVector Location = null, FRotator Rotation = null, EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, bool bStopWhenAttachedToDestroyed = false, float VolumeMultiplier = 1.000000f, float PitchMultiplier = 1.000000f, float StartTime = 0.000000f, USoundAttenuation AttenuationSettings = null, USoundConcurrency ConcurrencySettings = null, bool bAutoDestroy = true)
		{
			unsafe
			{
				AttachPointName ??= new FName("None");

				Location ??= new FVector();

				Rotation ??= new FRotator();

				var __InBuffer = stackalloc byte[71];

				*(nint*)(__InBuffer) = Sound?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttachToComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AttachPointName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)LocationType;

				*(bool*)(__InBuffer + 41) = bStopWhenAttachedToDestroyed;

				*(float*)(__InBuffer + 42) = VolumeMultiplier;

				*(float*)(__InBuffer + 46) = PitchMultiplier;

				*(float*)(__InBuffer + 50) = StartTime;

				*(nint*)(__InBuffer + 54) = AttenuationSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 62) = ConcurrencySettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 70) = bAutoDestroy;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnSoundAttached, __InBuffer, __ReturnBuffer);

				return *(UAudioComponent*)__ReturnBuffer;
			}
		}

		/// <param name="Sound">
		/// - sound to play
		/// </param>
		/// <param name="Location">
		/// - World position to play sound at
		/// </param>
		/// <param name="Rotation">
		/// - World rotation to play sound at
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - A linear scalar multiplied with the volume, in order to make the sound louder or softer.
		/// </param>
		/// <param name="PitchMultiplier">
		/// - A linear scalar multiplied with the pitch.
		/// </param>
		/// <param name="StartTime">
		/// - How far in to the sound to begin playback at
		/// </param>
		/// <param name="AttenuationSettings">
		/// - Override attenuation settings package to play sound with
		/// </param>
		/// <param name="ConcurrencySettings">
		/// - Override concurrency settings package to play sound with
		/// </param>
		/// <param name="bAutoDestroy">
		/// - Whether the returned audio component will be automatically cleaned up when the sound finishes 
		/// (by completing or stopping) or whether it can be reactivated
		/// </param>
		/// <returns>
		/// An audio component to manipulate the spawned sound
		/// </returns>
		public static UAudioComponent SpawnSoundAtLocation(UObject WorldContextObject, USoundBase Sound, FVector Location, FRotator Rotation = null, float VolumeMultiplier = 1.000000f, float PitchMultiplier = 1.000000f, float StartTime = 0.000000f, USoundAttenuation AttenuationSettings = null, USoundConcurrency ConcurrencySettings = null, bool bAutoDestroy = true)
		{
			unsafe
			{
				Rotation ??= new FRotator();

				var __InBuffer = stackalloc byte[61];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sound?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = VolumeMultiplier;

				*(float*)(__InBuffer + 36) = PitchMultiplier;

				*(float*)(__InBuffer + 40) = StartTime;

				*(nint*)(__InBuffer + 44) = AttenuationSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 52) = ConcurrencySettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 60) = bAutoDestroy;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnSoundAtLocation, __InBuffer, __ReturnBuffer);

				return *(UAudioComponent*)__ReturnBuffer;
			}
		}

		/// <param name="Sound">
		/// - Sound to play.
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - A linear scalar multiplied with the volume, in order to make the sound louder or softer.
		/// </param>
		/// <param name="PitchMultiplier">
		/// - A linear scalar multiplied with the pitch.
		/// </param>
		/// <param name="StartTime">
		/// - How far in to the sound to begin playback at
		/// </param>
		/// <param name="ConcurrencySettings">
		/// - Override concurrency settings package to play sound with
		/// </param>
		/// <param name="PersistAcrossLevelTransition">
		/// - Whether the sound should continue to play when the map it was played in is unloaded
		/// </param>
		/// <param name="bAutoDestroy">
		/// - Whether the returned audio component will be automatically cleaned up when the sound finishes 
		/// (by completing or stopping) or whether it can be reactivated
		/// </param>
		/// <returns>
		/// An audio component to manipulate the spawned sound
		/// </returns>
		public static UAudioComponent SpawnSound2D(UObject WorldContextObject, USoundBase Sound, float VolumeMultiplier = 1.000000f, float PitchMultiplier = 1.000000f, float StartTime = 0.000000f, USoundConcurrency ConcurrencySettings = null, bool bPersistAcrossLevelTransition = false, bool bAutoDestroy = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[38];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sound?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = VolumeMultiplier;

				*(float*)(__InBuffer + 20) = PitchMultiplier;

				*(float*)(__InBuffer + 24) = StartTime;

				*(nint*)(__InBuffer + 28) = ConcurrencySettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 36) = bPersistAcrossLevelTransition;

				*(bool*)(__InBuffer + 37) = bAutoDestroy;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnSound2D, __InBuffer, __ReturnBuffer);

				return *(UAudioComponent*)__ReturnBuffer;
			}
		}

		public static UObject SpawnObject(TSubclassOf<UObject> ObjectClass, UObject Outer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ObjectClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Outer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnObject, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <param name="ForceFeedbackEffect">
		/// - effect to play
		/// </param>
		/// <param name="AttachComponent">
		/// - Component to attach to.
		/// </param>
		/// <param name="AttachPointName">
		/// - Optional named point within the AttachComponent to attach to
		/// </param>
		/// <param name="Location">
		/// - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
		/// </param>
		/// <param name="Rotation">
		/// - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset
		/// </param>
		/// <param name="LocationType">
		/// - Specifies whether Location is a relative offset or an absolute world position
		/// </param>
		/// <param name="bStopWhenAttachedToDestroyed">
		/// - Specifies whether the feedback effect should stop playing when the owner of the attach to component is destroyed.
		/// </param>
		/// <param name="IntensityMultiplier">
		/// - Intensity multiplier 
		/// </param>
		/// <param name="StartTime">
		/// - How far in to the feedback effect to begin playback at
		/// </param>
		/// <param name="AttenuationSettings">
		/// - Override attenuation settings package to play effect with
		/// </param>
		/// <param name="bAutoDestroy">
		/// - Whether the returned force feedback component will be automatically cleaned up when the feedback patern finishes (by completing or stopping) or whether it can be reactivated
		/// </param>
		/// <returns>
		/// Force Feedback Component to manipulate the playing feedback effect with
		/// </returns>
		public static UForceFeedbackComponent SpawnForceFeedbackAttached(UForceFeedbackEffect ForceFeedbackEffect, USceneComponent AttachToComponent, FName AttachPointName = null, FVector Location = null, FRotator Rotation = null, EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, bool bStopWhenAttachedToDestroyed = false, bool bLooping = false, float IntensityMultiplier = 1.000000f, float StartTime = 0.000000f, UForceFeedbackAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			unsafe
			{
				AttachPointName ??= new FName("None");

				Location ??= new FVector();

				Rotation ??= new FRotator();

				var __InBuffer = stackalloc byte[60];

				*(nint*)(__InBuffer) = ForceFeedbackEffect?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttachToComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AttachPointName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)LocationType;

				*(bool*)(__InBuffer + 41) = bStopWhenAttachedToDestroyed;

				*(bool*)(__InBuffer + 42) = bLooping;

				*(float*)(__InBuffer + 43) = IntensityMultiplier;

				*(float*)(__InBuffer + 47) = StartTime;

				*(nint*)(__InBuffer + 51) = AttenuationSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 59) = bAutoDestroy;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnForceFeedbackAttached, __InBuffer, __ReturnBuffer);

				return *(UForceFeedbackComponent*)__ReturnBuffer;
			}
		}

		/// <param name="ForceFeedbackEffect">
		/// - effect to play
		/// </param>
		/// <param name="Location">
		/// - World position to center the effect at
		/// </param>
		/// <param name="Rotation">
		/// - World rotation to center the effect at
		/// </param>
		/// <param name="IntensityMultiplier">
		/// - Intensity multiplier 
		/// </param>
		/// <param name="StartTime">
		/// - How far in to the feedback effect to begin playback at
		/// </param>
		/// <param name="AttenuationSettings">
		/// - Override attenuation settings package to play effect with
		/// </param>
		/// <param name="bAutoDestroy">
		/// - Whether the returned force feedback component will be automatically cleaned up when the feedback pattern finishes (by completing or stopping) or whether it can be reactivated
		/// </param>
		/// <returns>
		/// Force Feedback Component to manipulate the playing feedback effect with
		/// </returns>
		public static UForceFeedbackComponent SpawnForceFeedbackAtLocation(UObject WorldContextObject, UForceFeedbackEffect ForceFeedbackEffect, FVector Location, FRotator Rotation = null, bool bLooping = false, float IntensityMultiplier = 1.000000f, float StartTime = 0.000000f, UForceFeedbackAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			unsafe
			{
				Rotation ??= new FRotator();

				var __InBuffer = stackalloc byte[50];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ForceFeedbackEffect?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bLooping;

				*(float*)(__InBuffer + 33) = IntensityMultiplier;

				*(float*)(__InBuffer + 37) = StartTime;

				*(nint*)(__InBuffer + 41) = AttenuationSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 49) = bAutoDestroy;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnForceFeedbackAtLocation, __InBuffer, __ReturnBuffer);

				return *(UForceFeedbackComponent*)__ReturnBuffer;
			}
		}

		/// <param name="EmitterTemplate">
		/// - particle system to create
		/// </param>
		/// <param name="AttachComponent">
		/// - Component to attach to.
		/// </param>
		/// <param name="AttachPointName">
		/// - Optional named point within the AttachComponent to spawn the emitter at
		/// </param>
		/// <param name="Location">
		/// - Depending on the value of LocationType this is either a relative offset from the attach component/point or an absolute world location that will be translated to a relative offset (if LocationType is KeepWorldPosition).
		/// </param>
		/// <param name="Rotation">
		/// - Depending on the value of LocationType this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset (if LocationType is KeepWorldPosition).
		/// </param>
		/// <param name="Scale">
		/// - Depending on the value of LocationType this is either a relative scale from the attach component or an absolute world scale that will be translated to a relative scale (if LocationType is KeepWorldPosition).
		/// </param>
		/// <param name="LocationType">
		/// - Specifies whether Location is a relative offset or an absolute world position
		/// </param>
		/// <param name="bAutoDestroy">
		/// - Whether the component will automatically be destroyed when the particle system completes playing or whether it can be reactivated
		/// </param>
		/// <param name="PoolingMethod">
		/// - Method used for pooling this component. Defaults to none.
		/// </param>
		/// <param name="bAutoActivate">
		/// - Whether the component will be automatically activated on creation.
		/// </param>
		public static UParticleSystemComponent SpawnEmitterAttached(UParticleSystem EmitterTemplate, USceneComponent AttachToComponent, FName AttachPointName = null, FVector Location = null, FRotator Rotation = null, FVector Scale = null, EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, bool bAutoDestroy = true, EPSCPoolMethod PoolingMethod = EPSCPoolMethod.None, bool bAutoActivate = true)
		{
			unsafe
			{
				AttachPointName ??= new FName("None");

				Location ??= new FVector();

				Rotation ??= new FRotator();

				Scale ??= new FVector(1.000000, 1.000000, 1.000000);

				var __InBuffer = stackalloc byte[52];

				*(nint*)(__InBuffer) = EmitterTemplate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttachToComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AttachPointName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = Scale?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 48) = (byte)LocationType;

				*(bool*)(__InBuffer + 49) = bAutoDestroy;

				*(byte*)(__InBuffer + 50) = (byte)PoolingMethod;

				*(bool*)(__InBuffer + 51) = bAutoActivate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnEmitterAttached, __InBuffer, __ReturnBuffer);

				return *(UParticleSystemComponent*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContextObject">
		/// - Object that we can obtain a world context from
		/// </param>
		/// <param name="EmitterTemplate">
		/// - particle system to create
		/// </param>
		/// <param name="Location">
		/// - location to place the effect in world space
		/// </param>
		/// <param name="Rotation">
		/// - rotation to place the effect in world space	
		/// </param>
		/// <param name="Scale">
		/// - scale to create the effect at
		/// </param>
		/// <param name="bAutoDestroy">
		/// - Whether the component will automatically be destroyed when the particle system completes playing or whether it can be reactivated
		/// </param>
		/// <param name="PoolingMethod">
		/// - Method used for pooling this component. Defaults to none.
		/// </param>
		/// <param name="bAutoActivate">
		/// - Whether the component will be automatically activated on creation.
		/// </param>
		public static UParticleSystemComponent SpawnEmitterAtLocation(UObject WorldContextObject, UParticleSystem EmitterTemplate, FVector Location, FRotator Rotation = null, FVector Scale = null, bool bAutoDestroy = true, EPSCPoolMethod PoolingMethod = EPSCPoolMethod.None, bool bAutoActivateSystem = true)
		{
			unsafe
			{
				Rotation ??= new FRotator();

				Scale ??= new FVector(1.000000, 1.000000, 1.000000);

				var __InBuffer = stackalloc byte[43];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = EmitterTemplate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Scale?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 40) = bAutoDestroy;

				*(byte*)(__InBuffer + 41) = (byte)PoolingMethod;

				*(bool*)(__InBuffer + 42) = bAutoActivateSystem;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnEmitterAtLocation, __InBuffer, __ReturnBuffer);

				return *(UParticleSystemComponent*)__ReturnBuffer;
			}
		}

		/// <param name="Dialogue">
		/// - dialogue to play
		/// </param>
		/// <param name="Context">
		/// - context the dialogue is to play in
		/// </param>
		/// <param name="AttachComponent">
		/// - Component to attach to.
		/// </param>
		/// <param name="AttachPointName">
		/// - Optional named point within the AttachComponent to play the sound at
		/// </param>
		/// <param name="Location">
		/// - Depending on the value of Location Type this is either a relative offset from the 
		/// attach component/point or an absolute world position that will be translated to a relative offset
		/// </param>
		/// <param name="Rotation">
		/// - Depending on the value of Location Type this is either a relative offset from the 
		/// attach component/point or an absolute world rotation that will be translated to a relative offset
		/// </param>
		/// <param name="LocationType">
		/// - Specifies whether Location is a relative offset or an absolute world position
		/// </param>
		/// <param name="bStopWhenAttachedToDestroyed">
		/// - Specifies whether the sound should stop playing when the owner its attached
		/// to is destroyed.
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - A linear scalar multiplied with the volume, in order to make the sound louder or softer.
		/// </param>
		/// <param name="PitchMultiplier">
		/// - A linear scalar multiplied with the pitch.
		/// </param>
		/// <param name="StartTime">
		/// - How far in to the dialogue to begin playback at
		/// </param>
		/// <param name="AttenuationSettings">
		/// - Override attenuation settings package to play sound with
		/// </param>
		/// <param name="bAutoDestroy">
		/// - Whether the returned audio component will be automatically cleaned up when the sound finishes 
		/// (by completing or stopping) or whether it can be reactivated
		/// </param>
		/// <returns>
		/// Audio Component to manipulate the playing dialogue with
		/// </returns>
		public static UAudioComponent SpawnDialogueAttached(UDialogueWave Dialogue, FDialogueContext Context, USceneComponent AttachToComponent, FName AttachPointName = null, FVector Location = null, FRotator Rotation = null, EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, bool bStopWhenAttachedToDestroyed = false, float VolumeMultiplier = 1.000000f, float PitchMultiplier = 1.000000f, float StartTime = 0.000000f, USoundAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			unsafe
			{
				AttachPointName ??= new FName("None");

				Location ??= new FVector();

				Rotation ??= new FRotator();

				var __InBuffer = stackalloc byte[71];

				*(nint*)(__InBuffer) = Dialogue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AttachToComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = AttachPointName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 48) = (byte)LocationType;

				*(bool*)(__InBuffer + 49) = bStopWhenAttachedToDestroyed;

				*(float*)(__InBuffer + 50) = VolumeMultiplier;

				*(float*)(__InBuffer + 54) = PitchMultiplier;

				*(float*)(__InBuffer + 58) = StartTime;

				*(nint*)(__InBuffer + 62) = AttenuationSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 70) = bAutoDestroy;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnDialogueAttached, __InBuffer, __ReturnBuffer);

				return *(UAudioComponent*)__ReturnBuffer;
			}
		}

		/// <param name="Dialogue">
		/// - Dialogue to play
		/// </param>
		/// <param name="Context">
		/// - Context the dialogue is to play in
		/// </param>
		/// <param name="Location">
		/// - World position to play dialogue at
		/// </param>
		/// <param name="Rotation">
		/// - World rotation to play dialogue at
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - A linear scalar multiplied with the volume, in order to make the sound louder or softer.
		/// </param>
		/// <param name="PitchMultiplier">
		/// - A linear scalar multiplied with the pitch.
		/// </param>
		/// <param name="StartTime">
		/// - How far into the dialogue to begin playback at
		/// </param>
		/// <param name="AttenuationSettings">
		/// - Override attenuation settings package to play sound with
		/// </param>
		/// <param name="bAutoDestroy">
		/// - Whether the returned audio component will be automatically cleaned up when the sound finishes
		/// (by completing or stopping) or whether it can be reactivated
		/// </param>
		/// <returns>
		/// Audio Component to manipulate the playing dialogue with
		/// </returns>
		public static UAudioComponent SpawnDialogueAtLocation(UObject WorldContextObject, UDialogueWave Dialogue, FDialogueContext Context, FVector Location, FRotator Rotation = null, float VolumeMultiplier = 1.000000f, float PitchMultiplier = 1.000000f, float StartTime = 0.000000f, USoundAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			unsafe
			{
				Rotation ??= new FRotator();

				var __InBuffer = stackalloc byte[61];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Dialogue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = VolumeMultiplier;

				*(float*)(__InBuffer + 44) = PitchMultiplier;

				*(float*)(__InBuffer + 48) = StartTime;

				*(nint*)(__InBuffer + 52) = AttenuationSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 60) = bAutoDestroy;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnDialogueAtLocation, __InBuffer, __ReturnBuffer);

				return *(UAudioComponent*)__ReturnBuffer;
			}
		}

		/// <param name="Dialogue">
		/// - dialogue to play
		/// </param>
		/// <param name="Context">
		/// - context the dialogue is to play in
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - A linear scalar multiplied with the volume, in order to make the sound louder or softer.
		/// </param>
		/// <param name="PitchMultiplier">
		/// - A linear scalar multiplied with the pitch.
		/// </param>
		/// <param name="StartTime">
		/// - How far in to the dialogue to begin playback at
		/// </param>
		/// <param name="bAutoDestroy">
		/// - Whether the returned audio component will be automatically cleaned up when the sound
		/// finishes (by completing or stopping) or whether it can be reactivated
		/// </param>
		/// <returns>
		/// An audio component to manipulate the spawned sound
		/// </returns>
		public static UAudioComponent SpawnDialogue2D(UObject WorldContextObject, UDialogueWave Dialogue, FDialogueContext Context, float VolumeMultiplier = 1.000000f, float PitchMultiplier = 1.000000f, float StartTime = 0.000000f, bool bAutoDestroy = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Dialogue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = VolumeMultiplier;

				*(float*)(__InBuffer + 28) = PitchMultiplier;

				*(float*)(__InBuffer + 32) = StartTime;

				*(bool*)(__InBuffer + 36) = bAutoDestroy;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnDialogue2D, __InBuffer, __ReturnBuffer);

				return *(UAudioComponent*)__ReturnBuffer;
			}
		}

		/// <param name="DecalMaterial">
		/// - decal's material
		/// </param>
		/// <param name="DecalSize">
		/// - size of decal
		/// </param>
		/// <param name="AttachComponent">
		/// - Component to attach to.
		/// </param>
		/// <param name="AttachPointName">
		/// - Optional named point within the AttachComponent to spawn the emitter at
		/// </param>
		/// <param name="Location">
		/// - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
		/// </param>
		/// <param name="Rotation">
		/// - Depending on the value of LocationType this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a realative offset
		/// </param>
		/// <param name="LocationType">
		/// - Specifies whether Location is a relative offset or an absolute world position
		/// </param>
		/// <param name="LifeSpan">
		/// - destroy decal component after time runs out (0 = infinite)
		/// </param>
		public static UDecalComponent SpawnDecalAttached(UMaterialInterface DecalMaterial, FVector DecalSize, USceneComponent AttachToComponent, FName AttachPointName = null, FVector Location = null, FRotator Rotation = null, EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, float LifeSpan = 0.000000f)
		{
			unsafe
			{
				AttachPointName ??= new FName("None");

				Location ??= new FVector();

				Rotation ??= new FRotator();

				var __InBuffer = stackalloc byte[53];

				*(nint*)(__InBuffer) = DecalMaterial?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DecalSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AttachToComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = AttachPointName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 48) = (byte)LocationType;

				*(float*)(__InBuffer + 49) = LifeSpan;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnDecalAttached, __InBuffer, __ReturnBuffer);

				return *(UDecalComponent*)__ReturnBuffer;
			}
		}

		/// <param name="DecalMaterial">
		/// - decal's material
		/// </param>
		/// <param name="DecalSize">
		/// - size of decal
		/// </param>
		/// <param name="Location">
		/// - location to place the decal in world space
		/// </param>
		/// <param name="Rotation">
		/// - rotation to place the decal in world space	
		/// </param>
		/// <param name="LifeSpan">
		/// - destroy decal component after time runs out (0 = infinite)
		/// </param>
		public static UDecalComponent SpawnDecalAtLocation(UObject WorldContextObject, UMaterialInterface DecalMaterial, FVector DecalSize, FVector Location, FRotator Rotation = null, float LifeSpan = 0.000000f)
		{
			unsafe
			{
				Rotation ??= new FRotator(-90.000000, 0.000000, 0.000000);

				var __InBuffer = stackalloc byte[44];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DecalMaterial?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DecalSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = LifeSpan;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnDecalAtLocation, __InBuffer, __ReturnBuffer);

				return *(UDecalComponent*)__ReturnBuffer;
			}
		}

		public static void SetWorldOriginLocation(UObject WorldContextObject, FIntVector NewLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewLocation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetWorldOriginLocation, __InBuffer);
			}
		}

		public static void SetViewportMouseCaptureMode(UObject WorldContextObject, EMouseCaptureMode MouseCaptureMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)MouseCaptureMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetViewportMouseCaptureMode, __InBuffer);
			}
		}

		/// <param name="bEnabled">
		/// will enable subtitle drawing if true, disable if false.
		/// </param>
		public static void SetSubtitlesEnabled(bool bEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSubtitlesEnabled, __InBuffer);
			}
		}

		/// <param name="InSoundMixModifier">
		/// The sound mix to modify.
		/// </param>
		/// <param name="InSoundClass">
		/// The sound class to override (or add) in the sound mix.
		/// </param>
		/// <param name="Volume">
		/// The volume scale to set the sound class adjuster to.
		/// </param>
		/// <param name="Pitch">
		/// The pitch scale to set the sound class adjuster to.
		/// </param>
		/// <param name="FadeInTime">
		/// The interpolation time to use to go from the current sound class adjuster values to the new values.
		/// </param>
		/// <param name="bApplyToChildren">
		/// Whether or not to apply this override to the sound class' children or to just the specified sound class.
		/// </param>
		public static void SetSoundMixClassOverride(UObject WorldContextObject, USoundMix InSoundMixModifier, USoundClass InSoundClass, float Volume = 1.000000f, float Pitch = 1.000000f, float FadeInTime = 1.000000f, bool bApplyToChildren = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSoundMixModifier?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSoundClass?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Volume;

				*(float*)(__InBuffer + 28) = Pitch;

				*(float*)(__InBuffer + 32) = FadeInTime;

				*(bool*)(__InBuffer + 36) = bApplyToChildren;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSoundMixClassOverride, __InBuffer);
			}
		}

		/// <param name="SoundClass">
		/// - Sound class to to use to set the attenuation distance scale on.
		/// </param>
		/// <param name="DistanceAttenuationScale">
		/// - A scalar for the attenuation distance used for computing distance attenuation. 
		/// </param>
		/// <param name="TimeSec">
		/// - A time value to linearly interpolate from the current distance attenuation scale value to the new value.
		/// </param>
		public static void SetSoundClassDistanceScale(UObject WorldContextObject, USoundClass SoundClass, float DistanceAttenuationScale, float TimeSec = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SoundClass?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DistanceAttenuationScale;

				*(float*)(__InBuffer + 20) = TimeSec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSoundClassDistanceScale, __InBuffer);
			}
		}

		/// <param name="Player">
		/// The player controller of the player to change the platform user of
		/// </param>
		/// <param name="PlatformUserId">
		/// The platform user id to assign this player
		/// </param>
		public static void SetPlayerPlatformUserId(APlayerController PlayerController, FPlatformUserId UserId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserId?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetPlayerPlatformUserId, __InBuffer);
			}
		}

		/// <param name="Player">
		/// The player controller of the player to change the controller ID of
		/// </param>
		/// <param name="ControllerId">
		/// The controller ID to assign to this player
		/// </param>
		public static void SetPlayerControllerID(APlayerController Player, int ControllerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ControllerId;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetPlayerControllerID, __InBuffer);
			}
		}

		/// <param name="MaxChannelCountScale">
		/// The percentage of the original voice count to set the max number of voices to
		/// </param>
		public static void SetMaxAudioChannelsScaled(UObject WorldContextObject, float MaxChannelCountScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = MaxChannelCountScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetMaxAudioChannelsScaled, __InBuffer);
			}
		}

		/// <param name="TimeDilation">
		/// value to set the global time dilation to
		/// </param>
		public static void SetGlobalTimeDilation(UObject WorldContextObject, float TimeDilation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = TimeDilation;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetGlobalTimeDilation, __InBuffer);
			}
		}

		/// <param name="PitchModulation">
		/// - A pitch modulation value to globally set.
		/// </param>
		/// <param name="TimeSec">
		/// - A time value to linearly interpolate the global modulation pitch over from it's current value.
		/// </param>
		public static void SetGlobalPitchModulation(UObject WorldContextObject, float PitchModulation, float TimeSec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = PitchModulation;

				*(float*)(__InBuffer + 12) = TimeSec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetGlobalPitchModulation, __InBuffer);
			}
		}

		/// <param name="FocusAzimuthScale">
		/// - An angle scale value used to scale the azimuth angle that defines where sounds are in-focus.
		/// </param>
		/// <param name="NonFocusAzimuthScale">
		/// - An angle scale value used to scale the azimuth angle that defines where sounds are out-of-focus.
		/// </param>
		/// <param name="FocusDistanceScale">
		/// - A distance scale value to use for sounds which are in-focus. Values < 1.0 will reduce perceived 
		/// distance to sounds, values > 1.0 will increase perceived distance to in-focus sounds.
		/// </param>
		/// <param name="NonFocusDistanceScale">
		/// - A distance scale value to use for sounds which are out-of-focus. Values < 1.0 will reduce 
		/// perceived distance to sounds, values > 1.0 will increase perceived distance to in-focus sounds.
		/// </param>
		/// <param name="FocusVolumeScale">
		/// - A volume attenuation value to use for sounds which are in-focus.
		/// </param>
		/// <param name="NonFocusVolumeScale">
		/// - A volume attenuation value to use for sounds which are out-of-focus.
		/// </param>
		/// <param name="FocusPriorityScale">
		/// - A priority scale value (> 0.0) to use for sounds which are in-focus. Values < 1.0 will reduce
		/// the priority of in-focus sounds, values > 1.0 will increase the priority of in-focus sounds.
		/// </param>
		/// <param name="NonFocusPriorityScale">
		/// - A priority scale value (> 0.0) to use for sounds which are out-of-focus. Values < 1.0 will
		/// reduce the priority of sounds out-of-focus sounds, values > 1.0 will increase the priority of
		/// out-of-focus sounds.
		/// </param>
		public static void SetGlobalListenerFocusParameters(UObject WorldContextObject, float FocusAzimuthScale = 1.000000f, float NonFocusAzimuthScale = 1.000000f, float FocusDistanceScale = 1.000000f, float NonFocusDistanceScale = 1.000000f, float FocusVolumeScale = 1.000000f, float NonFocusVolumeScale = 1.000000f, float FocusPriorityScale = 1.000000f, float NonFocusPriorityScale = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = FocusAzimuthScale;

				*(float*)(__InBuffer + 12) = NonFocusAzimuthScale;

				*(float*)(__InBuffer + 16) = FocusDistanceScale;

				*(float*)(__InBuffer + 20) = NonFocusDistanceScale;

				*(float*)(__InBuffer + 24) = FocusVolumeScale;

				*(float*)(__InBuffer + 28) = NonFocusVolumeScale;

				*(float*)(__InBuffer + 32) = FocusPriorityScale;

				*(float*)(__InBuffer + 36) = NonFocusPriorityScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetGlobalListenerFocusParameters, __InBuffer);
			}
		}

		/// <param name="bPaused">
		/// Whether the game should be paused or not
		/// </param>
		/// <returns>
		/// Whether the game was successfully paused/unpaused
		/// </returns>
		public static bool SetGamePaused(UObject WorldContextObject, bool bPaused)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bPaused;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetGamePaused, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="bDisable">
		/// Whether the viewport should split screen between local players or not
		/// </param>
		public static void SetForceDisableSplitscreen(UObject WorldContextObject, bool bDisable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bDisable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetForceDisableSplitscreen, __InBuffer);
			}
		}

		/// <param name="bEnable">
		/// Whether the world should be rendered or not
		/// </param>
		public static void SetEnableWorldRendering(UObject WorldContextObject, bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetEnableWorldRendering, __InBuffer);
			}
		}

		public static void SetBaseSoundMix(UObject WorldContextObject, USoundMix InSoundMix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSoundMix?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBaseSoundMix, __InBuffer);
			}
		}

		public static bool SetActiveSpatialPluginByName(UObject WorldContextObject, FName InPluginName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPluginName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetActiveSpatialPluginByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// This will write out all non-transient properties, the SaveGame property flag is not checked
		/// </note>
		/// <param name="SaveGameObject">
		/// Object that contains data about the save game that we want to write out
		/// </param>
		/// <param name="SlotName">
		/// Name of save game slot to save to.
		/// </param>
		/// <param name="UserIndex">
		/// The platform user index that identifies the user doing the saving, ignored on some platforms.
		/// </param>
		/// <returns>
		/// Whether we successfully saved this information
		/// </returns>
		public static bool SaveGameToSlot(USaveGame SaveGameObject, FString SlotName, int UserIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = SaveGameObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SlotName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = UserIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SaveGameToSlot, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Player">
		/// The player controller of the player to be removed
		/// </param>
		/// <param name="bDestroyPawn">
		/// Whether the controlled pawn should be deleted as well
		/// </param>
		public static void RemovePlayer(APlayerController Player, bool bDestroyPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bDestroyPawn;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemovePlayer, __InBuffer);
			}
		}

		public static FVector RebaseZeroOriginOntoLocal(UObject WorldContextObject, FVector WorldLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RebaseZeroOriginOntoLocal, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector RebaseLocalOriginOntoZero(UObject WorldContextObject, FVector WorldLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RebaseLocalOriginOntoZero, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="InSoundMixModifier">
		/// The Sound Mix Modifier to add to the system
		/// </param>
		public static void PushSoundMixModifier(UObject WorldContextObject, USoundMix InSoundMixModifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSoundMixModifier?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PushSoundMixModifier, __InBuffer);
			}
		}

		/// <param name="Player">
		/// Project using this player's view.
		/// </param>
		/// <param name="WorldPosition">
		/// World position to project.
		/// </param>
		/// <param name="ScreenPosition">
		/// (out) Corresponding 2D position in screen space
		/// </param>
		/// <param name="bPlayerViewportRelative">
		/// Should this be relative to the player viewport subregion (useful when using player attached widgets in split screen)
		/// </param>
		public static bool ProjectWorldToScreen(APlayerController Player, FVector WorldPosition, ref FVector2D ScreenPosition, bool bPlayerViewportRelative)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WorldPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bPlayerViewportRelative;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ProjectWorldToScreen, __InBuffer, __OutBuffer, __ReturnBuffer);

				ScreenPosition = *(FVector2D*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void PrimeSound(USoundBase InSound)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSound?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PrimeSound, __InBuffer);
			}
		}

		public static void PrimeAllSoundsInSoundClass(USoundClass InSoundClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSoundClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PrimeAllSoundsInSoundClass, __InBuffer);
			}
		}

		/// <param name="InSoundMixModifier">
		/// The Sound Mix Modifier to remove from the system
		/// </param>
		public static void PopSoundMixModifier(UObject WorldContextObject, USoundMix InSoundMixModifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSoundMixModifier?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PopSoundMixModifier, __InBuffer);
			}
		}

		/// <param name="WorldContextObject">
		/// - Object that we can obtain a world context from
		/// </param>
		/// <param name="Shake">
		/// - Camera shake asset to use
		/// </param>
		/// <param name="Epicenter">
		/// - location to place the effect in world space
		/// </param>
		/// <param name="InnerRadius">
		/// - Cameras inside this radius are ignored
		/// </param>
		/// <param name="OuterRadius">
		/// - Cameras outside of InnerRadius and inside this are effected
		/// </param>
		/// <param name="Falloff">
		/// - Affects falloff of effect as it nears OuterRadius
		/// </param>
		/// <param name="bOrientShakeTowardsEpicenter">
		/// - Changes the rotation of shake to point towards epicenter instead of forward
		/// </param>
		public static void PlayWorldCameraShake(UObject WorldContextObject, TSubclassOf<UCameraShakeBase> Shake, FVector Epicenter, float InnerRadius, float OuterRadius, float Falloff = 1.000000f, bool bOrientShakeTowardsEpicenter = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Shake?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Epicenter?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = InnerRadius;

				*(float*)(__InBuffer + 28) = OuterRadius;

				*(float*)(__InBuffer + 32) = Falloff;

				*(bool*)(__InBuffer + 36) = bOrientShakeTowardsEpicenter;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PlayWorldCameraShake, __InBuffer);
			}
		}

		/// <param name="Sound">
		/// - sound to play
		/// </param>
		/// <param name="Location">
		/// - World position to play sound at
		/// </param>
		/// <param name="Rotation">
		/// - World rotation to play sound at
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - A linear scalar multiplied with the volume, in order to make the sound louder or softer.
		/// </param>
		/// <param name="PitchMultiplier">
		/// - A linear scalar multiplied with the pitch.
		/// </param>
		/// <param name="StartTime">
		/// - How far in to the sound to begin playback at
		/// </param>
		/// <param name="AttenuationSettings">
		/// - Override attenuation settings package to play sound with
		/// </param>
		/// <param name="ConcurrencySettings">
		/// - Override concurrency settings package to play sound with
		/// </param>
		/// <param name="OwningActor">
		/// - The actor to use as the "owner" for concurrency settings purposes. Allows PlaySound calls
		/// to do a concurrency limit per owner.
		/// </param>
		public static void PlaySoundAtLocation(UObject WorldContextObject, USoundBase Sound, FVector Location, FRotator Rotation, float VolumeMultiplier = 1.000000f, float PitchMultiplier = 1.000000f, float StartTime = 0.000000f, USoundAttenuation AttenuationSettings = null, USoundConcurrency ConcurrencySettings = null, AActor OwningActor = null, UInitialActiveSoundParams InitialParams = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[76];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sound?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = VolumeMultiplier;

				*(float*)(__InBuffer + 36) = PitchMultiplier;

				*(float*)(__InBuffer + 40) = StartTime;

				*(nint*)(__InBuffer + 44) = AttenuationSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 52) = ConcurrencySettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 60) = OwningActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 68) = InitialParams?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PlaySoundAtLocation, __InBuffer);
			}
		}

		/// <param name="Sound">
		/// - Sound to play.
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - A linear scalar multiplied with the volume, in order to make the sound louder or softer.
		/// </param>
		/// <param name="PitchMultiplier">
		/// - A linear scalar multiplied with the pitch.
		/// </param>
		/// <param name="StartTime">
		/// - How far in to the sound to begin playback at
		/// </param>
		/// <param name="ConcurrencySettings">
		/// - Override concurrency settings package to play sound with
		/// </param>
		/// <param name="OwningActor">
		/// - The actor to use as the "owner" for concurrency settings purposes. 
		/// Allows PlaySound calls to do a concurrency limit per owner.
		/// </param>
		/// <param name="bIsUISound">
		/// - True if sound is UI related, else false
		/// </param>
		public static void PlaySound2D(UObject WorldContextObject, USoundBase Sound, float VolumeMultiplier = 1.000000f, float PitchMultiplier = 1.000000f, float StartTime = 0.000000f, USoundConcurrency ConcurrencySettings = null, AActor OwningActor = null, bool bIsUISound = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[45];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sound?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = VolumeMultiplier;

				*(float*)(__InBuffer + 20) = PitchMultiplier;

				*(float*)(__InBuffer + 24) = StartTime;

				*(nint*)(__InBuffer + 28) = ConcurrencySettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = OwningActor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 44) = bIsUISound;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PlaySound2D, __InBuffer);
			}
		}

		/// <param name="Dialogue">
		/// - dialogue to play
		/// </param>
		/// <param name="Context">
		/// - context the dialogue is to play in
		/// </param>
		/// <param name="Location">
		/// - World position to play dialogue at
		/// </param>
		/// <param name="Rotation">
		/// - World rotation to play dialogue at
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - A linear scalar multiplied with the volume, in order to make the sound louder or softer.
		/// </param>
		/// <param name="PitchMultiplier">
		/// - A linear scalar multiplied with the pitch.
		/// </param>
		/// <param name="StartTime">
		/// - How far in to the dialogue to begin playback at
		/// </param>
		/// <param name="AttenuationSettings">
		/// - Override attenuation settings package to play sound with
		/// </param>
		public static void PlayDialogueAtLocation(UObject WorldContextObject, UDialogueWave Dialogue, FDialogueContext Context, FVector Location, FRotator Rotation, float VolumeMultiplier = 1.000000f, float PitchMultiplier = 1.000000f, float StartTime = 0.000000f, USoundAttenuation AttenuationSettings = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[60];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Dialogue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = VolumeMultiplier;

				*(float*)(__InBuffer + 44) = PitchMultiplier;

				*(float*)(__InBuffer + 48) = StartTime;

				*(nint*)(__InBuffer + 52) = AttenuationSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PlayDialogueAtLocation, __InBuffer);
			}
		}

		/// <param name="Dialogue">
		/// - dialogue to play
		/// </param>
		/// <param name="Context">
		/// - context the dialogue is to play in
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - A linear scalar multiplied with the volume, in order to make the sound louder or softer.
		/// </param>
		/// <param name="PitchMultiplier">
		/// - A linear scalar multiplied with the pitch.
		/// </param>
		/// <param name="StartTime">
		/// - How far in to the dialogue to begin playback at
		/// </param>
		public static void PlayDialogue2D(UObject WorldContextObject, UDialogueWave Dialogue, FDialogueContext Context, float VolumeMultiplier = 1.000000f, float PitchMultiplier = 1.000000f, float StartTime = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Dialogue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = VolumeMultiplier;

				*(float*)(__InBuffer + 28) = PitchMultiplier;

				*(float*)(__InBuffer + 32) = StartTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PlayDialogue2D, __InBuffer);
			}
		}

		/// <param name="Options">
		/// The string containing the options.
		/// </param>
		/// <param name="Key">
		/// The key to find the value of in Options.
		/// </param>
		/// <returns>
		/// The value associated with Key if Key found in Options string.
		/// </returns>
		public static FString ParseOption(FString Options, FString Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Options?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ParseOption, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Level">
		/// the level to open
		/// </param>
		/// <param name="bAbsolute">
		/// if true options are reset, if false options are carried over from current level
		/// </param>
		/// <param name="Options">
		/// a string of options to use for the travel URL
		/// </param>
		public static void OpenLevelBySoftObjectPtr(UObject WorldContextObject, TSoftObjectPtr<UWorld> Level, bool bAbsolute = true, FString Options = null)
		{
			unsafe
			{
				Options ??= new FString("");

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Level?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAbsolute;

				*(nint*)(__InBuffer + 17) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __OpenLevelBySoftObjectPtr, __InBuffer);
			}
		}

		/// <param name="LevelName">
		/// the level to open
		/// </param>
		/// <param name="bAbsolute">
		/// if true options are reset, if false options are carried over from current level
		/// </param>
		/// <param name="Options">
		/// a string of options to use for the travel URL
		/// </param>
		public static void OpenLevel(UObject WorldContextObject, FName LevelName, bool bAbsolute = true, FString Options = null)
		{
			unsafe
			{
				Options ??= new FString("");

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LevelName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAbsolute;

				*(nint*)(__InBuffer + 17) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __OpenLevel, __InBuffer);
			}
		}

		/// <returns>
		/// True if the object is of (or inherits from) the class type.
		/// </returns>
		public static bool ObjectIsA(UObject Object, TSubclassOf<UObject> ObjectClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ObjectClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ObjectIsA, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Hit">
		/// The source HitResult.
		/// </param>
		/// <param name="bBlockingHit">
		/// True if there was a blocking hit, false otherwise.
		/// </param>
		/// <param name="bInitialOverlap">
		/// True if the hit started in an initial overlap. In this case some other values should be interpreted differently. Time will be 0, ImpactPoint will equal Location, and normals will be equal and indicate a depenetration vector.
		/// </param>
		/// <param name="Time">
		/// 'Time' of impact along trace direction ranging from [0.0 to 1.0) if there is a hit, indicating time between start and end. Equals 1.0 if there is no hit.
		/// </param>
		/// <param name="Distance">
		/// The distance from the TraceStart to the Location in world space. This value is 0 if there was an initial overlap (trace started inside another colliding object).
		/// </param>
		/// <param name="Location">
		/// Location of the hit in world space. If this was a swept shape test, this is the location where we can place the shape in the world where it will not penetrate.
		/// </param>
		/// <param name="Normal">
		/// Normal of the hit in world space, for the object that was swept (e.g. for a sphere trace this points towards the sphere's center). Equal to ImpactNormal for line tests.
		/// </param>
		/// <param name="ImpactPoint">
		/// Location of the actual contact point of the trace shape with the surface of the hit object. Equal to Location in the case of an initial overlap.
		/// </param>
		/// <param name="ImpactNormal">
		/// Normal of the hit in world space, for the object that was hit by the sweep.
		/// </param>
		/// <param name="PhysMat">
		/// Physical material that was hit. Must set bReturnPhysicalMaterial to true in the query params for this to be returned.
		/// </param>
		/// <param name="HitActor">
		/// Actor hit by the trace.
		/// </param>
		/// <param name="HitComponent">
		/// PrimitiveComponent hit by the trace.
		/// </param>
		/// <param name="HitBoneName">
		/// Name of the bone hit (valid only if we hit a skeletal mesh).
		/// </param>
		/// <param name="BoneName">
		/// Name of the trace bone hit (valid only if we hit a skeletal mesh).
		/// </param>
		/// <param name="HitItem">
		/// Primitive-specific data recording which item in the primitive was hit
		/// </param>
		/// <param name="ElementIndex">
		/// If colliding with a primitive with multiple parts, index of the part that was hit.
		/// </param>
		/// <param name="FaceIndex">
		/// If colliding with trimesh or landscape, index of face that was hit.
		/// </param>
		public static FHitResult MakeHitResult(bool bBlockingHit, bool bInitialOverlap, float Time, float Distance, FVector Location, FVector ImpactPoint, FVector Normal, FVector ImpactNormal, UPhysicalMaterial PhysMat, AActor HitActor, UPrimitiveComponent HitComponent, FName HitBoneName, FName BoneName, int HitItem, int ElementIndex, int FaceIndex, FVector TraceStart, FVector TraceEnd)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[110];

				*(bool*)(__InBuffer) = bBlockingHit;

				*(bool*)(__InBuffer + 1) = bInitialOverlap;

				*(float*)(__InBuffer + 2) = Time;

				*(float*)(__InBuffer + 6) = Distance;

				*(nint*)(__InBuffer + 10) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 18) = ImpactPoint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 26) = Normal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 34) = ImpactNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 42) = PhysMat?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 50) = HitActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 58) = HitComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 66) = HitBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 74) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 82) = HitItem;

				*(int*)(__InBuffer + 86) = ElementIndex;

				*(int*)(__InBuffer + 90) = FaceIndex;

				*(nint*)(__InBuffer + 94) = TraceStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 102) = TraceEnd?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeHitResult, __InBuffer, __ReturnBuffer);

				return *(FHitResult*)__ReturnBuffer;
			}
		}

		public static void LoadStreamLevelBySoftObjectPtr(UObject WorldContextObject, TSoftObjectPtr<UWorld> Level, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, FLatentActionInfo LatentInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Level?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bMakeVisibleAfterLoad;

				*(bool*)(__InBuffer + 17) = bShouldBlockOnLoad;

				*(nint*)(__InBuffer + 18) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LoadStreamLevelBySoftObjectPtr, __InBuffer);
			}
		}

		public static void LoadStreamLevel(UObject WorldContextObject, FName LevelName, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, FLatentActionInfo LatentInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LevelName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bMakeVisibleAfterLoad;

				*(bool*)(__InBuffer + 17) = bShouldBlockOnLoad;

				*(nint*)(__InBuffer + 18) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LoadStreamLevel, __InBuffer);
			}
		}

		/// <param name="SlotName">
		/// Name of the save game slot to load from.
		/// </param>
		/// <param name="UserIndex">
		/// The platform user index that identifies the user doing the saving, ignored on some platforms.
		/// </param>
		/// <returns>
		/// Object containing loaded game state (nullptr if load fails)
		/// </returns>
		public static USaveGame LoadGameFromSlot(FString SlotName, int UserIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SlotName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = UserIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadGameFromSlot, __InBuffer, __ReturnBuffer);

				return *(USaveGame*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Whether the game viewport is split screen or not
		/// </returns>
		public static bool IsSplitscreenForceDisabled(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsSplitscreenForceDisabled, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Whether the game is currently paused or not
		/// </returns>
		public static bool IsGamePaused(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsGamePaused, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Location">
		/// The location from which test range
		/// </param>
		/// <param name="MaximumRange">
		/// The distance away from Location to test range
		/// </param>
		/// <note>
		/// This will always return false on dedicated servers.
		/// </note>
		public static bool IsAnyLocalPlayerCameraWithinRange(UObject WorldContextObject, FVector Location, float MaximumRange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = MaximumRange;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsAnyLocalPlayerCameraWithinRange, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Options">
		/// The string containing the options.
		/// </param>
		/// <param name="Key">
		/// The key to determine if it exists in Options.
		/// </param>
		/// <returns>
		/// Whether Key was found in Options.
		/// </returns>
		public static bool HasOption(FString Options, FString InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Options?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasOption, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the launch option was specified on the commandline, false otherwise
		/// </returns>
		public static bool HasLaunchOption(FString OptionToCheck)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OptionToCheck?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasLaunchOption, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Mesh">
		/// The static mesh we are interested in counting.
		/// </param>
		/// <param name="CenterPosition">
		/// The center position of the sphere.
		/// </param>
		/// <param name="Radius">
		/// The radius of the sphere.
		/// </param>
		/// <returns>
		/// Number of foliage instances with their mesh set to Mesh that overlap the sphere.
		/// </returns>
		public static int GrassOverlappingSphereCount(UObject WorldContextObject, UStaticMesh StaticMesh, FVector CenterPosition, float Radius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = CenterPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GrassOverlappingSphereCount, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FIntVector GetWorldOriginLocation(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetWorldOriginLocation, __InBuffer, __ReturnBuffer);

				return *(FIntVector*)__ReturnBuffer;
			}
		}

		public static double GetWorldDeltaSeconds(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetWorldDeltaSeconds, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="DesiredView">
		/// FMinimalViewInfo struct for a camera.
		/// </param>
		/// <param name="ViewMatrix">
		/// (out) Corresponding View Matrix
		/// </param>
		/// <param name="ProjectionMatrix">
		/// (out) Corresponding Projection Matrix
		/// </param>
		/// <param name="ViewProjectionMatrix">
		/// (out) Corresponding View x Projection Matrix
		/// </param>
		public static void GetViewProjectionMatrix(FMinimalViewInfo DesiredView, ref FMatrix ViewMatrix, ref FMatrix ProjectionMatrix, ref FMatrix ViewProjectionMatrix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = DesiredView?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ViewMatrix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ProjectionMatrix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ViewProjectionMatrix?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetViewProjectionMatrix, __InBuffer, __OutBuffer);

				ViewMatrix = *(FMatrix*)(__OutBuffer);

				ProjectionMatrix = *(FMatrix*)(__OutBuffer + 8);

				ViewProjectionMatrix = *(FMatrix*)(__OutBuffer + 16);

			}
		}

		public static EMouseCaptureMode GetViewportMouseCaptureMode(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetViewportMouseCaptureMode, __InBuffer, __ReturnBuffer);

				return *(EMouseCaptureMode*)__ReturnBuffer;
			}
		}

		public static double GetUnpausedTimeSeconds(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetUnpausedTimeSeconds, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double GetTimeSeconds(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTimeSeconds, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static EPhysicalSurface GetSurfaceType(FHitResult Hit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Hit?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSurfaceType, __InBuffer, __ReturnBuffer);

				return *(EPhysicalSurface*)__ReturnBuffer;
			}
		}

		public static ULevelStreaming GetStreamingLevel(UObject WorldContextObject, FName PackageName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStreamingLevel, __InBuffer, __ReturnBuffer);

				return *(ULevelStreaming*)__ReturnBuffer;
			}
		}

		public static double GetRealTimeSeconds(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRealTimeSeconds, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="UniqueId">
		/// The player's unique net/online id
		/// </param>
		public static APlayerState GetPlayerStateFromUniqueNetId(UObject WorldContextObject, FUniqueNetIdRepl UniqueId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UniqueId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerStateFromUniqueNetId, __InBuffer, __ReturnBuffer);

				return *(APlayerState*)__ReturnBuffer;
			}
		}

		/// <param name="PlayerStateIndex">
		/// Index into the game state's PlayerArray
		/// </param>
		public static APlayerState GetPlayerState(UObject WorldContextObject, int PlayerStateIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = PlayerStateIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerState, __InBuffer, __ReturnBuffer);

				return *(APlayerState*)__ReturnBuffer;
			}
		}

		/// <param name="PlayerIndex">
		/// Index in the player controller list, starting first with local players and then available remote ones
		/// </param>
		public static APawn GetPlayerPawn(UObject WorldContextObject, int PlayerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = PlayerIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerPawn, __InBuffer, __ReturnBuffer);

				return *(APawn*)__ReturnBuffer;
			}
		}

		/// <param name="Player">
		/// The player controller of the player to get the ID of
		/// </param>
		/// <returns>
		/// The ID of the passed in player. -1 if there is no physical controller assigned to the passed in player
		/// </returns>
		public static int GetPlayerControllerID(APlayerController Player)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerControllerID, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="ControllerID">
		/// Physical controller ID, the same value returned from Get Player Controller ID
		/// </param>
		public static APlayerController GetPlayerControllerFromPlatformUser(UObject WorldContextObject, FPlatformUserId UserId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerControllerFromPlatformUser, __InBuffer, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		/// <param name="ControllerID">
		/// Physical controller ID, the same value returned from Get Player Controller ID
		/// </param>
		public static APlayerController GetPlayerControllerFromID(UObject WorldContextObject, int ControllerID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ControllerID;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerControllerFromID, __InBuffer, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		/// <param name="PlayerIndex">
		/// Index in the player controller list, starting first with local players and then available remote ones
		/// </param>
		public static APlayerController GetPlayerController(UObject WorldContextObject, int PlayerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = PlayerIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerController, __InBuffer, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		/// <param name="PlayerIndex">
		/// Index in the player controller list, starting first with local players and then available remote ones
		/// </param>
		public static ACharacter GetPlayerCharacter(UObject WorldContextObject, int PlayerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = PlayerIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerCharacter, __InBuffer, __ReturnBuffer);

				return *(ACharacter*)__ReturnBuffer;
			}
		}

		/// <param name="PlayerIndex">
		/// Index in the player controller list, starting first with local players and then available remote ones
		/// </param>
		public static APlayerCameraManager GetPlayerCameraManager(UObject WorldContextObject, int PlayerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = PlayerIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerCameraManager, __InBuffer, __ReturnBuffer);

				return *(APlayerCameraManager*)__ReturnBuffer;
			}
		}

		public static FString GetPlatformName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetPlatformName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static UClass GetObjectClass(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetObjectClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public static int GetNumPlayerStates(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumPlayerStates, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetNumPlayerControllers(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumPlayerControllers, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetNumLocalPlayerControllers(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumLocalPlayerControllers, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetMaxAudioChannelCount(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaxAudioChannelCount, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Pair">
		/// The string containing a pair to split apart.
		/// </param>
		/// <param name="Key">
		/// (out) Key portion of Pair. If no = in string will be the same as Pair.
		/// </param>
		/// <param name="Value">
		/// (out) Value portion of Pair. If no = in string will be empty.
		/// </param>
		public static void GetKeyValue(FString Pair, ref FString Key, ref FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Pair?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetKeyValue, __InBuffer, __OutBuffer);

				Key = *(FString*)(__OutBuffer);

				Value = *(FString*)(__OutBuffer + 8);

			}
		}

		/// <param name="Options">
		/// The string containing the options.
		/// </param>
		/// <param name="Key">
		/// The key to find the value of in Options.
		/// </param>
		/// <returns>
		/// The value associated with Key as an integer if Key found in Options string, otherwise DefaultValue.
		/// </returns>
		public static int GetIntOption(FString Options, FString Key, int DefaultValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Options?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = DefaultValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetIntOption, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Current time dilation.
		/// </returns>
		public static float GetGlobalTimeDilation(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetGlobalTimeDilation, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static AGameStateBase GetGameState(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetGameState, __InBuffer, __ReturnBuffer);

				return *(AGameStateBase*)__ReturnBuffer;
			}
		}

		public static AGameModeBase GetGameMode(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetGameMode, __InBuffer, __ReturnBuffer);

				return *(AGameModeBase*)__ReturnBuffer;
			}
		}

		public static UGameInstance GetGameInstance(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetGameInstance, __InBuffer, __ReturnBuffer);

				return *(UGameInstance*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Whether the world should be rendered or not
		/// </returns>
		public static bool GetEnableWorldRendering(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEnableWorldRendering, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static UReverbEffect GetCurrentReverbEffect(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentReverbEffect, __InBuffer, __ReturnBuffer);

				return *(UReverbEffect*)__ReturnBuffer;
			}
		}

		/// <param name="bRemovePrefixString">
		/// remove any streaming- or editor- added prefixes from the level name.
		/// </param>
		public static FString GetCurrentLevelName(UObject WorldContextObject, bool bRemovePrefixString = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRemovePrefixString;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentLevelName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Location">
		/// The location from which we'd like to find the closest listener, in world space.
		/// </param>
		/// <param name="MaximumRange">
		/// The maximum distance away from Location that a listener can be.
		/// </param>
		/// <param name="bAllowAttenuationOverride">
		/// True for the adjusted listener position (if attenuation override is set), false for the raw listener position (for panning)
		/// </param>
		/// <param name="ListenerPosition">
		/// [Out] The position of the closest listener in world space, if found.
		/// </param>
		/// <note>
		/// This will always return false if there is no audio device, or the audio device is disabled.
		/// </note>
		/// <returns>
		/// true if we've successfully found a listener within MaximumRange of Location, otherwise false.
		/// </returns>
		public static bool GetClosestListenerLocation(UObject WorldContextObject, FVector Location, float MaximumRange, bool bAllowAttenuationOverride, ref FVector ListenerPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = MaximumRange;

				*(bool*)(__InBuffer + 20) = bAllowAttenuationOverride;

				*(nint*)(__InBuffer + 21) = ListenerPosition?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetClosestListenerLocation, __InBuffer, __OutBuffer, __ReturnBuffer);

				ListenerPosition = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<FName> GetAvailableSpatialPluginNames(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAvailableSpatialPluginNames, __InBuffer, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public static double GetAudioTimeSeconds(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAudioTimeSeconds, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="Tag">
		/// Tag to find. Must be specified or result array will be empty.
		/// </param>
		/// <param name="OutActors">
		/// Output array of Actors of the specified tag.
		/// </param>
		public static void GetAllActorsWithTag(UObject WorldContextObject, FName Tag, ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAllActorsWithTag, __InBuffer, __OutBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		/// <param name="Interface">
		/// Interface to find. Must be specified or result array will be empty.
		/// </param>
		/// <param name="OutActors">
		/// Output array of Actors of the specified interface.
		/// </param>
		public static void GetAllActorsWithInterface(UObject WorldContextObject, TSubclassOf<UInterface> Interface, ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Interface?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAllActorsWithInterface, __InBuffer, __OutBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		/// <param name="Tag">
		/// Tag to find. Must be specified or result array will be empty.
		/// </param>
		/// <param name="ActorClass">
		/// Class of Actor to find. Must be specified or result array will be empty.
		/// </param>
		/// <param name="OutActors">
		/// Output array of Actors of the specified tag.
		/// </param>
		public static void GetAllActorsOfClassWithTag(UObject WorldContextObject, TSubclassOf<AActor> ActorClass, FName Tag, ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActorClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAllActorsOfClassWithTag, __InBuffer, __OutBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		/// <param name="ActorClass">
		/// Class of Actor to find. Must be specified or result array will be empty.
		/// </param>
		/// <param name="OutActors">
		/// Output array of Actors of the specified class.
		/// </param>
		public static void GetAllActorsOfClass(UObject WorldContextObject, TSubclassOf<AActor> ActorClass, ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActorClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAllActorsOfClass, __InBuffer, __OutBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		/// <param name="ActorClass">
		/// Class of Actor to find. Must be specified or result will be empty.
		/// </param>
		/// <returns>
		/// Actor of the specified class.
		/// </returns>
		public static AActor GetActorOfClass(UObject WorldContextObject, TSubclassOf<AActor> ActorClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActorClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetActorOfClass, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public static void GetActorArrayBounds(TArray<AActor> Actors, bool bOnlyCollidingComponents, ref FVector Center, ref FVector BoxExtent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyCollidingComponents;

				*(nint*)(__InBuffer + 9) = Center?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = BoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetActorArrayBounds, __InBuffer, __OutBuffer);

				Center = *(FVector*)(__OutBuffer);

				BoxExtent = *(FVector*)(__OutBuffer + 8);

			}
		}

		public static FVector GetActorArrayAverageLocation(TArray<AActor> Actors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetActorArrayAverageLocation, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FName GetActiveSpatialPluginName(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetActiveSpatialPluginName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public static void GetAccurateRealTime(ref int Seconds, ref double PartialSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Seconds;

				*(double*)(__InBuffer + 4) = PartialSeconds;

				var __OutBuffer = stackalloc byte[12];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAccurateRealTime, __InBuffer, __OutBuffer);

				Seconds = *(int*)(__OutBuffer);

				PartialSeconds = *(double*)(__OutBuffer + 4);

			}
		}

		public static void FlushLevelStreaming(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __FlushLevelStreaming, __InBuffer);
			}
		}

		public static AActor FinishSpawningActor(AActor Actor, FTransform SpawnTransform, ESpawnActorScaleMethod TransformScaleMethod = ESpawnActorScaleMethod.MultiplyWithRoot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SpawnTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)TransformScaleMethod;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FinishSpawningActor, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		/// <param name="Origin">
		/// World Location from which the distance is measured.
		/// </param>
		/// <param name="ActorsToCheck">
		/// Array of Actors to examine and return Actor nearest to Origin.
		/// </param>
		/// <param name="Distance">
		/// Distance from Origin to the returned Actor.
		/// </param>
		/// <returns>
		/// Nearest Actor.
		/// </returns>
		public static AActor FindNearestActor(FVector Origin, TArray<AActor> ActorsToCheck, ref float Distance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActorsToCheck?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Distance;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __FindNearestActor, __InBuffer, __OutBuffer, __ReturnBuffer);

				Distance = *(float*)(__OutBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public static bool FindCollisionUV(FHitResult Hit, int UVChannel, ref FVector2D UV)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Hit?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = UVChannel;

				*(nint*)(__InBuffer + 12) = UV?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __FindCollisionUV, __InBuffer, __OutBuffer, __ReturnBuffer);

				UV = *(FVector2D*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Enable">
		/// If true enable streaming, otherwise disable.
		/// </param>
		public static void EnableLiveStreaming(bool Enable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = Enable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __EnableLiveStreaming, __InBuffer);
			}
		}

		/// <param name="SlotName">
		/// Name of save game slot.
		/// </param>
		/// <param name="UserIndex">
		/// The platform user index that identifies the user doing the saving, ignored on some platforms.
		/// </param>
		public static bool DoesSaveGameExist(FString SlotName, int UserIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SlotName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = UserIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DoesSaveGameExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Player">
		/// Deproject using this player's view.
		/// </param>
		/// <param name="ScreenPosition">
		/// 2D screen space to deproject.
		/// </param>
		/// <param name="WorldPosition">
		/// (out) Corresponding 3D position in world space.
		/// </param>
		/// <param name="WorldDirection">
		/// (out) World space direction vector away from the camera at the given 2d point.
		/// </param>
		public static bool DeprojectScreenToWorld(APlayerController Player, FVector2D ScreenPosition, ref FVector WorldPosition, ref FVector WorldDirection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = WorldPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = WorldDirection?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __DeprojectScreenToWorld, __InBuffer, __OutBuffer, __ReturnBuffer);

				WorldPosition = *(FVector*)(__OutBuffer);

				WorldDirection = *(FVector*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SceneCapture2D">
		/// Deproject using this scene capture's view.
		/// </param>
		/// <param name="ScreenPosition">
		/// UV in scene capture render target to deproject.
		/// </param>
		/// <param name="WorldPosition">
		/// (out) Corresponding 3D position on camera near plane, in world space.
		/// </param>
		/// <param name="WorldDirection">
		/// (out) World space direction vector away from the camera at the given 2d point.
		/// </param>
		public static bool DeprojectSceneCaptureToWorld(ASceneCapture2D SceneCapture2D, FVector2D TargetUV, ref FVector WorldPosition, ref FVector WorldDirection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = SceneCapture2D?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetUV?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = WorldPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = WorldDirection?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __DeprojectSceneCaptureToWorld, __InBuffer, __OutBuffer, __ReturnBuffer);

				WorldPosition = *(FVector*)(__OutBuffer);

				WorldDirection = *(FVector*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SlotName">
		/// Name of save game slot to delete.
		/// </param>
		/// <param name="UserIndex">
		/// The platform user index that identifies the user doing the saving, ignored on some platforms.
		/// </param>
		/// <returns>
		/// True if a file was actually able to be deleted. use DoesSaveGameExist to distinguish between delete failures and failure due to file not existing.
		/// </returns>
		public static bool DeleteGameInSlot(FString SlotName, int UserIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SlotName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = UserIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DeleteGameInSlot, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TagName">
		/// Tag associated with Reverb Effect to remove
		/// </param>
		public static void DeactivateReverbEffect(UObject WorldContextObject, FName TagName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TagName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DeactivateReverbEffect, __InBuffer);
			}
		}

		/// <param name="Sound">
		/// - Sound to create.
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - A linear scalar multiplied with the volume, in order to make the sound louder or softer.
		/// </param>
		/// <param name="PitchMultiplier">
		/// - A linear scalar multiplied with the pitch.
		/// </param>
		/// <param name="StartTime">
		/// - How far into the sound to begin playback at
		/// </param>
		/// <param name="ConcurrencySettings">
		/// - Override concurrency settings package to play sound with
		/// </param>
		/// <param name="PersistAcrossLevelTransition">
		/// - Whether the sound should continue to play when the map it was played in is unloaded
		/// </param>
		/// <param name="bAutoDestroy">
		/// - Whether the returned audio component will be automatically cleaned up when the sound finishes 
		/// (by completing or stopping), or whether it can be reactivated
		/// </param>
		/// <returns>
		/// An audio component to manipulate the created sound
		/// </returns>
		public static UAudioComponent CreateSound2D(UObject WorldContextObject, USoundBase Sound, float VolumeMultiplier = 1.000000f, float PitchMultiplier = 1.000000f, float StartTime = 0.000000f, USoundConcurrency ConcurrencySettings = null, bool bPersistAcrossLevelTransition = false, bool bAutoDestroy = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[38];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sound?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = VolumeMultiplier;

				*(float*)(__InBuffer + 20) = PitchMultiplier;

				*(float*)(__InBuffer + 24) = StartTime;

				*(nint*)(__InBuffer + 28) = ConcurrencySettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 36) = bPersistAcrossLevelTransition;

				*(bool*)(__InBuffer + 37) = bAutoDestroy;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateSound2D, __InBuffer, __ReturnBuffer);

				return *(UAudioComponent*)__ReturnBuffer;
			}
		}

		/// <param name="SaveGameClass">
		/// Class of SaveGame to create
		/// </param>
		/// <returns>
		/// New SaveGame object to write data to
		/// </returns>
		public static USaveGame CreateSaveGameObject(TSubclassOf<USaveGame> SaveGameClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SaveGameClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateSaveGameObject, __InBuffer, __ReturnBuffer);

				return *(USaveGame*)__ReturnBuffer;
			}
		}

		/// <param name="UserId">
		/// The platform user id that should control the newly created player. A valude of PLATFRMUSERID_NONE specifies to use the next available ID	
		/// </param>
		/// <param name="bSpawnPlayerController">
		/// Whether a player controller should be spawned immediately for this player. If false a player controller will not be created automatically until transition to the next map.
		/// </param>
		/// <returns>
		/// The created player controller if one is created.
		/// </returns>
		public static APlayerController CreatePlayerFromPlatformUser(UObject WorldContextObject, FPlatformUserId UserId, bool bSpawnPlayerController = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserId?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSpawnPlayerController;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreatePlayerFromPlatformUser, __InBuffer, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		/// <param name="ControllerId">
		/// The ID of the physical controller that the should control the newly created player. A value of -1 specifies to use the next available ID
		/// </param>
		/// <param name="bSpawnPlayerController">
		/// Whether a player controller should be spawned immediately for this player. If false a player controller will not be created automatically until transition to the next map.
		/// </param>
		/// <returns>
		/// The created player controller if one is created.
		/// </returns>
		public static APlayerController CreatePlayer(UObject WorldContextObject, int ControllerId = -1, bool bSpawnPlayerController = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ControllerId;

				*(bool*)(__InBuffer + 12) = bSpawnPlayerController;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreatePlayer, __InBuffer, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		public static void ClearSoundMixModifiers(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearSoundMixModifiers, __InBuffer);
			}
		}

		/// <param name="InSoundMixModifier">
		/// The sound mix to modify.
		/// </param>
		/// <param name="InSoundClass">
		/// The sound class in the sound mix to clear overrides from.
		/// </param>
		/// <param name="FadeOutTime">
		/// The interpolation time to use to go from the current sound class adjuster override values to the non-override values.
		/// </param>
		public static void ClearSoundMixClassOverride(UObject WorldContextObject, USoundMix InSoundMixModifier, USoundClass InSoundClass, float FadeOutTime = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSoundMixModifier?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSoundClass?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = FadeOutTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearSoundMixClassOverride, __InBuffer);
			}
		}

		public static void CancelAsyncLoading()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __CancelAsyncLoading);
			}
		}

		/// <param name="Hit">
		/// The source HitResult.
		/// </param>
		/// <param name="bBlockingHit">
		/// True if there was a blocking hit, false otherwise.
		/// </param>
		/// <param name="bInitialOverlap">
		/// True if the hit started in an initial overlap. In this case some other values should be interpreted differently. Time will be 0, ImpactPoint will equal Location, and normals will be equal and indicate a depenetration vector.
		/// </param>
		/// <param name="Time">
		/// 'Time' of impact along trace direction ranging from [0.0 to 1.0) if there is a hit, indicating time between start and end. Equals 1.0 if there is no hit.
		/// </param>
		/// <param name="Distance">
		/// The distance from the TraceStart to the Location in world space. This value is 0 if there was an initial overlap (trace started inside another colliding object).
		/// </param>
		/// <param name="Location">
		/// Location of the hit in world space. If this was a swept shape test, this is the location where we can place the shape in the world where it will not penetrate.
		/// </param>
		/// <param name="Normal">
		/// Normal of the hit in world space, for the object that was swept (e.g. for a sphere trace this points towards the sphere's center). Equal to ImpactNormal for line tests.
		/// </param>
		/// <param name="ImpactPoint">
		/// Location of the actual contact point of the trace shape with the surface of the hit object. Equal to Location in the case of an initial overlap.
		/// </param>
		/// <param name="ImpactNormal">
		/// Normal of the hit in world space, for the object that was hit by the sweep.
		/// </param>
		/// <param name="PhysMat">
		/// Physical material that was hit. Must set bReturnPhysicalMaterial to true in the query params for this to be returned.
		/// </param>
		/// <param name="HitActor">
		/// Actor hit by the trace.
		/// </param>
		/// <param name="HitComponent">
		/// PrimitiveComponent hit by the trace.
		/// </param>
		/// <param name="HitBoneName">
		/// Name of the bone hit (valid only if we hit a skeletal mesh).
		/// </param>
		/// <param name="BoneName">
		/// Name of the trace bone hit (valid only if we hit a skeletal mesh).
		/// </param>
		/// <param name="HitItem">
		/// Primitive-specific data recording which item in the primitive was hit
		/// </param>
		/// <param name="ElementIndex">
		/// If colliding with a primitive with multiple parts, index of the part that was hit.
		/// </param>
		/// <param name="FaceIndex">
		/// If colliding with trimesh or landscape, index of face that was hit.
		/// </param>
		public static void BreakHitResult(FHitResult Hit, ref bool bBlockingHit, ref bool bInitialOverlap, ref float Time, ref float Distance, ref FVector Location, ref FVector ImpactPoint, ref FVector Normal, ref FVector ImpactNormal, ref UPhysicalMaterial PhysMat, ref AActor HitActor, ref UPrimitiveComponent HitComponent, ref FName HitBoneName, ref FName BoneName, ref int HitItem, ref int ElementIndex, ref int FaceIndex, ref FVector TraceStart, ref FVector TraceEnd)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[118];

				*(nint*)(__InBuffer) = Hit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bBlockingHit;

				*(bool*)(__InBuffer + 9) = bInitialOverlap;

				*(float*)(__InBuffer + 10) = Time;

				*(float*)(__InBuffer + 14) = Distance;

				*(nint*)(__InBuffer + 18) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 26) = ImpactPoint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 34) = Normal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 42) = ImpactNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 50) = PhysMat?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 58) = HitActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 66) = HitComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 74) = HitBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 82) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 90) = HitItem;

				*(int*)(__InBuffer + 94) = ElementIndex;

				*(int*)(__InBuffer + 98) = FaceIndex;

				*(nint*)(__InBuffer + 102) = TraceStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 110) = TraceEnd?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[110];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakHitResult, __InBuffer, __OutBuffer);

				bBlockingHit = *(bool*)(__OutBuffer);

				bInitialOverlap = *(bool*)(__OutBuffer + 1);

				Time = *(float*)(__OutBuffer + 2);

				Distance = *(float*)(__OutBuffer + 6);

				Location = *(FVector*)(__OutBuffer + 10);

				ImpactPoint = *(FVector*)(__OutBuffer + 18);

				Normal = *(FVector*)(__OutBuffer + 26);

				ImpactNormal = *(FVector*)(__OutBuffer + 34);

				PhysMat = *(UPhysicalMaterial*)(__OutBuffer + 42);

				HitActor = *(AActor*)(__OutBuffer + 50);

				HitComponent = *(UPrimitiveComponent*)(__OutBuffer + 58);

				HitBoneName = *(FName*)(__OutBuffer + 66);

				BoneName = *(FName*)(__OutBuffer + 74);

				HitItem = *(int*)(__OutBuffer + 82);

				ElementIndex = *(int*)(__OutBuffer + 86);

				FaceIndex = *(int*)(__OutBuffer + 90);

				TraceStart = *(FVector*)(__OutBuffer + 94);

				TraceEnd = *(FVector*)(__OutBuffer + 102);

			}
		}

		/// <param name="TossVelocity">
		/// (output) Result launch velocity.
		/// </param>
		/// <param name="StartLocation">
		/// Intended launch location
		/// </param>
		/// <param name="EndLocation">
		/// Desired landing location
		/// </param>
		/// <param name="LaunchSpeed">
		/// Desired launch speed
		/// </param>
		/// <param name="OverrideGravityZ">
		/// Optional gravity override.  0 means "do not override".
		/// </param>
		/// <param name="TraceOption">
		/// Controls whether or not to validate a clear path by tracing along the calculated arc
		/// </param>
		/// <param name="CollisionRadius">
		/// Radius of the projectile (assumed spherical), used when tracing
		/// </param>
		/// <param name="bFavorHighArc">
		/// If true and there are 2 valid solutions, will return the higher arc.  If false, will favor the lower arc.
		/// </param>
		/// <param name="bDrawDebug">
		/// When true, a debug arc is drawn (red for an invalid arc, green for a valid arc)
		/// </param>
		/// <returns>
		/// Returns false if there is no valid solution or the valid solutions are blocked.  Returns true otherwise.
		/// </returns>
		public static bool BlueprintSuggestProjectileVelocity(UObject WorldContextObject, ref FVector TossVelocity, FVector StartLocation, FVector EndLocation, float LaunchSpeed, float OverrideGravityZ, ESuggestProjVelocityTraceOption TraceOption, float CollisionRadius, bool bFavorHighArc, bool bDrawDebug)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[47];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TossVelocity?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = StartLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = EndLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = LaunchSpeed;

				*(float*)(__InBuffer + 36) = OverrideGravityZ;

				*(byte*)(__InBuffer + 40) = (byte)TraceOption;

				*(float*)(__InBuffer + 41) = CollisionRadius;

				*(bool*)(__InBuffer + 45) = bFavorHighArc;

				*(bool*)(__InBuffer + 46) = bDrawDebug;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __BlueprintSuggestProjectileVelocity, __InBuffer, __OutBuffer, __ReturnBuffer);

				TossVelocity = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="OutPathPositions">
		/// Predicted projectile path. Ordered series of positions from StartPos to the end. Includes location at point of impact if it hit something.
		/// </param>
		/// <param name="OutHit">
		/// Predicted hit result, if the projectile will hit something
		/// </param>
		/// <param name="OutLastTraceDestination">
		/// Goal position of the final trace it did. Will not be in the path if there is a hit.
		/// </param>
		/// <param name="StartPos">
		/// First start trace location
		/// </param>
		/// <param name="LaunchVelocity">
		/// Velocity the "virtual projectile" is launched at
		/// </param>
		/// <param name="bTracePath">
		/// Trace along the entire path to look for blocking hits
		/// </param>
		/// <param name="ProjectileRadius">
		/// Radius of the virtual projectile to sweep against the environment
		/// </param>
		/// <param name="TraceChannel">
		/// TraceChannel to trace against, if bTracePath is true.
		/// </param>
		/// <param name="bTraceComplex">
		/// Use TraceComplex (trace against triangles not primitives)
		/// </param>
		/// <param name="ActorsToIgnore">
		/// Actors to exclude from the traces
		/// </param>
		/// <param name="DrawDebugType">
		/// Debug type (one-frame, duration, persistent)
		/// </param>
		/// <param name="DrawDebugTime">
		/// Duration of debug lines (only relevant for DrawDebugType::Duration)
		/// </param>
		/// <param name="SimFrequency">
		/// Determines size of each sub-step in the simulation (chopping up MaxSimTime)
		/// </param>
		/// <param name="MaxSimTime">
		/// Maximum simulation time for the virtual projectile.
		/// </param>
		/// <param name="OverrideGravityZ">
		/// Optional override of Gravity (if 0, uses WorldGravityZ)
		/// </param>
		/// <returns>
		/// True if hit something along the path (if tracing with collision).
		/// </returns>
		public static bool Blueprint_PredictProjectilePath_ByTraceChannel(UObject WorldContextObject, ref FHitResult OutHit, ref TArray<FVector> OutPathPositions, ref FVector OutLastTraceDestination, FVector StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, ECollisionChannel TraceChannel, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, float DrawDebugTime, float SimFrequency, float MaxSimTime, float OverrideGravityZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[80];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutPathPositions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutLastTraceDestination?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = StartPos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = LaunchVelocity?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 48) = bTracePath;

				*(float*)(__InBuffer + 49) = ProjectileRadius;

				*(byte*)(__InBuffer + 53) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 54) = bTraceComplex;

				*(nint*)(__InBuffer + 55) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 63) = (byte)DrawDebugType;

				*(float*)(__InBuffer + 64) = DrawDebugTime;

				*(float*)(__InBuffer + 68) = SimFrequency;

				*(float*)(__InBuffer + 72) = MaxSimTime;

				*(float*)(__InBuffer + 76) = OverrideGravityZ;

				var __OutBuffer = stackalloc byte[24];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __Blueprint_PredictProjectilePath_ByTraceChannel, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				OutPathPositions = *(TArray<FVector>*)(__OutBuffer + 8);

				OutLastTraceDestination = *(FVector*)(__OutBuffer + 16);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="OutPathPositions">
		/// Predicted projectile path. Ordered series of positions from StartPos to the end. Includes location at point of impact if it hit something.
		/// </param>
		/// <param name="OutHit">
		/// Predicted hit result, if the projectile will hit something
		/// </param>
		/// <param name="OutLastTraceDestination">
		/// Goal position of the final trace it did. Will not be in the path if there is a hit.
		/// </param>
		/// <param name="StartPos">
		/// First start trace location
		/// </param>
		/// <param name="LaunchVelocity">
		/// Velocity the "virtual projectile" is launched at
		/// </param>
		/// <param name="bTracePath">
		/// Trace along the entire path to look for blocking hits
		/// </param>
		/// <param name="ProjectileRadius">
		/// Radius of the virtual projectile to sweep against the environment
		/// </param>
		/// <param name="ObjectTypes">
		/// ObjectTypes to trace against, if bTracePath is true.
		/// </param>
		/// <param name="bTraceComplex">
		/// Use TraceComplex (trace against triangles not primitives)
		/// </param>
		/// <param name="ActorsToIgnore">
		/// Actors to exclude from the traces
		/// </param>
		/// <param name="DrawDebugType">
		/// Debug type (one-frame, duration, persistent)
		/// </param>
		/// <param name="DrawDebugTime">
		/// Duration of debug lines (only relevant for DrawDebugType::Duration)
		/// </param>
		/// <param name="SimFrequency">
		/// Determines size of each sub-step in the simulation (chopping up MaxSimTime)
		/// </param>
		/// <param name="MaxSimTime">
		/// Maximum simulation time for the virtual projectile.
		/// </param>
		/// <param name="OverrideGravityZ">
		/// Optional override of Gravity (if 0, uses WorldGravityZ)
		/// </param>
		/// <returns>
		/// True if hit something along the path if tracing for collision.
		/// </returns>
		public static bool Blueprint_PredictProjectilePath_ByObjectType(UObject WorldContextObject, ref FHitResult OutHit, ref TArray<FVector> OutPathPositions, ref FVector OutLastTraceDestination, FVector StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, TArray<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, float DrawDebugTime, float SimFrequency, float MaxSimTime, float OverrideGravityZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[87];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutPathPositions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutLastTraceDestination?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = StartPos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = LaunchVelocity?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 48) = bTracePath;

				*(float*)(__InBuffer + 49) = ProjectileRadius;

				*(nint*)(__InBuffer + 53) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 61) = bTraceComplex;

				*(nint*)(__InBuffer + 62) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 70) = (byte)DrawDebugType;

				*(float*)(__InBuffer + 71) = DrawDebugTime;

				*(float*)(__InBuffer + 75) = SimFrequency;

				*(float*)(__InBuffer + 79) = MaxSimTime;

				*(float*)(__InBuffer + 83) = OverrideGravityZ;

				var __OutBuffer = stackalloc byte[24];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __Blueprint_PredictProjectilePath_ByObjectType, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				OutPathPositions = *(TArray<FVector>*)(__OutBuffer + 8);

				OutLastTraceDestination = *(FVector*)(__OutBuffer + 16);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PredictParams">
		/// Input params to the trace (start location, velocity, time to simulate, etc).
		/// </param>
		/// <param name="PredictResult">
		/// Output result of the trace (Hit result, array of location/velocity/times for each trace step, etc).
		/// </param>
		/// <returns>
		/// True if hit something along the path (if tracing with collision).
		/// </returns>
		public static bool Blueprint_PredictProjectilePath_Advanced(UObject WorldContextObject, FPredictProjectilePathParams PredictParams, ref FPredictProjectilePathResult PredictResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PredictParams?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PredictResult?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __Blueprint_PredictProjectilePath_Advanced, __InBuffer, __OutBuffer, __ReturnBuffer);

				PredictResult = *(FPredictProjectilePathResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static AActor BeginSpawningActorFromBlueprint(UObject WorldContextObject, UBlueprint Blueprint, FTransform SpawnTransform, bool bNoCollisionFail)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SpawnTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bNoCollisionFail;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BeginSpawningActorFromBlueprint, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public static AActor BeginDeferredActorSpawnFromClass(UObject WorldContextObject, TSubclassOf<AActor> ActorClass, FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.Undefined, AActor Owner = null, ESpawnActorScaleMethod TransformScaleMethod = ESpawnActorScaleMethod.MultiplyWithRoot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActorClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SpawnTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)CollisionHandlingOverride;

				*(nint*)(__InBuffer + 25) = Owner?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 33) = (byte)TransformScaleMethod;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BeginDeferredActorSpawnFromClass, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if subtitles are enabled.
		/// </returns>
		public static bool AreSubtitlesEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __AreSubtitlesEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Location">
		/// The location from which test if a listener is in range
		/// </param>
		/// <param name="MaximumRange">
		/// The distance away from Location to test if any listener is within
		/// </param>
		/// <note>
		/// This will always return false if there is no audio device, or the audio device is disabled.
		/// </note>
		public static bool AreAnyListenersWithinRange(UObject WorldContextObject, FVector Location, float MaximumRange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = MaximumRange;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AreAnyListenersWithinRange, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BaseDamage">
		/// - The base damage to apply, i.e. the damage at the origin.
		/// </param>
		/// <param name="Origin">
		/// - Epicenter of the damage area.
		/// </param>
		/// <param name="DamageInnerRadius">
		/// - Radius of the full damage area, from Origin
		/// </param>
		/// <param name="DamageOuterRadius">
		/// - Radius of the minimum damage area, from Origin
		/// </param>
		/// <param name="DamageFalloff">
		/// - Falloff exponent of damage from DamageInnerRadius to DamageOuterRadius
		/// </param>
		/// <param name="DamageTypeClass">
		/// - Class that describes the damage that was done.
		/// </param>
		/// <param name="IgnoreActors">
		/// - List of Actors to ignore
		/// </param>
		/// <param name="DamageCauser">
		/// - Actor that actually caused the damage (e.g. the grenade that exploded)
		/// </param>
		/// <param name="InstigatedByController">
		/// - Controller that was responsible for causing this damage (e.g. player who threw the grenade)
		/// </param>
		/// <param name="bFullDamage">
		/// - if true, damage not scaled based on distance from Origin
		/// </param>
		/// <param name="DamagePreventionChannel">
		/// - Damage will not be applied to victim if there is something between the origin and the victim which blocks traces on this channel
		/// </param>
		/// <returns>
		/// true if damage was applied to at least one actor.
		/// </returns>
		public static bool ApplyRadialDamageWithFalloff(UObject WorldContextObject, float BaseDamage, float MinimumDamage, FVector Origin, float DamageInnerRadius, float DamageOuterRadius, float DamageFalloff, TSubclassOf<UDamageType> DamageTypeClass, TArray<AActor> IgnoreActors, AActor DamageCauser = null, AController InstigatedByController = null, ECollisionChannel DamagePreventionChannel = ECollisionChannel.Visibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[69];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = BaseDamage;

				*(float*)(__InBuffer + 12) = MinimumDamage;

				*(nint*)(__InBuffer + 16) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = DamageInnerRadius;

				*(float*)(__InBuffer + 28) = DamageOuterRadius;

				*(float*)(__InBuffer + 32) = DamageFalloff;

				*(nint*)(__InBuffer + 36) = DamageTypeClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = IgnoreActors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 52) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 60) = InstigatedByController?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 68) = (byte)DamagePreventionChannel;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ApplyRadialDamageWithFalloff, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BaseDamage">
		/// - The base damage to apply, i.e. the damage at the origin.
		/// </param>
		/// <param name="Origin">
		/// - Epicenter of the damage area.
		/// </param>
		/// <param name="DamageRadius">
		/// - Radius of the damage area, from Origin
		/// </param>
		/// <param name="DamageTypeClass">
		/// - Class that describes the damage that was done.
		/// </param>
		/// <param name="IgnoreActors">
		/// - List of Actors to ignore
		/// </param>
		/// <param name="DamageCauser">
		/// - Actor that actually caused the damage (e.g. the grenade that exploded).  This actor will not be damaged and it will not block damage.
		/// </param>
		/// <param name="InstigatedByController">
		/// - Controller that was responsible for causing this damage (e.g. player who threw the grenade)
		/// </param>
		/// <param name="bFullDamage">
		/// - if true, damage not scaled based on distance from Origin
		/// </param>
		/// <param name="DamagePreventionChannel">
		/// - Damage will not be applied to victim if there is something between the origin and the victim which blocks traces on this channel
		/// </param>
		/// <returns>
		/// true if damage was applied to at least one actor.
		/// </returns>
		public static bool ApplyRadialDamage(UObject WorldContextObject, float BaseDamage, FVector Origin, float DamageRadius, TSubclassOf<UDamageType> DamageTypeClass, TArray<AActor> IgnoreActors, AActor DamageCauser = null, AController InstigatedByController = null, bool bDoFullDamage = false, ECollisionChannel DamagePreventionChannel = ECollisionChannel.Visibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[58];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = BaseDamage;

				*(nint*)(__InBuffer + 12) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 20) = DamageRadius;

				*(nint*)(__InBuffer + 24) = DamageTypeClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = IgnoreActors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = InstigatedByController?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 56) = bDoFullDamage;

				*(byte*)(__InBuffer + 57) = (byte)DamagePreventionChannel;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ApplyRadialDamage, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DamagedActor">
		/// - Actor that will be damaged.
		/// </param>
		/// <param name="BaseDamage">
		/// - The base damage to apply.
		/// </param>
		/// <param name="HitFromDirection">
		/// - Direction the hit came FROM
		/// </param>
		/// <param name="HitInfo">
		/// - Collision or trace result that describes the hit
		/// </param>
		/// <param name="EventInstigator">
		/// - Controller that was responsible for causing this damage (e.g. player who shot the weapon)
		/// </param>
		/// <param name="DamageCauser">
		/// - Actor that actually caused the damage (e.g. the grenade that exploded)
		/// </param>
		/// <param name="DamageTypeClass">
		/// - Class that describes the damage that was done.
		/// </param>
		/// <returns>
		/// Actual damage the ended up being applied to the actor.
		/// </returns>
		public static float ApplyPointDamage(AActor DamagedActor, float BaseDamage, FVector HitFromDirection, FHitResult HitInfo, AController EventInstigator, AActor DamageCauser, TSubclassOf<UDamageType> DamageTypeClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[52];

				*(nint*)(__InBuffer) = DamagedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = BaseDamage;

				*(nint*)(__InBuffer + 12) = HitFromDirection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = HitInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = EventInstigator?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = DamageTypeClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ApplyPointDamage, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="DamagedActor">
		/// - Actor that will be damaged.
		/// </param>
		/// <param name="BaseDamage">
		/// - The base damage to apply.
		/// </param>
		/// <param name="EventInstigator">
		/// - Controller that was responsible for causing this damage (e.g. player who shot the weapon)
		/// </param>
		/// <param name="DamageCauser">
		/// - Actor that actually caused the damage (e.g. the grenade that exploded)
		/// </param>
		/// <param name="DamageTypeClass">
		/// - Class that describes the damage that was done.
		/// </param>
		/// <returns>
		/// Actual damage the ended up being applied to the actor.
		/// </returns>
		public static float ApplyDamage(AActor DamagedActor, float BaseDamage, AController EventInstigator, AActor DamageCauser, TSubclassOf<UDamageType> DamageTypeClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = DamagedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = BaseDamage;

				*(nint*)(__InBuffer + 12) = EventInstigator?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = DamageTypeClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ApplyDamage, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static void AnnounceAccessibleString(FString AnnouncementString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnnouncementString?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AnnounceAccessibleString, __InBuffer);
			}
		}

		/// <param name="ReverbEffect">
		/// Reverb Effect to use
		/// </param>
		/// <param name="TagName">
		/// Tag to associate with Reverb Effect
		/// </param>
		/// <param name="Priority">
		/// Priority of the Reverb Effect
		/// </param>
		/// <param name="Volume">
		/// Volume level of Reverb Effect
		/// </param>
		/// <param name="FadeTime">
		/// Time before Reverb Effect is fully active
		/// </param>
		public static void ActivateReverbEffect(UObject WorldContextObject, UReverbEffect ReverbEffect, FName TagName, float Priority = 0.000000f, float Volume = 0.500000f, float FadeTime = 2.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ReverbEffect?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = TagName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Priority;

				*(float*)(__InBuffer + 28) = Volume;

				*(float*)(__InBuffer + 32) = FadeTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ActivateReverbEffect, __InBuffer);
			}
		}

		private static uint __UnRetainAllSoundsInSoundClass = 0;

		private static uint __UnloadStreamLevelBySoftObjectPtr = 0;

		private static uint __UnloadStreamLevel = 0;

		private static uint __SuggestProjectileVelocity_MovingTarget = 0;

		private static uint __SuggestProjectileVelocity_CustomArc = 0;

		private static uint __SpawnSoundAttached = 0;

		private static uint __SpawnSoundAtLocation = 0;

		private static uint __SpawnSound2D = 0;

		private static uint __SpawnObject = 0;

		private static uint __SpawnForceFeedbackAttached = 0;

		private static uint __SpawnForceFeedbackAtLocation = 0;

		private static uint __SpawnEmitterAttached = 0;

		private static uint __SpawnEmitterAtLocation = 0;

		private static uint __SpawnDialogueAttached = 0;

		private static uint __SpawnDialogueAtLocation = 0;

		private static uint __SpawnDialogue2D = 0;

		private static uint __SpawnDecalAttached = 0;

		private static uint __SpawnDecalAtLocation = 0;

		private static uint __SetWorldOriginLocation = 0;

		private static uint __SetViewportMouseCaptureMode = 0;

		private static uint __SetSubtitlesEnabled = 0;

		private static uint __SetSoundMixClassOverride = 0;

		private static uint __SetSoundClassDistanceScale = 0;

		private static uint __SetPlayerPlatformUserId = 0;

		private static uint __SetPlayerControllerID = 0;

		private static uint __SetMaxAudioChannelsScaled = 0;

		private static uint __SetGlobalTimeDilation = 0;

		private static uint __SetGlobalPitchModulation = 0;

		private static uint __SetGlobalListenerFocusParameters = 0;

		private static uint __SetGamePaused = 0;

		private static uint __SetForceDisableSplitscreen = 0;

		private static uint __SetEnableWorldRendering = 0;

		private static uint __SetBaseSoundMix = 0;

		private static uint __SetActiveSpatialPluginByName = 0;

		private static uint __SaveGameToSlot = 0;

		private static uint __RemovePlayer = 0;

		private static uint __RebaseZeroOriginOntoLocal = 0;

		private static uint __RebaseLocalOriginOntoZero = 0;

		private static uint __PushSoundMixModifier = 0;

		private static uint __ProjectWorldToScreen = 0;

		private static uint __PrimeSound = 0;

		private static uint __PrimeAllSoundsInSoundClass = 0;

		private static uint __PopSoundMixModifier = 0;

		private static uint __PlayWorldCameraShake = 0;

		private static uint __PlaySoundAtLocation = 0;

		private static uint __PlaySound2D = 0;

		private static uint __PlayDialogueAtLocation = 0;

		private static uint __PlayDialogue2D = 0;

		private static uint __ParseOption = 0;

		private static uint __OpenLevelBySoftObjectPtr = 0;

		private static uint __OpenLevel = 0;

		private static uint __ObjectIsA = 0;

		private static uint __MakeHitResult = 0;

		private static uint __LoadStreamLevelBySoftObjectPtr = 0;

		private static uint __LoadStreamLevel = 0;

		private static uint __LoadGameFromSlot = 0;

		private static uint __IsSplitscreenForceDisabled = 0;

		private static uint __IsGamePaused = 0;

		private static uint __IsAnyLocalPlayerCameraWithinRange = 0;

		private static uint __HasOption = 0;

		private static uint __HasLaunchOption = 0;

		private static uint __GrassOverlappingSphereCount = 0;

		private static uint __GetWorldOriginLocation = 0;

		private static uint __GetWorldDeltaSeconds = 0;

		private static uint __GetViewProjectionMatrix = 0;

		private static uint __GetViewportMouseCaptureMode = 0;

		private static uint __GetUnpausedTimeSeconds = 0;

		private static uint __GetTimeSeconds = 0;

		private static uint __GetSurfaceType = 0;

		private static uint __GetStreamingLevel = 0;

		private static uint __GetRealTimeSeconds = 0;

		private static uint __GetPlayerStateFromUniqueNetId = 0;

		private static uint __GetPlayerState = 0;

		private static uint __GetPlayerPawn = 0;

		private static uint __GetPlayerControllerID = 0;

		private static uint __GetPlayerControllerFromPlatformUser = 0;

		private static uint __GetPlayerControllerFromID = 0;

		private static uint __GetPlayerController = 0;

		private static uint __GetPlayerCharacter = 0;

		private static uint __GetPlayerCameraManager = 0;

		private static uint __GetPlatformName = 0;

		private static uint __GetObjectClass = 0;

		private static uint __GetNumPlayerStates = 0;

		private static uint __GetNumPlayerControllers = 0;

		private static uint __GetNumLocalPlayerControllers = 0;

		private static uint __GetMaxAudioChannelCount = 0;

		private static uint __GetKeyValue = 0;

		private static uint __GetIntOption = 0;

		private static uint __GetGlobalTimeDilation = 0;

		private static uint __GetGameState = 0;

		private static uint __GetGameMode = 0;

		private static uint __GetGameInstance = 0;

		private static uint __GetEnableWorldRendering = 0;

		private static uint __GetCurrentReverbEffect = 0;

		private static uint __GetCurrentLevelName = 0;

		private static uint __GetClosestListenerLocation = 0;

		private static uint __GetAvailableSpatialPluginNames = 0;

		private static uint __GetAudioTimeSeconds = 0;

		private static uint __GetAllActorsWithTag = 0;

		private static uint __GetAllActorsWithInterface = 0;

		private static uint __GetAllActorsOfClassWithTag = 0;

		private static uint __GetAllActorsOfClass = 0;

		private static uint __GetActorOfClass = 0;

		private static uint __GetActorArrayBounds = 0;

		private static uint __GetActorArrayAverageLocation = 0;

		private static uint __GetActiveSpatialPluginName = 0;

		private static uint __GetAccurateRealTime = 0;

		private static uint __FlushLevelStreaming = 0;

		private static uint __FinishSpawningActor = 0;

		private static uint __FindNearestActor = 0;

		private static uint __FindCollisionUV = 0;

		private static uint __EnableLiveStreaming = 0;

		private static uint __DoesSaveGameExist = 0;

		private static uint __DeprojectScreenToWorld = 0;

		private static uint __DeprojectSceneCaptureToWorld = 0;

		private static uint __DeleteGameInSlot = 0;

		private static uint __DeactivateReverbEffect = 0;

		private static uint __CreateSound2D = 0;

		private static uint __CreateSaveGameObject = 0;

		private static uint __CreatePlayerFromPlatformUser = 0;

		private static uint __CreatePlayer = 0;

		private static uint __ClearSoundMixModifiers = 0;

		private static uint __ClearSoundMixClassOverride = 0;

		private static uint __CancelAsyncLoading = 0;

		private static uint __BreakHitResult = 0;

		private static uint __BlueprintSuggestProjectileVelocity = 0;

		private static uint __Blueprint_PredictProjectilePath_ByTraceChannel = 0;

		private static uint __Blueprint_PredictProjectilePath_ByObjectType = 0;

		private static uint __Blueprint_PredictProjectilePath_Advanced = 0;

		private static uint __BeginSpawningActorFromBlueprint = 0;

		private static uint __BeginDeferredActorSpawnFromClass = 0;

		private static uint __AreSubtitlesEnabled = 0;

		private static uint __AreAnyListenersWithinRange = 0;

		private static uint __ApplyRadialDamageWithFalloff = 0;

		private static uint __ApplyRadialDamage = 0;

		private static uint __ApplyPointDamage = 0;

		private static uint __ApplyDamage = 0;

		private static uint __AnnounceAccessibleString = 0;

		private static uint __ActivateReverbEffect = 0;
	}
}