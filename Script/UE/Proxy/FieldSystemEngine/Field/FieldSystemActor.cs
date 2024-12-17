using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.FieldSystemActor")]
	public partial class AFieldSystemActor : AActor, IStaticClass
	{
		public UFieldSystemComponent FieldSystemComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FieldSystemComponent, __ReturnBuffer);

					return *(UFieldSystemComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FieldSystemComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.FieldSystemActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FieldSystemComponent = 0;
	}
}