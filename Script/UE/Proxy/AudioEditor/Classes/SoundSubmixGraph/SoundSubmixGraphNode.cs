using Script.CoreUObject;
using Script.Engine;
using Script.UMG;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundSubmixGraphNode")]
	public partial class USoundSubmixGraphNode : UEdGraphNode, IStaticClass
	{
		public USoundSubmixBase SoundSubmix
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoundSubmix, __ReturnBuffer);

					return *(USoundSubmixBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoundSubmix, __InBuffer);
				}
			}
		}

		public UUserWidget SubmixNodeUserWidget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubmixNodeUserWidget, __ReturnBuffer);

					return *(UUserWidget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubmixNodeUserWidget, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundSubmixGraphNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SoundSubmix = 0;

		private static uint __SubmixNodeUserWidget = 0;
	}
}