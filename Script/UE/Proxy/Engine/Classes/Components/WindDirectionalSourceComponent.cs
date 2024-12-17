using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WindDirectionalSourceComponent")]
	public partial class UWindDirectionalSourceComponent : USceneComponent, IStaticClass
	{
		public float Strength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Strength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Strength, __InBuffer);
				}
			}
		}

		public float Speed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Speed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Speed, __InBuffer);
				}
			}
		}

		public float MinGustAmount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinGustAmount, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinGustAmount, __InBuffer);
				}
			}
		}

		public float MaxGustAmount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxGustAmount, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxGustAmount, __InBuffer);
				}
			}
		}

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

		public bool bPointWind
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPointWind, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPointWind, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WindDirectionalSourceComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetWindType(EWindSourceType InNewType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InNewType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWindType, __InBuffer);
			}
		}

		public virtual void SetStrength(float InNewStrength)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InNewStrength;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStrength, __InBuffer);
			}
		}

		public virtual void SetSpeed(float InNewSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InNewSpeed;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSpeed, __InBuffer);
			}
		}

		public virtual void SetRadius(float InNewRadius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InNewRadius;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRadius, __InBuffer);
			}
		}

		public virtual void SetMinimumGustAmount(float InNewMinGust)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InNewMinGust;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMinimumGustAmount, __InBuffer);
			}
		}

		public virtual void SetMaximumGustAmount(float InNewMaxGust)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InNewMaxGust;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaximumGustAmount, __InBuffer);
			}
		}

		private static uint __Strength = 0;

		private static uint __Speed = 0;

		private static uint __MinGustAmount = 0;

		private static uint __MaxGustAmount = 0;

		private static uint __Radius = 0;

		private static uint __bPointWind = 0;

		private static uint __SetWindType = 0;

		private static uint __SetStrength = 0;

		private static uint __SetSpeed = 0;

		private static uint __SetRadius = 0;

		private static uint __SetMinimumGustAmount = 0;

		private static uint __SetMaximumGustAmount = 0;
	}
}