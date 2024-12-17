using Script.CoreUObject;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.UniformInteger")]
	public partial class UUniformInteger : UFieldNodeInt, IStaticClass
	{
		public int Magnitude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Magnitude, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Magnitude, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.UniformInteger");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Magnitude">
		/// The field output will be equal the magnitude
		/// </param>
		public virtual UUniformInteger SetUniformInteger(int Magnitude)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Magnitude;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetUniformInteger, __InBuffer, __ReturnBuffer);

				return *(UUniformInteger*)__ReturnBuffer;
			}
		}

		private static uint __Magnitude = 0;

		private static uint __SetUniformInteger = 0;
	}
}