using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundSubmixGraph")]
	public partial class USoundSubmixGraph : UEdGraph, IStaticClass
	{
		public USoundSubmixBase RootSoundSubmix
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootSoundSubmix, __ReturnBuffer);

					return *(USoundSubmixBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootSoundSubmix, __InBuffer);
				}
			}
		}

		public TArray<USoundSubmixBase> StaleRoots
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaleRoots, __ReturnBuffer);

					return *(TArray<USoundSubmixBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaleRoots, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundSubmixGraph");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RootSoundSubmix = 0;

		private static uint __StaleRoots = 0;
	}
}