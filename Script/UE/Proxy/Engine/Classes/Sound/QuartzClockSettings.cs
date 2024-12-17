using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.QuartzClockSettings")]
	public partial class FQuartzClockSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.QuartzClockSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FQuartzClockSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FQuartzClockSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FQuartzClockSettings A, FQuartzClockSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FQuartzClockSettings A, FQuartzClockSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FQuartzClockSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FQuartzTimeSignature TimeSignature
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TimeSignature, __ReturnBuffer);

					return *(FQuartzTimeSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TimeSignature, __InBuffer);
				}
			}
		}

		public bool bIgnoreLevelChange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIgnoreLevelChange, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIgnoreLevelChange, __InBuffer);
				}
			}
		}

		private static uint __TimeSignature = 0;

		private static uint __bIgnoreLevelChange = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}