using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.TemplateSequenceEditor
{
	[PathName("/Script/TemplateSequenceEditor.TemplateSequenceFactoryNew")]
	public partial class UTemplateSequenceFactoryNew : UFactory, IStaticClass
	{
		public TSubclassOf<UObject> BoundActorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoundActorClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoundActorClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequenceEditor.TemplateSequenceFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BoundActorClass = 0;
	}
}