using Script.CoreUObject;
using Script.PhysicsCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RadialForceComponent")]
	public partial class URadialForceComponent : USceneComponent, IStaticClass
	{
		public float Radius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Radius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Radius, __InBuffer);
				}
			}
		}

		public ERadialImpulseFalloff Falloff
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Falloff, __ReturnBuffer);

					return *(ERadialImpulseFalloff*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Falloff, __InBuffer);
				}
			}
		}

		public float ImpulseStrength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ImpulseStrength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ImpulseStrength, __InBuffer);
				}
			}
		}

		public bool bImpulseVelChange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bImpulseVelChange, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bImpulseVelChange, __InBuffer);
				}
			}
		}

		public bool bIgnoreOwningActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreOwningActor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreOwningActor, __InBuffer);
				}
			}
		}

		public float ForceStrength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForceStrength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForceStrength, __InBuffer);
				}
			}
		}

		public float DestructibleDamage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DestructibleDamage, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DestructibleDamage, __InBuffer);
				}
			}
		}

		public TArray<EObjectTypeQuery> ObjectTypesToAffect
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectTypesToAffect, __ReturnBuffer);

					return *(TArray<EObjectTypeQuery>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectTypesToAffect, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RadialForceComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RemoveObjectTypeToAffect(EObjectTypeQuery ObjectType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)ObjectType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveObjectTypeToAffect, __InBuffer);
			}
		}

		public virtual void FireImpulse()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FireImpulse);
			}
		}

		public virtual void AddObjectTypeToAffect(EObjectTypeQuery ObjectType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)ObjectType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddObjectTypeToAffect, __InBuffer);
			}
		}

		private static uint __Radius = 0;

		private static uint __Falloff = 0;

		private static uint __ImpulseStrength = 0;

		private static uint __bImpulseVelChange = 0;

		private static uint __bIgnoreOwningActor = 0;

		private static uint __ForceStrength = 0;

		private static uint __DestructibleDamage = 0;

		private static uint __ObjectTypesToAffect = 0;

		private static uint __RemoveObjectTypeToAffect = 0;

		private static uint __FireImpulse = 0;

		private static uint __AddObjectTypeToAffect = 0;
	}
}