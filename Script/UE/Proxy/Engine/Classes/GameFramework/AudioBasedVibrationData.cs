using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AudioBasedVibrationData")]
	public partial class FAudioBasedVibrationData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AudioBasedVibrationData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAudioBasedVibrationData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAudioBasedVibrationData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAudioBasedVibrationData A, FAudioBasedVibrationData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAudioBasedVibrationData A, FAudioBasedVibrationData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAudioBasedVibrationData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public USoundBase Sound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Sound, __ReturnBuffer);

					return *(USoundBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Sound, __InBuffer);
				}
			}
		}

		private static uint __Sound = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}