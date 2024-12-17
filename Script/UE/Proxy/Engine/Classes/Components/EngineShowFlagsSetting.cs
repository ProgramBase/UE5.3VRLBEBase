using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EngineShowFlagsSetting")]
	public partial class FEngineShowFlagsSetting : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.EngineShowFlagsSetting");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEngineShowFlagsSetting() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEngineShowFlagsSetting() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEngineShowFlagsSetting A, FEngineShowFlagsSetting B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEngineShowFlagsSetting A, FEngineShowFlagsSetting B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEngineShowFlagsSetting;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ShowFlagName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShowFlagName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShowFlagName, __InBuffer);
				}
			}
		}

		public bool Enabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Enabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Enabled, __InBuffer);
				}
			}
		}

		private static uint __ShowFlagName = 0;

		private static uint __Enabled = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}