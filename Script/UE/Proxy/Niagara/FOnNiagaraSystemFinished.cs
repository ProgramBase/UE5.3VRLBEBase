using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	public class FOnNiagaraSystemFinished : FMulticastDelegate<Action<UNiagaraComponent>>
	{
		public FOnNiagaraSystemFinished() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnNiagaraSystemFinished() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UNiagaraComponent PSystem)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PSystem?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
