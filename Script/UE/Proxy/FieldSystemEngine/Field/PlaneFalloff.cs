using Script.CoreUObject;
using Script.Chaos;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.PlaneFalloff")]
	public partial class UPlaneFalloff : UFieldNodeFloat, IStaticClass
	{
		public float Magnitude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Magnitude, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Magnitude, __InBuffer);
				}
			}
		}

		public float MinRange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinRange, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinRange, __InBuffer);
				}
			}
		}

		public float MaxRange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxRange, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxRange, __InBuffer);
				}
			}
		}

		public float Default
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Default, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Default, __InBuffer);
				}
			}
		}

		public float Distance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Distance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Distance, __InBuffer);
				}
			}
		}

		public FVector Position
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Position, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Position, __InBuffer);
				}
			}
		}

		public FVector Normal
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Normal, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Normal, __InBuffer);
				}
			}
		}

		public EFieldFalloffType Falloff
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Falloff, __ReturnBuffer);

					return *(EFieldFalloffType*)__ReturnBuffer;
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.PlaneFalloff");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Magnitude">
		/// Magnitude of the plane falloff field
		/// </param>
		/// <param name="MinRange">
		/// The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude
		/// </param>
		/// <param name="MaxRange">
		/// The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude
		/// </param>
		/// <param name="Default">
		/// The field value will be set to default if the sample projected distance ((Sample Position - Center Position).dot(Plane Normal)) is higher than the Plane Distance 
		/// </param>
		/// <param name="Distance">
		/// Distance limit for the plane falloff field starting from the center position and extending in the direction of the plane normal
		/// </param>
		/// <param name="Position">
		/// Plane center position of the plane falloff field
		/// </param>
		/// <param name="Normal">
		/// Plane normal of the plane falloff field
		/// </param>
		/// <param name="Falloff">
		/// Type of falloff function used to model the evolution of the field from the plane surface to the distance isosurface
		/// </param>
		public virtual UPlaneFalloff SetPlaneFalloff(float Magnitude, float MinRange, float MaxRange, float Default, float Distance, FVector Position, FVector Normal, EFieldFalloffType Falloff)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(float*)(__InBuffer) = Magnitude;

				*(float*)(__InBuffer + 4) = MinRange;

				*(float*)(__InBuffer + 8) = MaxRange;

				*(float*)(__InBuffer + 12) = Default;

				*(float*)(__InBuffer + 16) = Distance;

				*(nint*)(__InBuffer + 20) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = Normal?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 36) = (byte)Falloff;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetPlaneFalloff, __InBuffer, __ReturnBuffer);

				return *(UPlaneFalloff*)__ReturnBuffer;
			}
		}

		private static uint __Magnitude = 0;

		private static uint __MinRange = 0;

		private static uint __MaxRange = 0;

		private static uint __Default = 0;

		private static uint __Distance = 0;

		private static uint __Position = 0;

		private static uint __Normal = 0;

		private static uint __Falloff = 0;

		private static uint __SetPlaneFalloff = 0;
	}
}