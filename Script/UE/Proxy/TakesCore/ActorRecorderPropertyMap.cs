using Script.CoreUObject;
using Script.Library;

namespace Script.TakesCore
{
	[PathName("/Script/TakesCore.ActorRecorderPropertyMap")]
	public partial class UActorRecorderPropertyMap : UObject, IStaticClass
	{
		public TSoftObjectPtr<UObject> RecordedObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RecordedObject, __ReturnBuffer);

					return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RecordedObject, __InBuffer);
				}
			}
		}

		public TArray<FActorRecordedProperty> Properties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Properties, __ReturnBuffer);

					return *(TArray<FActorRecordedProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Properties, __InBuffer);
				}
			}
		}

		public TArray<UActorRecorderPropertyMap> Children
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Children, __ReturnBuffer);

					return *(TArray<UActorRecorderPropertyMap>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Children, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakesCore.ActorRecorderPropertyMap");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RecordedObject = 0;

		private static uint __Properties = 0;

		private static uint __Children = 0;
	}
}