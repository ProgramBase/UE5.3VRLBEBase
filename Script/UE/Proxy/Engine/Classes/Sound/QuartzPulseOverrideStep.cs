using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.QuartzPulseOverrideStep")]
	public partial class FQuartzPulseOverrideStep : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.QuartzPulseOverrideStep");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FQuartzPulseOverrideStep() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FQuartzPulseOverrideStep() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FQuartzPulseOverrideStep A, FQuartzPulseOverrideStep B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FQuartzPulseOverrideStep A, FQuartzPulseOverrideStep B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FQuartzPulseOverrideStep;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int NumberOfPulses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumberOfPulses, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumberOfPulses, __InBuffer);
				}
			}
		}

		public EQuartzCommandQuantization PulseDuration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PulseDuration, __ReturnBuffer);

					return *(EQuartzCommandQuantization*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PulseDuration, __InBuffer);
				}
			}
		}

		private static uint __NumberOfPulses = 0;

		private static uint __PulseDuration = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}