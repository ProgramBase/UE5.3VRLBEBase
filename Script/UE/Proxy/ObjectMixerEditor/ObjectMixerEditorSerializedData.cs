using Script.CoreUObject;
using Script.Library;

namespace Script.ObjectMixerEditor
{
	[PathName("/Script/ObjectMixerEditor.ObjectMixerEditorSerializedData")]
	public partial class UObjectMixerEditorSerializedData : UObject, IStaticClass
	{
		public TSet<FObjectMixerSerializationDataPerFilter> SerializedDataPerFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SerializedDataPerFilter, __ReturnBuffer);

					return *(TSet<FObjectMixerSerializationDataPerFilter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SerializedDataPerFilter, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ObjectMixerEditor.ObjectMixerEditorSerializedData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SerializedDataPerFilter = 0;
	}
}