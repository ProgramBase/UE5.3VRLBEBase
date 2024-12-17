using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectMidSideSpreaderSettings")]
	public partial class FSourceEffectMidSideSpreaderSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SourceEffectMidSideSpreaderSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSourceEffectMidSideSpreaderSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSourceEffectMidSideSpreaderSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSourceEffectMidSideSpreaderSettings A, FSourceEffectMidSideSpreaderSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSourceEffectMidSideSpreaderSettings A, FSourceEffectMidSideSpreaderSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSourceEffectMidSideSpreaderSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float SpreadAmount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpreadAmount, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpreadAmount, __InBuffer);
				}
			}
		}

		public EStereoChannelMode InputMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputMode, __ReturnBuffer);

					return *(EStereoChannelMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputMode, __InBuffer);
				}
			}
		}

		public EStereoChannelMode OutputMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OutputMode, __ReturnBuffer);

					return *(EStereoChannelMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OutputMode, __InBuffer);
				}
			}
		}

		public bool bEqualPower
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEqualPower, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEqualPower, __InBuffer);
				}
			}
		}

		private static uint __SpreadAmount = 0;

		private static uint __InputMode = 0;

		private static uint __OutputMode = 0;

		private static uint __bEqualPower = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}