using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.AnimationSequenceBrowserContextMenuContext")]
	public partial class UAnimationSequenceBrowserContextMenuContext : UObject, IStaticClass
	{
		public TArray<TWeakObjectPtr<UObject>> SelectedObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedObjects, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<UObject>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedObjects, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.AnimationSequenceBrowserContextMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual TArray<UObject> GetSelectedObjects()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSelectedObjects, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		private static uint __SelectedObjects = 0;

		private static uint __GetSelectedObjects = 0;
	}
}