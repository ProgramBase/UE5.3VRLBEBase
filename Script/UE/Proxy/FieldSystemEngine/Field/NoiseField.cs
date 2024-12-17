using Script.CoreUObject;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.NoiseField")]
	public partial class UNoiseField : UFieldNodeFloat, IStaticClass
	{
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.NoiseField");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="MinRange">
		/// The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude
		/// </param>
		/// <param name="MaxRange">
		/// The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude
		/// </param>
		/// <param name="Transform">
		/// Transform of the box in which the perlin noise will be defined
		/// </param>
		public virtual UNoiseField SetNoiseField(float MinRange, float MaxRange, FTransform Transform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(float*)(__InBuffer) = MinRange;

				*(float*)(__InBuffer + 4) = MaxRange;

				*(nint*)(__InBuffer + 8) = Transform?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetNoiseField, __InBuffer, __ReturnBuffer);

				return *(UNoiseField*)__ReturnBuffer;
			}
		}

		private static uint __MinRange = 0;

		private static uint __MaxRange = 0;

		private static uint __Transform = 0;

		private static uint __SetNoiseField = 0;
	}
}