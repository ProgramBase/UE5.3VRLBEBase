using Script.CoreUObject;
using Script.AudioExtensions;
using Script.Library;

namespace Script.ResonanceAudio
{
	[PathName("/Script/ResonanceAudio.ResonanceAudioSoundfieldSettings")]
	public partial class UResonanceAudioSoundfieldSettings : USoundfieldEncodingSettingsBase, IStaticClass
	{
		public EResonanceRenderMode RenderMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RenderMode, __ReturnBuffer);

					return *(EResonanceRenderMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RenderMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ResonanceAudio.ResonanceAudioSoundfieldSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RenderMode = 0;
	}
}