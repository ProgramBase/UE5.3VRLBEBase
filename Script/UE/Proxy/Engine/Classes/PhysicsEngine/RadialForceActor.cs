using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RadialForceActor")]
	public partial class ARadialForceActor : ARigidBodyBase, IStaticClass
	{
		public URadialForceComponent ForceComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForceComponent, __ReturnBuffer);

					return *(URadialForceComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForceComponent, __InBuffer);
				}
			}
		}

		public UBillboardComponent SpriteComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteComponent, __ReturnBuffer);

					return *(UBillboardComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RadialForceActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ToggleForce()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ToggleForce);
			}
		}

		public virtual void FireImpulse()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FireImpulse);
			}
		}

		public virtual void EnableForce()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EnableForce);
			}
		}

		public virtual void DisableForce()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DisableForce);
			}
		}

		private static uint __ForceComponent = 0;

		private static uint __SpriteComponent = 0;

		private static uint __ToggleForce = 0;

		private static uint __FireImpulse = 0;

		private static uint __EnableForce = 0;

		private static uint __DisableForce = 0;
	}
}