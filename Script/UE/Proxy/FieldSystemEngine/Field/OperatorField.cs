using Script.CoreUObject;
using Script.Chaos;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.OperatorField")]
	public partial class UOperatorField : UFieldNodeBase, IStaticClass
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

		public UFieldNodeBase RightField
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RightField, __ReturnBuffer);

					return *(UFieldNodeBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RightField, __InBuffer);
				}
			}
		}

		public UFieldNodeBase LeftField
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LeftField, __ReturnBuffer);

					return *(UFieldNodeBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LeftField, __InBuffer);
				}
			}
		}

		public EFieldOperationType Operation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Operation, __ReturnBuffer);

					return *(EFieldOperationType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Operation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.OperatorField");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Magnitude">
		/// Magnitude of the operator field
		/// </param>
		/// <param name="LeftField">
		/// Input field A to be processed
		/// </param>
		/// <param name="RightField">
		/// Input field B to be processed
		/// </param>
		/// <param name="Operation">
		/// Type of math operation you want to perform between the 2 fields
		/// </param>
		public virtual UOperatorField SetOperatorField(float Magnitude, UFieldNodeBase LeftField, UFieldNodeBase RightField, EFieldOperationType Operation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(float*)(__InBuffer) = Magnitude;

				*(nint*)(__InBuffer + 4) = LeftField?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = RightField?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 20) = (byte)Operation;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetOperatorField, __InBuffer, __ReturnBuffer);

				return *(UOperatorField*)__ReturnBuffer;
			}
		}

		private static uint __Magnitude = 0;

		private static uint __RightField = 0;

		private static uint __LeftField = 0;

		private static uint __Operation = 0;

		private static uint __SetOperatorField = 0;
	}
}