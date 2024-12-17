using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PhysicalAnimationComponent")]
	public partial class UPhysicalAnimationComponent : UActorComponent, IStaticClass
	{
		public float StrengthMultiplyer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StrengthMultiplyer, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StrengthMultiplyer, __InBuffer);
				}
			}
		}

		public USkeletalMeshComponent SkeletalMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletalMeshComponent, __ReturnBuffer);

					return *(USkeletalMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletalMeshComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PhysicalAnimationComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetStrengthMultiplyer(float InStrengthMultiplyer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InStrengthMultiplyer;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStrengthMultiplyer, __InBuffer);
			}
		}

		public virtual void SetSkeletalMeshComponent(USkeletalMeshComponent InSkeletalMeshComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSkeletalMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSkeletalMeshComponent, __InBuffer);
			}
		}

		public virtual FTransform GetBodyTargetTransform(FName BodyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BodyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBodyTargetTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual void ApplyPhysicalAnimationSettingsBelow(FName BodyName, FPhysicalAnimationData PhysicalAnimationData, bool bIncludeSelf = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BodyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PhysicalAnimationData?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bIncludeSelf;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyPhysicalAnimationSettingsBelow, __InBuffer);
			}
		}

		public virtual void ApplyPhysicalAnimationSettings(FName BodyName, FPhysicalAnimationData PhysicalAnimationData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BodyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PhysicalAnimationData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyPhysicalAnimationSettings, __InBuffer);
			}
		}

		/// <param name="BodyName">
		/// The body from which we'd like to start applying the physical animation profile. Finds all bodies below in the skeleton hierarchy. None implies all bodies
		/// </param>
		/// <param name="ProfileName">
		/// The physical animation profile we'd like to apply. For each body in the physics asset we search for physical animation settings with this name.
		/// </param>
		/// <param name="bIncludeSelf">
		/// Whether to include the provided body name in the list of bodies we act on (useful to ignore for cases where a root has multiple children)
		/// </param>
		/// <param name="bClearNotFound">
		/// If true, bodies without the given profile name will have any existing physical animation settings cleared. If false, bodies without the given profile name are left untouched.
		/// </param>
		public virtual void ApplyPhysicalAnimationProfileBelow(FName BodyName, FName ProfileName, bool bIncludeSelf = true, bool bClearNotFound = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = BodyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bIncludeSelf;

				*(bool*)(__InBuffer + 17) = bClearNotFound;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyPhysicalAnimationProfileBelow, __InBuffer);
			}
		}

		private static uint __StrengthMultiplyer = 0;

		private static uint __SkeletalMeshComponent = 0;

		private static uint __SetStrengthMultiplyer = 0;

		private static uint __SetSkeletalMeshComponent = 0;

		private static uint __GetBodyTargetTransform = 0;

		private static uint __ApplyPhysicalAnimationSettingsBelow = 0;

		private static uint __ApplyPhysicalAnimationSettings = 0;

		private static uint __ApplyPhysicalAnimationProfileBelow = 0;
	}
}