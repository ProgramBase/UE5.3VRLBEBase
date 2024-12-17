using Script.CoreUObject;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.ToIntegerField")]
	public partial class UToIntegerField : UFieldNodeInt, IStaticClass
	{
		public UFieldNodeFloat FloatField
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FloatField, __ReturnBuffer);

					return *(UFieldNodeFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FloatField, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.ToIntegerField");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="FloatField">
		/// Float field to be converted to an an integer one
		/// </param>
		public virtual UToIntegerField SetToIntegerField(UFieldNodeFloat FloatField)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = FloatField?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetToIntegerField, __InBuffer, __ReturnBuffer);

				return *(UToIntegerField*)__ReturnBuffer;
			}
		}

		private static uint __FloatField = 0;

		private static uint __SetToIntegerField = 0;
	}
}