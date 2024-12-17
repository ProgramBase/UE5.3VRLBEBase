﻿using System;
using Script.CoreUObject;
using Script.Library;
using Script.InputCore;

namespace Script.Engine
{
	public class FComponentOnInputTouchEndSignature : FMulticastDelegate<Action<ETouchIndex, UPrimitiveComponent>>
	{
		public FComponentOnInputTouchEndSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FComponentOnInputTouchEndSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)FingerIndex;

				*(nint*)(__InBuffer + 1) = TouchedComponent?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}