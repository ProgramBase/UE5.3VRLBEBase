using Script.CoreUObject;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.ToFloatField")]
	public partial class UToFloatField : UFieldNodeFloat, IStaticClass
	{
		public UFieldNodeInt IntField
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IntField, __ReturnBuffer);

					return *(UFieldNodeInt*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IntField, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.ToFloatField");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="IntegerField">
		/// Integer field to be converted to an a float one
		/// </param>
		public virtual UToFloatField SetToFloatField(UFieldNodeInt IntegerField)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = IntegerField?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetToFloatField, __InBuffer, __ReturnBuffer);

				return *(UToFloatField*)__ReturnBuffer;
			}
		}

		private static uint __IntField = 0;

		private static uint __SetToFloatField = 0;
	}
}