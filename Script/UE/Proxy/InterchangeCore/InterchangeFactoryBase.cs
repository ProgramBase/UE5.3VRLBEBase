using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangeFactoryBase")]
	public partial class UInterchangeFactoryBase : UObject, IStaticClass
	{
		public UInterchangeResultsContainer Results
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Results, __ReturnBuffer);

					return *(UInterchangeResultsContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Results, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeCore.InterchangeFactoryBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UClass GetFactoryClass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFactoryClass, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		private static uint __Results = 0;

		private static uint __GetFactoryClass = 0;
	}
}