using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnAudioFinished : FMulticastDelegate<Action>
	{
		public FOnAudioFinished() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAudioFinished() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
