using Script.CoreUObject;
using Script.AudioMixer;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.VoipListenerSynthComponent")]
	public partial class UVoipListenerSynthComponent : USynthComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.VoipListenerSynthComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// true if this synth component is out of audio to play. 
		/// </returns>
		public virtual bool IsIdling()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsIdling, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __IsIdling = 0;
	}
}