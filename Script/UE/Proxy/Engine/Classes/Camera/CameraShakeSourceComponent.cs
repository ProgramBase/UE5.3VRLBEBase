using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraShakeSourceComponent")]
	public partial class UCameraShakeSourceComponent : USceneComponent, IStaticClass
	{
		public ECameraShakeAttenuation Attenuation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Attenuation, __ReturnBuffer);

					return *(ECameraShakeAttenuation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Attenuation, __InBuffer);
				}
			}
		}

		public float InnerAttenuationRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InnerAttenuationRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InnerAttenuationRadius, __InBuffer);
				}
			}
		}

		public float OuterAttenuationRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OuterAttenuationRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OuterAttenuationRadius, __InBuffer);
				}
			}
		}

		public TSubclassOf<UCameraShakeBase> CameraShake
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CameraShake, __ReturnBuffer);

					return *(TSubclassOf<UCameraShakeBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CameraShake, __InBuffer);
				}
			}
		}

		public bool bAutoStart
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoStart, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoStart, __InBuffer);
				}
			}
		}

		public UTexture2D EditorSpriteTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorSpriteTexture, __ReturnBuffer);

					return *(UTexture2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorSpriteTexture, __InBuffer);
				}
			}
		}

		public float EditorSpriteTextureScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorSpriteTextureScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorSpriteTextureScale, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CameraShakeSourceComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StopAllCameraShakesOfType(TSubclassOf<UCameraShakeBase> InCameraShake, bool bImmediately = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InCameraShake?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bImmediately;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAllCameraShakesOfType, __InBuffer);
			}
		}

		public virtual void StopAllCameraShakes(bool bImmediately = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bImmediately;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAllCameraShakes, __InBuffer);
			}
		}

		public virtual void StartCameraShake(TSubclassOf<UCameraShakeBase> InCameraShake, float Scale = 1.000000f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = null)
		{
			unsafe
			{
				UserPlaySpaceRot ??= new FRotator();

				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = InCameraShake?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Scale;

				*(byte*)(__InBuffer + 12) = (byte)PlaySpace;

				*(nint*)(__InBuffer + 13) = UserPlaySpaceRot?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartCameraShake, __InBuffer);
			}
		}

		public virtual void Start()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Start);
			}
		}

		public virtual float GetAttenuationFactor(FVector Location)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Location?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetAttenuationFactor, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __Attenuation = 0;

		private static uint __InnerAttenuationRadius = 0;

		private static uint __OuterAttenuationRadius = 0;

		private static uint __CameraShake = 0;

		private static uint __bAutoStart = 0;

		private static uint __EditorSpriteTexture = 0;

		private static uint __EditorSpriteTextureScale = 0;

		private static uint __StopAllCameraShakesOfType = 0;

		private static uint __StopAllCameraShakes = 0;

		private static uint __StartCameraShake = 0;

		private static uint __Start = 0;

		private static uint __GetAttenuationFactor = 0;
	}
}