using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialParameterCollectionInstance")]
	public partial class UMaterialParameterCollectionInstance : UObject, IStaticClass
	{
		public TWeakObjectPtr<UMaterialParameterCollection> Collection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Collection, __ReturnBuffer);

					return *(TWeakObjectPtr<UMaterialParameterCollection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Collection, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialParameterCollectionInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Collection = 0;
	}
}