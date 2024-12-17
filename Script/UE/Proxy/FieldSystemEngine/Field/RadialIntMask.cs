using Script.CoreUObject;
using Script.Chaos;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.RadialIntMask")]
	public partial class URadialIntMask : UFieldNodeInt, IStaticClass
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

		public int InteriorValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InteriorValue, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InteriorValue, __InBuffer);
				}
			}
		}

		public int ExteriorValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExteriorValue, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExteriorValue, __InBuffer);
				}
			}
		}

		public ESetMaskConditionType SetMaskCondition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SetMaskCondition, __ReturnBuffer);

					return *(ESetMaskConditionType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SetMaskCondition, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.RadialIntMask");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Radius">
		/// Radius of the radial field
		/// </param>
		/// <param name="Position">
		/// Center position of the radial field"
		/// </param>
		/// <param name="InteriorValue">
		/// If the sample distance from the center is less than radius, the intermediate value will be set the interior value
		/// </param>
		/// <param name="ExteriorValue">
		/// If the sample distance from the center is greater than radius, the intermediate value will be set the exterior value
		/// </param>
		/// <param name="SetMaskConditionIn">
		/// If the mask condition is set to always the output value will be the intermediate one. If set to not interior/exterior the output value will be the intermediate one if the input is different from the interior/exterior value
		/// </param>
		public virtual URadialIntMask SetRadialIntMask(float Radius, FVector Position, int InteriorValue, int ExteriorValue, ESetMaskConditionType SetMaskConditionIn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(float*)(__InBuffer) = Radius;

				*(nint*)(__InBuffer + 4) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 12) = InteriorValue;

				*(int*)(__InBuffer + 16) = ExteriorValue;

				*(byte*)(__InBuffer + 20) = (byte)SetMaskConditionIn;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetRadialIntMask, __InBuffer, __ReturnBuffer);

				return *(URadialIntMask*)__ReturnBuffer;
			}
		}

		private static uint __Radius = 0;

		private static uint __Position = 0;

		private static uint __InteriorValue = 0;

		private static uint __ExteriorValue = 0;

		private static uint __SetMaskCondition = 0;

		private static uint __SetRadialIntMask = 0;
	}
}