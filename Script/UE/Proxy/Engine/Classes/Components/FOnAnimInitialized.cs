﻿using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnAnimInitialized : FMulticastDelegate<Action>
	{
		public FOnAnimInitialized() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAnimInitialized() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
