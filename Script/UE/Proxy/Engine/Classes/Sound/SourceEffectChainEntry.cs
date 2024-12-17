using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SourceEffectChainEntry")]
	public partial class FSourceEffectChainEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SourceEffectChainEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSourceEffectChainEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSourceEffectChainEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSourceEffectChainEntry A, FSourceEffectChainEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSourceEffectChainEntry A, FSourceEffectChainEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSourceEffectChainEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public USoundEffectSourcePreset Preset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Preset, __ReturnBuffer);

					return *(USoundEffectSourcePreset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Preset, __InBuffer);
				}
			}
		}

		public bool bBypass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bBypass, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bBypass, __InBuffer);
				}
			}
		}

		private static uint __Preset = 0;

		private static uint __bBypass = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}