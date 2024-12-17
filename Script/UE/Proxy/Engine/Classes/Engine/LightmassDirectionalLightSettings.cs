using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LightmassDirectionalLightSettings")]
	public partial class FLightmassDirectionalLightSettings : FLightmassLightSettings, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.LightmassDirectionalLightSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLightmassDirectionalLightSettings()
		{
		}

		public static bool operator ==(FLightmassDirectionalLightSettings A, FLightmassDirectionalLightSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLightmassDirectionalLightSettings A, FLightmassDirectionalLightSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLightmassDirectionalLightSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float LightSourceAngle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LightSourceAngle, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LightSourceAngle, __InBuffer);
				}
			}
		}

		private static uint __LightSourceAngle = 0;

	}
}