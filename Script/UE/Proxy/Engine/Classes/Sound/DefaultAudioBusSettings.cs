using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DefaultAudioBusSettings")]
	public partial class FDefaultAudioBusSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DefaultAudioBusSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDefaultAudioBusSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDefaultAudioBusSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDefaultAudioBusSettings A, FDefaultAudioBusSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDefaultAudioBusSettings A, FDefaultAudioBusSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDefaultAudioBusSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSoftObjectPath AudioBus
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AudioBus, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AudioBus, __InBuffer);
				}
			}
		}

		private static uint __AudioBus = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}