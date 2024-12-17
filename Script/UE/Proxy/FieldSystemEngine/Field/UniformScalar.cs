using Script.CoreUObject;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.UniformScalar")]
	public partial class UUniformScalar : UFieldNodeFloat, IStaticClass
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.UniformScalar");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Magnitude">
		/// The field output will be equal the magnitude
		/// </param>
		public virtual UUniformScalar SetUniformScalar(float Magnitude)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Magnitude;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetUniformScalar, __InBuffer, __ReturnBuffer);

				return *(UUniformScalar*)__ReturnBuffer;
			}
		}

		private static uint __Magnitude = 0;

		private static uint __SetUniformScalar = 0;
	}
}