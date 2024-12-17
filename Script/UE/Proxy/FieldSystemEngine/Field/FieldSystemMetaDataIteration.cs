using Script.CoreUObject;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.FieldSystemMetaDataIteration")]
	public partial class UFieldSystemMetaDataIteration : UFieldSystemMetaData, IStaticClass
	{
		public int Iterations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Iterations, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Iterations, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.FieldSystemMetaDataIteration");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Iterations">
		/// Number of iterations (WIP)
		/// </param>
		public virtual UFieldSystemMetaDataIteration SetMetaDataIteration(int Iterations)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Iterations;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetMetaDataIteration, __InBuffer, __ReturnBuffer);

				return *(UFieldSystemMetaDataIteration*)__ReturnBuffer;
			}
		}

		private static uint __Iterations = 0;

		private static uint __SetMetaDataIteration = 0;
	}
}