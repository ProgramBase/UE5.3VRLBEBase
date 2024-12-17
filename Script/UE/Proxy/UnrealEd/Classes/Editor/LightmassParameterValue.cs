using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LightmassParameterValue")]
	public partial class FLightmassParameterValue : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.LightmassParameterValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLightmassParameterValue() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLightmassParameterValue() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLightmassParameterValue A, FLightmassParameterValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLightmassParameterValue A, FLightmassParameterValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLightmassParameterValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverride, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverride, __InBuffer);
				}
			}
		}

		private static uint __bOverride = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}