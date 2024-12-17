using System;
using Script.CoreUObject;
using Script.Library;
using Script.AudioWidgets;

namespace Script.AudioWidgets.AudioMeter
{
	public class FGetMeterChannelInfo : FDelegate<Func<TArray<FMeterChannelInfo>>>
	{
		public FGetMeterChannelInfo() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGetMeterChannelInfo() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public TArray<FMeterChannelInfo> Execute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_CompoundExecute1Implementation(GarbageCollectionHandle, __ReturnBuffer);

				return *(TArray<FMeterChannelInfo>*)__ReturnBuffer;
			}
		}
	}
}
