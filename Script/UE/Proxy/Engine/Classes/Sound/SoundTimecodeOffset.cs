using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundTimecodeOffset")]
	public partial class FSoundTimecodeOffset : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SoundTimecodeOffset");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundTimecodeOffset() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSoundTimecodeOffset() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSoundTimecodeOffset A, FSoundTimecodeOffset B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundTimecodeOffset A, FSoundTimecodeOffset B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundTimecodeOffset;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public double NumOfSecondsSinceMidnight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumOfSecondsSinceMidnight, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumOfSecondsSinceMidnight, __InBuffer);
				}
			}
		}

		private static uint __NumOfSecondsSinceMidnight = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}