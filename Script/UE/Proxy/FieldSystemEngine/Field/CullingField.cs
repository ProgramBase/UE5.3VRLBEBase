using Script.CoreUObject;
using Script.Chaos;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.CullingField")]
	public partial class UCullingField : UFieldNodeBase, IStaticClass
	{
		public UFieldNodeBase Culling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Culling, __ReturnBuffer);

					return *(UFieldNodeBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Culling, __InBuffer);
				}
			}
		}

		public UFieldNodeBase Field
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Field, __ReturnBuffer);

					return *(UFieldNodeBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Field, __InBuffer);
				}
			}
		}

		public EFieldCullingOperationType Operation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Operation, __ReturnBuffer);

					return *(EFieldCullingOperationType*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.CullingField");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Culling">
		/// Culling field to be used.
		/// </param>
		/// <param name="Field">
		/// Input field that will be evaluated according to the culling field result.
		/// </param>
		/// <param name="Operation">
		/// Evaluate the input field if the result of the culling field is equal to 0 (Inside) or different from 0 (Outside).
		/// </param>
		public virtual UCullingField SetCullingField(UFieldNodeBase Culling, UFieldNodeBase Field, EFieldCullingOperationType Operation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Culling?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Field?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Operation;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetCullingField, __InBuffer, __ReturnBuffer);

				return *(UCullingField*)__ReturnBuffer;
			}
		}

		private static uint __Culling = 0;

		private static uint __Field = 0;

		private static uint __Operation = 0;

		private static uint __SetCullingField = 0;
	}
}