using Script.CoreUObject;
using Script.Chaos;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.BoxFalloff")]
	public partial class UBoxFalloff : UFieldNodeFloat, IStaticClass
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

		public FTransform Transform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Transform, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Transform, __InBuffer);
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.BoxFalloff");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Magnitude">
		/// Magnitude of the box falloff field
		/// </param>
		/// <param name="MinRange">
		/// The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude
		/// </param>
		/// <param name="MaxRange">
		/// The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude
		/// </param>
		/// <param name="Default">
		/// The field value will be set to Default if the sample distance from the box is higher than the scale of the transform
		/// </param>
		/// <param name="Transform">
		/// Translation, Rotation and Scale of the unit box
		/// </param>
		/// <param name="Falloff">
		/// Type of falloff function used to model the evolution of the field from the box surface to the sample position
		/// </param>
		public virtual UBoxFalloff SetBoxFalloff(float Magnitude, float MinRange, float MaxRange, float Default, FTransform Transform, EFieldFalloffType Falloff)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(float*)(__InBuffer) = Magnitude;

				*(float*)(__InBuffer + 4) = MinRange;

				*(float*)(__InBuffer + 8) = MaxRange;

				*(float*)(__InBuffer + 12) = Default;

				*(nint*)(__InBuffer + 16) = Transform?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)Falloff;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetBoxFalloff, __InBuffer, __ReturnBuffer);

				return *(UBoxFalloff*)__ReturnBuffer;
			}
		}

		private static uint __Magnitude = 0;

		private static uint __MinRange = 0;

		private static uint __MaxRange = 0;

		private static uint __Default = 0;

		private static uint __Transform = 0;

		private static uint __Falloff = 0;

		private static uint __SetBoxFalloff = 0;
	}
}