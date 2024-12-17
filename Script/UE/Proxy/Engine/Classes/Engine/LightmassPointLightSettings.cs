﻿using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LightmassPointLightSettings")]
	public partial class FLightmassPointLightSettings : FLightmassLightSettings, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.LightmassPointLightSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLightmassPointLightSettings()
		{
		}

		public static bool operator ==(FLightmassPointLightSettings A, FLightmassPointLightSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLightmassPointLightSettings A, FLightmassPointLightSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLightmassPointLightSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}