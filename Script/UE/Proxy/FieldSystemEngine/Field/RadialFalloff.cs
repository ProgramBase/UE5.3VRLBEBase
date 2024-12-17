using Script.CoreUObject;
using Script.Chaos;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.RadialFalloff")]
	public partial class URadialFalloff : UFieldNodeFloat, IStaticClass
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.RadialFalloff");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Magnitude">
		/// Magnitude of the sphere falloff field
		/// </param>
		/// <param name="MinRange">
		/// The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude
		/// </param>
		/// <param name="MaxRange">
		/// The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude
		/// </param>
		/// <param name="Default">
		/// The field value will be set to Default if the sample distance from the center is higher than the radius
		/// </param>
		/// <param name="Radius">
		/// Radius of the sphere falloff field
		/// </param>
		/// <param name="Position">
		/// Center position of the sphere falloff field
		/// </param>
		/// <param name="Falloff">
		/// Type of falloff function used if the falloff function is picked
		/// </param>
		public virtual URadialFalloff SetRadialFalloff(float Magnitude, float MinRange, float MaxRange, float Default, float Radius, FVector Position, EFieldFalloffType Falloff)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(float*)(__InBuffer) = Magnitude;

				*(float*)(__InBuffer + 4) = MinRange;

				*(float*)(__InBuffer + 8) = MaxRange;

				*(float*)(__InBuffer + 12) = Default;

				*(float*)(__InBuffer + 16) = Radius;

				*(nint*)(__InBuffer + 20) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 28) = (byte)Falloff;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetRadialFalloff, __InBuffer, __ReturnBuffer);

				return *(URadialFalloff*)__ReturnBuffer;
			}
		}

		private static uint __Magnitude = 0;

		private static uint __MinRange = 0;

		private static uint __MaxRange = 0;

		private static uint __Default = 0;

		private static uint __Radius = 0;

		private static uint __Position = 0;

		private static uint __Falloff = 0;

		private static uint __SetRadialFalloff = 0;
	}
}