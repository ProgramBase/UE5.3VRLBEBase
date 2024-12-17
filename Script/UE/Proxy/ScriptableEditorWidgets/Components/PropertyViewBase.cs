using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.ScriptableEditorWidgets
{
	[PathName("/Script/ScriptableEditorWidgets.PropertyViewBase")]
	public partial class UPropertyViewBase : UWidget, IStaticClass
	{
		public TSoftObjectPtr<UObject> Object
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Object, __ReturnBuffer);

					return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Object, __InBuffer);
				}
			}
		}

		public bool bAutoLoadAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoLoadAsset, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoLoadAsset, __InBuffer);
				}
			}
		}

		public FOnPropertyValueChanged OnPropertyChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPropertyChanged, __ReturnBuffer);

					return *(FOnPropertyValueChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPropertyChanged, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ScriptableEditorWidgets.PropertyViewBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetObject(UObject NewObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetObject, __InBuffer);
			}
		}

		public virtual UObject GetObject()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetObject, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		private static uint __Object = 0;

		private static uint __bAutoLoadAsset = 0;

		private static uint __OnPropertyChanged = 0;

		private static uint __SetObject = 0;

		private static uint __GetObject = 0;
	}
}